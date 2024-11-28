using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    internal class InsertDatabaseData
    {

        FlightBooking_Session session;
        int UsertId { get; set; }
        string ReferenceNumber { get; set; }

        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        private MySqlConnection _connection;
        private int TransactionID { get; set; }
        private String Type { get; set; }
        private int DepartureTicketID { get; set; }
        private int ReturnTicketID { get; set; }

        public InsertDatabaseData(int UserID, String ReferenceNumber)
        {
            this.session = FlightBooking_Session.Instance;
            Type = session.Type;
            this.UsertId = UserID;
            this.ReferenceNumber = ReferenceNumber;

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

        public async Task InsertDatabase()
        {
            try
            {
                await _connection.OpenAsync();
                if (Type == "One Way")
                {
                    await InsertTransaction();
                    await InsertPassengerDetails();
                    await InsertTicketDetails("Departure");
                }
                else if (Type == "Round Trip")
                {
                    await InsertTransaction();
                    await InsertPassengerDetails();
                    await InsertTicketDetails("Departure");
                    await InsertTicketDetails("Return");
                }
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task InsertTransaction()
        {
            MySqlTransaction transaction = await _connection.BeginTransactionAsync();
            try
            {

                String query = "INSERT INTO transactions (AccountID, BookingDate, ReferenceNo) " +
               "VALUES (@AccountId, @BookingDate, @ReferenceNo)";

                String lastIdQuery = "SELECT LAST_INSERT_ID();";

                var command = new MySqlCommand(query, _connection, transaction);
                command.Parameters.AddWithValue("@AccountId", UsertId);
                command.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                command.Parameters.AddWithValue("@ReferenceNo", ReferenceNumber);

                await command.ExecuteNonQueryAsync();

                command = new MySqlCommand(lastIdQuery, _connection, transaction);
                TransactionID = Convert.ToInt32(await command.ExecuteScalarAsync());
                await transaction.CommitAsync();

            }
            catch (SqlException e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                await transaction.RollbackAsync();
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public async Task<Int32> SelectFlightID(String AirplaneNumber)
        {
            try
            {


                String query = "SELECT FlightID FROM flights WHERE AirplaneNumber = @AirplaneNumber";

                var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@AirplaneNumber", AirplaneNumber);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error selecting flight id: {ex.Message}");
                return 0;
            }
            finally
            {
            }
        }
        public async Task InsertTicketDetails(string flight)
        {
            var transaction = await _connection.BeginTransactionAsync();

            try
            {
                string query = "INSERT INTO ticketdetails(TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) " +
                               "VALUES (@TransactionID, @FlightID, @NumberOfTickets, @Children, @Infant, @Food, @Baggage, @TransferServices, @TotalPrice)";

                int flightID = 0;

                if (flight == "Return")
                {
                    flightID = await SelectFlightID(session.ReturnAirplaneNumber);
                }
                else if (flight == "Departure")
                {
                    flightID = await SelectFlightID(session.DepartureAirplaneNumber);
                }

                if (flightID == 0)
                {
                    throw new Exception($"Flight ID for '{flight}' could not be determined.");
                }

                int numberOfTickets = 0;

                if (session.FlightDetails.TryGetValue("Number of Adults", out string adults) &&
                    session.FlightDetails.TryGetValue("Number of Children", out string children) &&
                    session.FlightDetails.TryGetValue("Number of Infants", out string infants))
                {
                    numberOfTickets = int.Parse(adults) + int.Parse(children) + int.Parse(infants);
                }
                else
                {
                    throw new InvalidOperationException("Missing flight details for ticket calculation.");
                }

                using (var command = new MySqlCommand(query, _connection, transaction))
                {
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);
                    command.Parameters.AddWithValue("@FlightID", flightID);
                    command.Parameters.AddWithValue("@NumberOfTickets", numberOfTickets);
                    command.Parameters.AddWithValue("@Children", int.Parse(children));
                    command.Parameters.AddWithValue("@Infant", int.Parse(infants));
                    command.Parameters.AddWithValue("@Food", session.Addons["Food"] ? "Yes" : "No");
                    command.Parameters.AddWithValue("@Baggage", session.Addons["Baggage"] ? "Yes" : "No");
                    command.Parameters.AddWithValue("@TransferServices", session.Addons["Transport"] ? "Yes" : "No");
                    command.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(session.BookingSubTotal));
                    await command.ExecuteNonQueryAsync();
                }

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show($"Error inserting ticket details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                transaction.Dispose();

            }
        }



        public async Task InsertPassengerDetails()
        {
            MySqlTransaction transaction = await _connection.BeginTransactionAsync();

            try
            {

                string query = "INSERT INTO passengers(TransactionID, Type, FirstName, LastName, Age, Birthdate) " +
                "VALUES (@TransactionID, @Type, @FirstName, @LastName, @Age, @Birthdate)";


                foreach (var outerEntry in session.PassengerDetails)
                {
                    string type = outerEntry.Key;
                    var innerDictionary = outerEntry.Value;

                    string firstName = innerDictionary["First Name"];
                    string lastName = innerDictionary["Last Name"];
                    int age = int.Parse(innerDictionary["Age"]);
                    DateTime birthdate = DateTime.Parse(innerDictionary["Birthdate"]);


                    using (var command = new MySqlCommand(query, _connection, transaction))
                    {
                        command.Parameters.AddWithValue("@TransactionID", TransactionID);
                        command.Parameters.AddWithValue("@Type", type);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Birthdate", birthdate);
                        await command.ExecuteNonQueryAsync();
                    }
                }
                await transaction.CommitAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting passenger details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await transaction.RollbackAsync();
            }
            finally
            {
                transaction.Dispose();
            }
        }

        public async Task InsertPayment()
        {
            var transaction = await _connection.BeginTransactionAsync();

            try
            {
                string query = "INSERT INTO payment(TransactionID, ModeOfPayment, ReferenceNo) VALUES (@TransactionID, @ModeOfPayment, @ReferenceNumber)";
                var command = new MySqlCommand(query, _connection, transaction);

                command.Parameters.AddWithValue("@TransactionID", TransactionID);
                command.Parameters.AddWithValue("@ModeOfPayment", session.PaymentDetails["Payment Type"]);
                command.Parameters.AddWithValue("@ReferenceNumber", session.PaymentDetails["Reference Number"]);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting payment details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await transaction.RollbackAsync();
            }
            finally
            {
                transaction.Dispose();

            }

        }
    }
}

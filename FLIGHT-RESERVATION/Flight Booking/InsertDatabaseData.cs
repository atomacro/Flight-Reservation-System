using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    internal class InsertDatabaseData
    {
        FlightBooking_Session session = new FlightBooking_Session();
        int UsertId { get; set; }
        string ReferenceNumber { get; set; }

        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        private MySqlConnection _connection;
        private int TransactionID {  get; set; }
        private String Type {  get; set; }
        private int DepartureTicketID {  get; set; }
        private int ReturnTicketID {  get; set; }

        public InsertDatabaseData(int UserID, String ReferenceNumber, String Type) { 
            this.UsertId = UserID;
            this.ReferenceNumber = ReferenceNumber;

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            InsertDatabase();
        }

        public async void InsertDatabase()
        {
            if(Type == "One Way")
            {
               await InsertPassengerDetails();
               await InsertTransaction();
               await InsertTicketDetails("Departure");
            }else if(Type == "Round Trip")
            {
                await InsertPassengerDetails();
                await InsertTransaction();
                await InsertTicketDetails("Departure");
                await InsertTicketDetails("Return");
            }
        }

        public async Task InsertTransaction()
        {
            await _connection.OpenAsync();
            MySqlTransaction transaction = await _connection.BeginTransactionAsync();
            try
            {

                String query = "INSERT INTO transactions (AccountID, BookingDate, ReferenceNo) " +
               "VALUES (@AccountId, @BookingDate, @ReferenceNo)";

                var command = new MySqlCommand(query, _connection, transaction);
                command.Parameters.AddWithValue("@AccountId", UsertId);
                command.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                command.Parameters.AddWithValue("@ReferenceNo", ReferenceNumber);

                await command.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                TransactionID = Convert.ToInt32(await command.ExecuteScalarAsync());
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                await transaction.RollbackAsync();

            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async Task<Int32> SelectFlightID(String AirplaneNumber)
        {
            await _connection.OpenAsync();
            try
            {
                String query = "SELECT FlightID FROM flights WHERE AirplaneNumber = @AirplaneNumber";

                var command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@AirplaneNumber", AirplaneNumber);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }
        public async Task InsertTicketDetails(String flight)
        {
            await _connection.OpenAsync();
            MySqlTransaction transaction = await _connection.BeginTransactionAsync();

            try
            {
                String query = "INSERT INTO ticketdetails(TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) " +
                    "Values(@TransactionID, @FlightID, @NumberOfTickets, @Children, @Infant, @Food, @Baggage, @TransferServices, @TotalPrice";

                if(flight == "Return") await Insert(Convert.ToInt32(SelectFlightID(session.DepartureAirplaneNumber)), flight);
                else if (flight == "Departure") await Insert(Convert.ToInt32(SelectFlightID(session.DepartureAirplaneNumber)), flight);

            async Task Insert(int FlightID, String Type)
                {
                int NumberOfTickets = int.Parse(session.FlightDetails["Number Of Children"]) + int.Parse(session.FlightDetails["Number Of Infants"]) + int.Parse(session.FlightDetails["Number Of Adults"]);

                var command = new MySqlCommand(query, _connection, transaction);
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);
                    command.Parameters.AddWithValue("@FlightID", FlightID);
                    command.Parameters.AddWithValue("@NumberOfTickers", NumberOfTickets);
                    command.Parameters.AddWithValue("@Children", int.Parse(session.FlightDetails["Number of Children"]));
                    command.Parameters.AddWithValue("@Infant", int.Parse(session.FlightDetails["Number of Infants"]));
                    command.Parameters.AddWithValue("@Food", int.Parse(session.Addons["Food"] ? "Yes" : "No"));
                    command.Parameters.AddWithValue("@Baggage", int.Parse(session.Addons["Baggage"] ? "Yes" : "No"));
                    command.Parameters.AddWithValue("@TransferServices", int.Parse(session.Addons["Transport"] ? "Yes" : "No"));
                    command.Parameters.AddWithValue("@TotalPrice", Convert.ToInt32(session.TotalPrice));
                    await command.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();
                }
            }
            catch
            {
                await transaction.RollbackAsync();

            }
            finally
            {
                await _connection.CloseAsync();

            }

        }

        public async Task InsertPassengerDetails()
        {
            await _connection.OpenAsync();
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
                await transaction.RollbackAsync();
            }
            finally
            {

            }
        }



    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
        private int DepartureID {  get; set; }
        private int ReturnID {  get; set; }

        public InsertDatabaseData(int UserID, String ReferenceNumber, String Type) { 
            this.UsertId = UserID;
            this.ReferenceNumber = ReferenceNumber;

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

        public async void InsertDatabase()
        {

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

        public async Task SelectFlightID()
        {

        }

        public async Task InsertTicketDetails()
        {
            await _connection.OpenAsync();
            MySqlTransaction transaction = await _connection.BeginTransactionAsync();

            try
            {

                int NumberOfTickets = int.Parse(session.FlightDetails["Number Of Children"]) + int.Parse(session.FlightDetails["Number Of Infants"])+ int.Parse(session.FlightDetails["Number Of Adults"]);



                String query = "INSERT INTO ticketdetails(TransactionID, FlightID, NumberOfTickets, Children, Infant, Food, Baggage, TransferServices, TotalPrice) " +
                    "Values(@TransactionID, @FlightID, @NumberOfTickets, @Children, @Infant, @Food, @Baggage, @TransferServices, @TotalPrice";

                 var command = new MySqlCommand(query, _connection, transaction);
                command.Parameters.AddWithValue("@TransactionID", TransactionID);
                command.Parameters.AddWithValue("@FlightID", "AAAA");
                command.Parameters.AddWithValue("@NumberOfTickers", NumberOfTickets);
                command.Parameters.AddWithValue("@Children", int.Parse(session.FlightDetails["Number of Children"]));
                command.Parameters.AddWithValue("@Infant", int.Parse(session.FlightDetails["Number of Infants"]));
                command.Parameters.AddWithValue("@Food", int.Parse(session.Addons["Food"] ? "Yes" : "No"));
                command.Parameters.AddWithValue("@Baggage", int.Parse(session.Addons["Baggage"] ? "Yes" : "No"));
                command.Parameters.AddWithValue("@TransferServices", int.Parse(session.Addons["Transport"] ? "Yes" : "No"));
                command.Parameters.AddWithValue("@TotalPrice", Convert.ToInt32(session.TotalPrice));

                await command.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                //DepartureTicketID = Convert.ToInt32(await command.ExecuteScalarAsync());
                //ReturnTicketID = Convert.ToInt32(await command.ExecuteScalarAsync())



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



    }
}

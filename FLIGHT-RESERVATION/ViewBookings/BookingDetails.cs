using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.ViewBookings
{
    public partial class BookingDetails : Form
    {
        private int transactionID;
        private int flightID;

        public BookingDetails(int transactionID, int flightID, string DepartureLocation, string ArrivalLocation, string DepartureTime, string ArrivalTime)
        {
            InitializeComponent();
            this.transactionID = transactionID;
            this.flightID = flightID;

            SetupInitialUI(
                DepartureLocation,
                ArrivalLocation,
                DepartureTime,
                ArrivalTime
            );
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BookingDetails_Load(object sender, EventArgs e)
        {
            PopulateBookingDetails();
        }

        private void PopulateBookingDetails()
        {
            DB_Booking_Details DB_Booking = new DB_Booking_Details();
            DB_Booking.getBookingDetails(transactionID, flightID);

            lblAirplaneNumber.Text = DB_Booking.AirplaneNum;
            lblBookingDate.Text = DB_Booking.BookingDate.ToString("MMMM dd, yyyy");
            lblDepartureDate.Text = DB_Booking.Departure.ToString("MMMM dd, yyyy");
            lblArrivalDate.Text = DB_Booking.Arrival.ToString("MMMM dd, yyyy");

            StringBuilder passengersList = new StringBuilder();
            foreach (string passenger in DB_Booking.passengers) passengersList.AppendLine(passenger);
            lblPassengers.Text = passengersList.ToString();

            StringBuilder addons = new StringBuilder();
            if (DB_Booking.hasFood) addons.AppendLine("Food");
            if (DB_Booking.hasBaggage) addons.AppendLine("Baggage");
            if (DB_Booking.hasTransferServices) addons.AppendLine("Transport Services");
            lblAddons.Text = addons.ToString();

            lblTotalPrice.Text = DB_Booking.Price.ToString("N2") + " Php";
        }

        private void SetupInitialUI(string departureLocation, string arrivalLocation, string departureTime, string arrivalTime)
        {
            lblLocation1.Text = departureLocation;
            lblLocation2.Text = arrivalLocation;
            lblTime1.Text = departureTime;
            lblTime2.Text = arrivalTime;
        }
    }

    public class DB_Booking_Details
    {
        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
        private readonly String _databaseName = "airplaneticketingsystem2024";
        private readonly String _userName = "root";
        private readonly String _password = "";

        public string AirplaneNum;
        public DateTime BookingDate;
        public DateTime Departure;
        public DateTime Arrival;
        public string fullName;
        public int Price;
        public List<string> passengers = new List<string>();
        public List<string> Addons = new List<string>();
        public bool hasFood = false;
        public bool hasBaggage = false;
        public bool hasTransferServices = false;


        public DB_Booking_Details()
        {
            string connectionString =
                $"Server=localhost;Database={this._databaseName};User ID={this._userName};Password={this._password};";
            _connection = new MySqlConnection(connectionString);
        }

        public void getBookingDetails(int transactionID, int flightID)
        {
            OpenConnection();

            string query = @"SELECT Transactions.BookingDate AS BookingDate,
                            Flights.AirplaneNumber, Flights.DepartureDate, Flights.ArrivalDate, 
                            Passengers.FirstName AS FirstName, Passengers.LastName AS LastName, 
                            TicketDetails.Food AS Food, TicketDetails.Baggage AS Baggage, TicketDetails.TransferServices AS TransferServices, TicketDetails.TotalPrice AS Price
                            FROM flights
                            JOIN TicketDetails ON Flights.FlightID = TicketDetails.FlightID
                            JOIN Transactions ON TicketDetails.TransactionID = Transactions.TransactionID
                            JOIN Passengers ON Transactions.TransactionID = Passengers.TransactionID
                            WHERE TicketDetails.TransactionID = @TransactionID AND TicketDetails.FlightID = @FlightID
                            ";
            
            try
            {
                MySqlCommand command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@TransactionID", transactionID);
                command.Parameters.AddWithValue("@FlightID", flightID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AirplaneNum = reader.GetString("AirplaneNumber");
                        BookingDate = reader.GetDateTime("BookingDate");
                        Departure = reader.GetDateTime("DepartureDate");
                        Arrival = reader.GetDateTime("ArrivalDate");
                        Price = reader.GetInt32("Price");

                        fullName = reader.GetString("FirstName") + " " + reader.GetString("LastName");
                        if (!passengers.Contains(fullName))
                        {
                            passengers.Add(fullName);
                        }

                        if (!hasFood) hasFood = reader.GetString("Food") == "Yes";
                        if (!hasBaggage) hasBaggage = reader.GetString("Baggage") == "Yes";
                        if (!hasTransferServices) hasTransferServices = reader.GetString("TransferServices") == "Yes";
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        private void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}

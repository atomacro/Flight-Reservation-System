using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FLIGHT_RESERVATION.ViewBookings
{
    public partial class ViewBookings : UserControl
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {



            Database_View_Bookings dv_view_bookings = new Database_View_Bookings(1); // 1 is account ID
            for (int i = 0; i < dv_view_bookings.DepartureDate.Count; i++)
            {
                Bookings bookings = new Bookings();
 
                bookings.Margin = new Padding(0, 0, 0, 10);
                bookings.SetDate(dv_view_bookings.DepartureDate[i]);
                bookings.setLocation(dv_view_bookings.DepartureLocation[i], dv_view_bookings.ArrivalLocation[i]);
                bookings.setTime(dv_view_bookings.DepartureTime[i], dv_view_bookings.ArrivalTime[i]);
                pnlBookings.Controls.Add(bookings);
                
            }
        }
    }
    public class Database_View_Bookings
    {

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        private int AccountId;
        public List<String> DepartureDate = new List<String>();
        public List<String> DepartureLocation = new List<String>();
        public List<String> ArrivalLocation = new List<String>();
        public List<String> DepartureTime = new List<string>();
        public List<String> ArrivalTime = new List<string>();

        
        public Database_View_Bookings(int AccountId)
        {
            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            this.AccountId = AccountId;
            query();
        }
        public void query()
        {
            _connection.Open();
            _transaction = _connection.BeginTransaction();

            try
            {
                string query = "SELECT Flights.DepartureDate, Flights.ArrivalDate, " +
                                               "ArrivalAirport.AirportCode AS ArrivalAirportCode, " +
                                               "DepartureAirport.AirportCode AS DepartureAirportCode " +
                                               "FROM Flights " +
                                               "JOIN TicketDetails ON Flights.FlightID = TicketDetails.FlightID " +
                                               "JOIN Airport AS DepartureAirport ON Flights.DepartureAirportID = DepartureAirport.AirportID " +
                                               "JOIN Airport AS ArrivalAirport ON Flights.ArrivalAirportID = ArrivalAirport.AirportID " +
                                               "JOIN Transactions ON Transactions.TransactionID = TicketDetails.TransactionID " +
                                               "JOIN Accounts ON Transactions.AccountID = Accounts.AccountID " +
                                               "WHERE Accounts.AccountID = @AccountId;"; 

                MySqlCommand command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@AccountId", this.AccountId);


                using (MySqlDataReader reader = command.ExecuteReader())
                {


                    while (reader.Read()) {
                        //get Date input to DateTime 
                        DateTime Departure = reader.GetDateTime("DepartureDate");
                        DateTime Arrival =reader.GetDateTime("ArrivalDate");
                        //convert to specific formats
                        string DepartureTime = Departure.ToString("HH:mm");
                        string ArrivalTime = Arrival.ToString("HH:mm");
                        string Date = Departure.ToString("MMMM dd, yyyy");

                        //get Departure and Arrival Location in db
                        string DepartureLocation = reader.GetString("DepartureAirportCode");
                        string ArrivalLocation = reader.GetString("ArrivalAirportCode");

                        //populate list
                        this.ArrivalLocation.Add(ArrivalLocation);
                        this.DepartureLocation.Add(DepartureLocation);
                        this.DepartureDate.Add(Date);
                        this.ArrivalTime.Add(ArrivalTime);
                        this.DepartureTime.Add(DepartureTime);
                    }
                }
        }
            catch(Exception ex) {

                MessageBox.Show("Error retrieving data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}

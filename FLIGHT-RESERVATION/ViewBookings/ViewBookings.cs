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
            InitializeSort();
            PopulateBookings("New");
        }

        private void InitializeSort()
        {
            String State = "New";
            btnSort.Text = "Latest First";
            btnSort.BackColor = Color.White;
            btnSort.ForeColor = ColorTranslator.FromHtml("#763AEE");

            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.FlatAppearance.BorderSize = 2;
            btnSort.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#763AEE");

            btnSort.Click += (s, e) => {
                if(State == "Old")
                {
                    State = "New";
                    btnSort.Text = "Latest First";
                    btnSort.BackColor = Color.White;
                    btnSort.ForeColor = ColorTranslator.FromHtml("#763AEE");
                    pnlBookings.Controls.Clear();


                }
                else
                {
                    State = "Old";
                    btnSort.Text = "Oldest First";
                    btnSort.ForeColor = Color.White;
                    btnSort.BackColor = ColorTranslator.FromHtml("#763AEE");
                    pnlBookings.Controls.Clear();
                }
                PopulateBookings(State);
            };
        }

        private void PopulateBookings(String sortState)
        {
            Database_View_Bookings dv_view_bookings = new Database_View_Bookings(Session.CurrentUser, sortState, pnlBookings, btnSort);
            for (int i = 0; i < dv_view_bookings.DepartureDate.Count; i++)
            {
                Bookings bookings = new Bookings();

                int currentIndex = i;
                bookings.btnViewBookingDetails.Click += (s, e) =>
                {
                    var bookingDetails = new BookingDetails(
                        dv_view_bookings.TransactionID[currentIndex], 
                        dv_view_bookings.FlightID[currentIndex],
                        dv_view_bookings.DepartureLocation[currentIndex], 
                        dv_view_bookings.ArrivalLocation[currentIndex],
                        dv_view_bookings.DepartureTime[currentIndex], 
                        dv_view_bookings.ArrivalTime[currentIndex]);
                    bookingDetails.ShowDialog();
                };

                bookings.Margin = new Padding(0, 0, 0, 10);
                bookings.SetDate(dv_view_bookings.DepartureDate[i]);
                bookings.setLocation(dv_view_bookings.DepartureLocation[i], dv_view_bookings.ArrivalLocation[i]);
                bookings.setTime(dv_view_bookings.DepartureTime[i], dv_view_bookings.ArrivalTime[i]);
                bookings.setAirplaneNumber(dv_view_bookings.AirplaneNumber[i]);
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
        public List<int> TransactionID = new List<int>();
        public List<int> FlightID = new List<int>();
        public List<String> DepartureDate = new List<String>();
        public List<String> DepartureLocation = new List<String>();
        public List<String> ArrivalLocation = new List<String>();
        public List<String> DepartureTime = new List<string>();
        public List<String> ArrivalTime = new List<string>();
        public List<String> AirplaneNumber = new List<string>();


        public Database_View_Bookings(int AccountId, String sortState, Panel pnlBookings, Button btnSort)
        {

            //Clear every populate
            this.DepartureDate.Clear();
            this.DepartureLocation.Clear();
            this.ArrivalLocation.Clear();
            this.DepartureTime.Clear();
            this.ArrivalTime.Clear();
            this.AirplaneNumber.Clear();

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            this.AccountId = AccountId;
            querySelect(sortState, pnlBookings, btnSort); //add pnlBookings for emptyBooking function, sortState for New or Old, Add btnSort so its not visible if the query is empty
        }
        public void querySelect(String sortState, Panel pnlBookings, Button btnSort)
        {
            _connection.Open();
            _transaction = _connection.BeginTransaction();

            try
            {
                String SortingCondition = "";

                if (sortState == "Old")
                {
                    SortingCondition = " ORDER BY Flights.DepartureDate DESC";
                }

                string query = "SELECT Flights.DepartureDate, Flights.ArrivalDate, Flights.AirplaneNumber, Flights.FlightID, " +
                                   "ArrivalAirport.AirportCode AS ArrivalAirportCode, " +
                                   "DepartureAirport.AirportCode AS DepartureAirportCode, " +
                                   "Transactions.TransactionID " +
                                   "FROM Flights " +
                                   "JOIN TicketDetails ON Flights.FlightID = TicketDetails.FlightID " +
                                   "JOIN Airport AS DepartureAirport ON Flights.DepartureAirportID = DepartureAirport.AirportID " +
                                   "JOIN Airport AS ArrivalAirport ON Flights.ArrivalAirportID = ArrivalAirport.AirportID " +
                                   "JOIN Transactions ON Transactions.TransactionID = TicketDetails.TransactionID " +
                                   "JOIN Accounts ON Transactions.AccountID = Accounts.AccountID " +
                                   "WHERE Accounts.AccountID = @AccountId" + SortingCondition;

                MySqlCommand command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@AccountId", this.AccountId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    if (!reader.HasRows)
                    {
                        EmptyBooking(pnlBookings, btnSort);
                        return;
                    }

                    btnSort.Visible = true; //make the button visible if the query is empty

                    while (reader.Read())
                    {
                        //get Date input to DateTime 
                        DateTime Departure = reader.GetDateTime("DepartureDate");
                        DateTime Arrival = reader.GetDateTime("ArrivalDate");
                        //convert to specific formats
                        string DepartureTime = Departure.ToString("HH:mm");
                        string ArrivalTime = Arrival.ToString("HH:mm");
                        string Date = Departure.ToString("MMMM dd, yyyy");

                        //get Departure and Arrival Location in db
                        string DepartureLocation = reader.GetString("DepartureAirportCode");
                        string ArrivalLocation = reader.GetString("ArrivalAirportCode");

                        //get AirplaneNumber
                        string AirplaneNumber = reader.GetString("AirplaneNumber");
                        int TransactionID = reader.GetInt32("TransactionID");
                        int FlightID = reader.GetInt32("FlightID");

                        //populate list
                        this.TransactionID.Add(TransactionID);
                        this.FlightID.Add(FlightID);
                        this.ArrivalLocation.Add(ArrivalLocation);
                        this.DepartureLocation.Add(DepartureLocation);
                        this.DepartureDate.Add(Date);
                        this.ArrivalTime.Add(ArrivalTime);
                        this.DepartureTime.Add(DepartureTime);
                        this.AirplaneNumber.Add(AirplaneNumber);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {

                MessageBox.Show($"Error retrieving data. Please try again. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void EmptyBooking(Panel pnlBookings, Button btnSort)
        {
            // Create a new label
            Label lblEmptyBookingMessage = new Label();
            btnSort.Visible = false;

            Panel EmptyPanel = new Panel();

            EmptyPanel.Height = pnlBookings.Height;
            EmptyPanel.Width = pnlBookings.Width;

            lblEmptyBookingMessage.Text = "Errr... That's Awkward. Have you booked a flight yet?";

            // Set the label's appearance
            lblEmptyBookingMessage.Font = new Font("Kantumruy Pro", 25, FontStyle.Bold);
            lblEmptyBookingMessage.Margin = new Padding(0, 60, 0, 0);
            lblEmptyBookingMessage.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            lblEmptyBookingMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblEmptyBookingMessage.AutoSize = true;
            lblEmptyBookingMessage.Dock = DockStyle.Fill;
            lblEmptyBookingMessage.BorderStyle = BorderStyle.FixedSingle;

            EmptyPanel.Controls.Add(lblEmptyBookingMessage);
            pnlBookings.Controls.Add(EmptyPanel);
        }
    }
}

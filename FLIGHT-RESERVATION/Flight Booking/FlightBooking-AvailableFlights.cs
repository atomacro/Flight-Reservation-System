﻿using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public partial class FlightBooking_AvailableFlights : UserControl
    {
        public String TripType = "";

        public FlightBooking_AvailableFlights(string tripType) //set Departure or Return
        {
            InitializeComponent();
            TripType = tripType;
        }

        private async void FlightBooking_AvailableFlights_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            await PopulateAvailableBookings();
            btnBack.FlatAppearance.BorderSize = 0;
            lblFlightType.Text = $"Select {TripType} Flight";
            this.ResumeLayout();
        }
        List<FlightsAvailable> availableFlights = new List<FlightsAvailable>();
        public async Task PopulateAvailableBookings()
        {

            this.SuspendLayout();

            try { 
            String DepartureLocation = "";
            String ArrivalLocation = "";
            String DepartureDate = "";

            if (this.TripType == "Departure")
            {

                DepartureLocation = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Departure Location") ? FlightBooking_Session.Instance.FlightDetails["Departure Location"] : null;
                ArrivalLocation = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Arrival Location") ? FlightBooking_Session.Instance.FlightDetails["Arrival Location"] : null;
                String Departure = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Departure Date") ? FlightBooking_Session.Instance.FlightDetails["Departure Date"] : null;
                DateTime parsedDate = DateTime.ParseExact(Departure, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
                DepartureDate = parsedDate.ToString("yyyy-MM-dd");
            }
            else
            {
                DepartureLocation = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Arrival Location") ? FlightBooking_Session.Instance.FlightDetails["Arrival Location"] : null;
                ArrivalLocation = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Departure Location") ? FlightBooking_Session.Instance.FlightDetails["Departure Location"] : null;
                String Departure = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Return Date") ? FlightBooking_Session.Instance.FlightDetails["Return Date"] : null;
                DateTime parsedDate = DateTime.ParseExact(Departure, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
                DepartureDate = parsedDate.ToString("yyyy-MM-dd");

            }


            //set Arrival Location and Departure Location, panel and button if no flights are seen
            Database_Available_Flights AvailableFlightsData = new Database_Available_Flights();
            await AvailableFlightsData.SelectAvailableFlights(DepartureLocation, ArrivalLocation, DepartureDate,pnlAvailableFlights, btnContinueAvailableFlights, btnBack, lblAvailableFlights, lblFlightType);


            int selectedIndex = 0;
                for (int i = 0; i < AvailableFlightsData.AirplaneNumber.Count; i++)
                {
                    FlightsAvailable AvailableFlight = new FlightsAvailable();

                    AvailableFlight.setDates(AvailableFlightsData.DepartureDate[i], AvailableFlightsData.ArrivalDate[i]);
                    AvailableFlight.setTime(AvailableFlightsData.ArrivalTime[i], AvailableFlightsData.DepartureTime[i]);
                    AvailableFlight.setLocations(AvailableFlightsData.DepartureLocation[i], AvailableFlightsData.ArrivalLocation[i]);
                    AvailableFlight.setTime(AvailableFlightsData.DepartureTime[i], AvailableFlightsData.ArrivalTime[i]);
                    AvailableFlight.setSeatsAvailable(AvailableFlightsData.AvailableSeats[i]);
                    AvailableFlight.setAirplaneNumber(AvailableFlightsData.AirplaneNumber[i]);
                    AvailableFlight.setPrice(AvailableFlightsData.Price[i]);

                    //lamda function to add event listener for selecting
                    AvailableFlight.btnBook.Click += (s, e) =>
                    {
                        selectedIndex = availableFlights.IndexOf(AvailableFlight); // get index of the selected Flight
                        setSelected(availableFlights, selectedIndex); // set the border of the AvailableFlight
                    };

                    availableFlights.Add(AvailableFlight); // add every instance of AvailableFlights to the list
                    pnlAvailableFlights.Controls.Add(AvailableFlight);
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        public String SelectedAirplane = "";
        public FlightsAvailable flight = null;

        public void setSelected(List<FlightsAvailable> availableFlights, int index)
        {
            for (int i = 0; i < availableFlights.Count; i++)
            {
                if (i == index) 
                {
                    if (availableFlights[i].btnBook.Text == "Select")
                    {
                        availableFlights[i].btnBook.Text = "Unselect";
                        availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Selected_Border);
                        SelectedAirplane = availableFlights[i].lblAirplaneNumber.Text;
                        flight = availableFlights[i];

                    }
                    else
                    {
                        availableFlights[i].btnBook.Text = "Select";
                        availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border);
                        SelectedAirplane = "";
                        flight = null;
                    }
                }
                else
                {
                    availableFlights[i].btnBook.Text = "Select";
                    availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border);
                }
            }
        }


        public bool SubmitSelectedAirplane()
        {

            if (string.IsNullOrWhiteSpace(SelectedAirplane))
            {
                MessageBox.Show("Please Select a Flight", "Select a Flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.TripType == "Departure")
            {
                FlightBooking_Session.Instance.setDepartureAirplaneDetails(flight);
                FlightBooking_Session.Instance.DepartureAirplaneNumber = SelectedAirplane;
                return true;
            }
            if (this.TripType == "Return")
            {
                FlightBooking_Session.Instance.setReturnAirplaneDetails(flight);

                FlightBooking_Session.Instance.ReturnAirplaneNumber = SelectedAirplane;
                return true;
            }

            MessageBox.Show("Illegal Action");
            return false;

        }
    }
    public class Database_Available_Flights
    {
        private MySqlConnection _connection;
        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        public List<String> DepartureLocation = new List<string>();
        public List<String> ArrivalLocation = new List<string>();
        public List<String> DepartureTime = new List<string>();
        public List<String> ArrivalTime = new List<string>();
        public List<String> AirplaneNumber = new List<string>();
        public List<String> AvailableSeats = new List<string>();
        public List<String> DepartureDate = new List<string>();
        public List<String> ArrivalDate = new List<string>();
        public List<float> Price = new List<float>();

        public Database_Available_Flights()
        {

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            this.DepartureLocation.Clear();
            this.ArrivalLocation.Clear();
            this.DepartureTime.Clear();
            this.ArrivalTime.Clear();
            this.AirplaneNumber.Clear();
            this.AvailableSeats.Clear();
            this.Price.Clear();

        }

        public async Task SelectAvailableFlights(String FromLocation, String ToLocation, String DepartureDate, Panel pnlAvailableFlights, Button btnContinue, Button btnBack, Label lblAvailableFlights, Label lblFlightType) //add Panel and Button for message if there are no flights available
        {
            try
            {
                await _connection.OpenAsync();

                string query = "SELECT DepartureLocation.AirportCode AS DepartureAirportCode, " +
               "ArrivalLocation.AirportCode AS ArrivalAirportCode, " +
               "flights.ArrivalDate, flights.DepartureDate, flights.AirplaneNumber, " +
               "flights.SeatsRemaining, " +
               "flights.FlightPrice " +
               "FROM flights " +
               "JOIN airport AS DepartureLocation ON flights.DepartureAirportID = DepartureLocation.AirportID " +
               "JOIN airport AS ArrivalLocation ON ArrivalLocation.AirportID = flights.ArrivalAirportID " +
               "WHERE DepartureLocation.AirportLocation = @DepartureLocation " +
               "AND ArrivalLocation.AirportLocation = @ArrivalLocation " +
               "AND Date(flights.DepartureDate) = @DepartureDate " +
               "AND flights.SeatsRemaining > @Seats; ";

                MySqlCommand command = new MySqlCommand(query, _connection);

                int numAdults = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Adults") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Adults"]) : 0;
                int numChildren = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Children") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Children"]) : 0;
                int numInfants = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Infants") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Infants"]) : 0;

                int TotalSeats = numAdults + numChildren + numInfants;

                command.Parameters.AddWithValue("@DepartureLocation", FromLocation);
                command.Parameters.AddWithValue("@ArrivalLocation", ToLocation);
                command.Parameters.AddWithValue("@DepartureDate", DepartureDate);
                command.Parameters.AddWithValue("@Seats", TotalSeats);
                


                using (var reader = await command.ExecuteReaderAsync())
                {

                    if (!reader.HasRows)
                    {
                    noFlightAvailable(pnlAvailableFlights, btnContinue, btnBack, lblAvailableFlights, lblFlightType);
                    return;
                    }


                    while (await reader.ReadAsync())
                    {
                        //get Date input to DateTime 
                        DateTime Departure = (DateTime) reader["DepartureDate"];
                        DateTime Arrival = (DateTime)reader["ArrivalDate"];
                        //convert to specific formats
                        string DepartureTime = Departure.ToString("HH:mm");
                        string ArrivalTime = Arrival.ToString("HH:mm");
                        string Date = Departure.ToString("MMMM dd, yyyy");

                        //get Departure and Arrival Location in db
                        string DepartureLocation = (String) reader["DepartureAirportCode"];
                        string ArrivalLocation = (String) reader["ArrivalAirportCode"];

                        //get AirplaneNumber
                        string AirplaneNumber = (String)reader["AirplaneNumber"];

                        //get AvailableSeats
                        string AvailableSeats = reader["SeatsRemaining"].ToString();
                        float Price = float.Parse(reader["FlightPrice"].ToString());


                        //populate list
                        this.ArrivalLocation.Add(ArrivalLocation);
                        this.DepartureLocation.Add(DepartureLocation);
                        this.ArrivalTime.Add(ArrivalTime);
                        this.DepartureTime.Add(DepartureTime);
                        this.AirplaneNumber.Add(AirplaneNumber);
                        this.AvailableSeats.Add(AvailableSeats);
                        this.Price.Add(Price);
                        this.DepartureDate.Add(Departure.ToString("MMMM dd, yyyy"));
                        this.ArrivalDate.Add(Arrival.ToString("MMMM dd, yyyy"));
                    }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        private void noFlightAvailable(Panel pnlAvailableFlights, Button btnContinue, Button btnBack,Label lblAvailableFlights, Label lblFlightType)
        {
            Label lblEmptyBookingMessage = new Label();
            btnContinue.Visible = false;
            btnContinue.Enabled = false;
            lblAvailableFlights.Visible = false;
            lblFlightType.Visible = false;
            btnBack.Size = new System.Drawing.Size(194, 52);
            btnBack.Location = new Point(243, 479);

            lblEmptyBookingMessage.Text = "What the Sigma? There's no flight available??";

            // Set the label's appearance
            lblEmptyBookingMessage.Font = new Font("Kantumruy Pro", 25, FontStyle.Bold);
            lblEmptyBookingMessage.Margin = new Padding(0, 60, 0, 0);
            lblEmptyBookingMessage.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            lblEmptyBookingMessage.TextAlign = ContentAlignment.MiddleCenter;

            lblEmptyBookingMessage.AutoSize = true;

            pnlAvailableFlights.Controls.Add(lblEmptyBookingMessage);
        }
    }
}

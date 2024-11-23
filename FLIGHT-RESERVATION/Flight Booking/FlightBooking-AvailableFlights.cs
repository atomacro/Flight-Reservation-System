﻿using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FlightBooking_AvailableFlights_Load(object sender, EventArgs e)
        {
            PopulateAvailableBookings();
            btnBack.FlatAppearance.BorderSize = 0;
            lblFlightType.Text = $"Select {TripType} Flight";
        }
        List<FlightsAvailable> availableFlights = new List<FlightsAvailable>();
        public void PopulateAvailableBookings()
        {



            String DepartureLocation = "";
            String ArrivalLocation = "";

            if (this.TripType == "Departure")
            {
                DepartureLocation = FlightBooking_Session.Instance.FlightDetails["Departure Location"];
                ArrivalLocation = FlightBooking_Session.Instance.FlightDetails["Arrival Location"];
            }
            else
            {
                DepartureLocation = FlightBooking_Session.Instance.FlightDetails["Arrival Location"];
                ArrivalLocation = FlightBooking_Session.Instance.FlightDetails["Departure Location"];
            }


            //set Arrival Location and Departure Location, panel and button if no flights are seen
            Database_Available_Flights AvailableFlightsData = new Database_Available_Flights(DepartureLocation, ArrivalLocation, pnlAvailableFlights, btnContinueAvailableFlights, lblAvailableFlights);


            int selectedIndex = 0;
            for (int i = 0; i < AvailableFlightsData.AirplaneNumber.Count; i++)
            {
                FlightsAvailable AvailableFlight = new FlightsAvailable();

                AvailableFlight.setTime(AvailableFlightsData.ArrivalTime[i], AvailableFlightsData.DepartureTime[i]);
                AvailableFlight.setLocations(AvailableFlightsData.DepartureLocation[i], AvailableFlightsData.ArrivalLocation[i]);
                AvailableFlight.setTime(AvailableFlightsData.DepartureTime[i], AvailableFlightsData.ArrivalTime[i]);
                AvailableFlight.setSeatsAvailable(AvailableFlightsData.AvailableSeats[i]);
                AvailableFlight.setAirplaneNumber(AvailableFlightsData.AirplaneNumber[i]);

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

        public String SelectedAirplane = "";
        public void setSelected(List<FlightsAvailable> availableFlights, int index)
        {


            for (int i = 0; i < availableFlights.Count; i++)
            {
                if (i != index || availableFlights[i].btnBook.Text == "Unselect")
                {
                    SelectedAirplane = "";
                    availableFlights[i].btnBook.Text = "Select";
                    availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border); //reset the borders of unselected
                    continue;
                }
                availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Selected_Border); //set border to selected
                availableFlights[i].btnBook.Text = "Unselect";
                SelectedAirplane = availableFlights[i].lblAirplaneNumber.Text;
            }
        }

        public bool SubmitSelectedAirplane()
        {
            if (string.IsNullOrWhiteSpace(this.SelectedAirplane))
            {
                MessageBox.Show("Please Select a Flight", "Select a Flight", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.TripType == "Departure")
            {
                FlightBooking_Session.Instance.DepartureAirplaneNumber = this.SelectedAirplane;
                Console.WriteLine(FlightBooking_Session.Instance.DepartureAirplaneNumber);
                return true;
            }
            if (this.TripType == "Return")
            {
                FlightBooking_Session.Instance.ReturnAirplaneNumber = this.SelectedAirplane;
                Console.WriteLine(FlightBooking_Session.Instance.ReturnAirplaneNumber);
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

        public Database_Available_Flights(string From, string To, Panel pnlAvailableFlights, Button btnContinue, Label lblAvailableFlights)
        {

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            this.DepartureLocation.Clear();
            this.ArrivalLocation.Clear();
            this.DepartureTime.Clear();
            this.ArrivalTime.Clear();
            this.AirplaneNumber.Clear();
            SelectAvailableFlights(From, To, pnlAvailableFlights, btnContinue, lblAvailableFlights);

        }

        public void SelectAvailableFlights(String FromLocation, String ToLocation, Panel pnlAvailableFlights, Button btnContinue, Label lblAvailableFlights) //add Panel and Button for message if there are no flights available
        {

            _connection.Open();

            try
            {
                string query = "SELECT DepartureLocation.AirportCode AS DepartureAirportCode, " +
               "ArrivalLocation.AirportCode AS ArrivalAirportCode, " +
               "flights.ArrivalDate, flights.DepartureDate, flights.AirplaneNumber, " +
               "flights.SeatsRemaining " +
               "FROM flights " +
               "JOIN airport AS DepartureLocation ON flights.DepartureAirportID = DepartureLocation.AirportID " +
               "JOIN airport AS ArrivalLocation ON ArrivalLocation.AirportID = flights.ArrivalAirportID " +
               "WHERE DepartureLocation.AirportLocation = @DepartureLocation " +
               "AND ArrivalLocation.AirportLocation = @ArrivalLocation";

                MySqlCommand command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@DepartureLocation", FromLocation);
                command.Parameters.AddWithValue("@ArrivalLocation", ToLocation);    


                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    if (!reader.HasRows)
                    {
                    noFlightAvailable(pnlAvailableFlights, btnContinue, lblAvailableFlights);
                    return;
                    }


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

                        //get AvailableSeats
                        string AvailableSeats = reader.GetInt32("SeatsRemaining").ToString();


                        //populate list
                        this.ArrivalLocation.Add(ArrivalLocation);
                        this.DepartureLocation.Add(DepartureLocation);
                        this.ArrivalTime.Add(ArrivalTime);
                        this.DepartureTime.Add(DepartureTime);
                        this.AirplaneNumber.Add(AirplaneNumber);
                        this.AvailableSeats.Add(AvailableSeats);
                    }
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
            finally
            {
                _connection.Close();
            }
        }

        private void noFlightAvailable(Panel pnlAvailableFlights, Button btnContinue, Label lblAvailableFlights)
        {
            Label lblEmptyBookingMessage = new Label();
            btnContinue.Visible = false;
            btnContinue.Enabled = false;
            lblAvailableFlights.Visible = false;

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

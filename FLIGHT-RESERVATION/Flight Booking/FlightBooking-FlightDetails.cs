using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FLIGHT_RESERVATION
{
    public partial class FlightBooking_FlightDetails : UserControl
    {

        public FlightBooking_FlightDetails()
        {
            InitializeComponent();
        }

        String state = "One Way";
        public Round_Trip RoundTrip = new Round_Trip();
        public One_Way OneWay = new One_Way();

        private async void FlightBooking_FlightDetails_Load(object sender, EventArgs @event)
        {
            await SetComboBoxItems(RoundTrip, "Round Trip");
            await SetComboBoxItems(OneWay, "One Way");

            OneWay.AutoSize = true;
            OneWay.Location = new Point(0, 0);
            RoundTrip.AutoSize = true;
            RoundTrip.Location = new Point(0, 0);
            pnlFlightBooking.Controls.Add(RoundTrip);
            pnlFlightBooking.Controls.Add(OneWay);
            OneWay.BringToFront();
        }

        public bool HandleSubmit(Trips Trip, String Type)
        { 
            var properties = Trip.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(ComboBox))
                {
                    var control = property.GetValue(Trip) as ComboBox;
                    if (control == Trip.cboReturnDateControl)
                    {
                        continue;
                    }
                    if (control == null || string.IsNullOrWhiteSpace(control.Text))
                    {
                        return false;
                    }
                }
            }
            FlightBooking_Session.Instance.setFlightDetails(Trip, Type);
            return true;
        }
        private void btnChangeType_Click(object sender, EventArgs e)
        {    
            if (state == null) state = "One Way";

            if (state == "One Way")
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.TwoWayButton;
                state = "Round Trip";
                OneWay.Hide();
                RoundTrip.Show();

            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
                state = "One Way";
                RoundTrip.Hide();
                OneWay.Show();

            }
        }


        //trips is an Interface class under FlightBooking-FlightDetails
        private async Task SetComboBoxItems(Trips trip, String Type)
        {

            var db_FlightDetails = new Database_FlightDetails();
            await db_FlightDetails.selectLocations();

            trip.cboArrivalLocationControl.SelectedIndexChanged -= HandleLocationChange;
            trip.cboDepartureLocationControl.SelectedIndexChanged -= HandleLocationChange; //remove existing Event Handlers
            trip.SetDepartureLocation(db_FlightDetails.DepartureLocations);
            trip.SetArrivalLocation(db_FlightDetails.ArrivalLocations);
            trip.cboArrivalLocationControl.SelectedIndexChanged += HandleLocationChange; //add new Event Handler
            trip.cboDepartureLocationControl.SelectedIndexChanged += HandleLocationChange;

            if (trip.cboReturnDateControl != null)
            {
                trip.cboReturnDateControl.SelectedIndexChanged += HandleDateChange;
                trip.cboDepartureDateControl.SelectedIndexChanged += HandleDateChange;
            }
            async void HandleLocationChange(object sender, EventArgs e)
            {
                if (trip.cboDepartureLocationControl.SelectedItem != null && trip.cboArrivalLocationControl.SelectedItem != null)
                {

                   await db_FlightDetails.selectDates(trip.cboDepartureLocationControl.Text, trip.cboArrivalLocationControl.Text, Type, trip);
                    trip.SetDates(db_FlightDetails.DepartureDates, db_FlightDetails.ReturnDates);
                }
            }

            void HandleDateChange(Object sender, EventArgs e)
            {
                if (trip.cboReturnDateControl.SelectedItem != null && trip.cboDepartureDateControl.SelectedItem != null && DateTime.Parse(trip.cboDepartureDateControl.Text) > DateTime.Parse(trip.cboReturnDateControl.Text))
                {
                    trip.cboReturnDateControl.Items.Clear();
                    MessageBox.Show("Return Date must be later than Departure Date");
                    trip.cboReturnDateControl.SelectedItem = null;
                }
            };
        }
        }

    public class Database_FlightDetails
    {
        //5 hashmap, 2 List

        private MySqlConnection _connection;
        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        public Dictionary<String, String> ArrivalLocations;
        public Dictionary<String, String> DepartureLocations;
        public List<String> ReturnDates;
        public List<String> DepartureDates;
        public Database_FlightDetails()
        {
            this.ArrivalLocations = new Dictionary<String, String>();
            this.DepartureLocations = new Dictionary<String, String>();
            this.ReturnDates = new List<String>();
            this.DepartureDates = new List<String>();

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

        public async Task selectLocations()
        {
            try
            {
           
                await _connection.OpenAsync();

                String query = "SELECT DISTINCT DepartureLocation.AirportFullName AS DepartureLocation, " +
                "DepartureLocation.AirportLocation AS DepartureAirportLocation, " +
                "ArrivalLocation.AirportFullName AS ArrivalLocation, " +
                "ArrivalLocation.AirportLocation AS ArrivalAirportLocation " +
                "FROM airport AS DepartureLocation " +
                "JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID " +
                "JOIN airport AS ArrivalLocation " +
                "ON flights.ArrivalAirportID = ArrivalLocation.AirportID " +
                "ORDER BY DepartureLocation.AirportLocation ASC, ArrivalLocation.AirportLocation ASC;";

                MySqlCommand command = new MySqlCommand(query, _connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        
                            string arrivalLocation = reader.GetString("ArrivalLocation");
                            string arrivalAirportLocation = reader.GetString("ArrivalAirportLocation");
                            string departureLocation = reader.GetString("DepartureLocation");
                            string departureAirportLocation = reader.GetString("DepartureAirportLocation");

                            if (!this.ArrivalLocations.ContainsKey(arrivalAirportLocation))
                            {
                                this.ArrivalLocations[arrivalAirportLocation] = arrivalLocation;
                            }

                            if (!this.DepartureLocations.ContainsKey(departureAirportLocation))
                            {
                            this.DepartureLocations[departureAirportLocation] = departureLocation;
                        }   
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occured while selecting locations {e.Message} ");
            }
            finally
            {

                await _connection.CloseAsync();
            }

        }

        public async Task selectDates(String Departure, String Arrival, String Type, Trips trip)
        {
            try
            {
                if(DepartureDates != null) DepartureDates.Clear();
                if(ReturnDates != null) ReturnDates.Clear();

                await _connection.OpenAsync();
                String query = "SELECT flights.DepartureDate " +
                    "FROM flights JOIN airport AS Departure ON " +
                    "flights.DepartureAirportID = Departure.AirportID " +
                    "JOIN airport AS Arrival ON flights.ArrivalAirportID = Arrival.AirportID " +
                    "WHERE Departure.AirportLocation = @DepartureLocation " +
                    "AND Arrival.AirportLocation = @ArrivalLocation";

                MySqlCommand commandDeparture = new MySqlCommand(query, _connection);
                commandDeparture.Parameters.AddWithValue("@DepartureLocation", Departure);
                commandDeparture.Parameters.AddWithValue("@ArrivalLocation", Arrival);
                

                using (var readerDeparture = await commandDeparture.ExecuteReaderAsync())
                {
                    if (!readerDeparture.HasRows) {
                        MessageBox.Show("Sorry, No available flights");
                        this.ReturnDates.Clear();
                        this.DepartureDates.Clear();
                        return; 
                    }

                    while (await readerDeparture.ReadAsync())
                    {
                        this.DepartureDates.Add(((DateTime)readerDeparture["DepartureDate"]).ToString("MMMM dd, yyyy"));
                    }
                }

                if (Type == "Round Trip")
                {

                    MySqlCommand commandReturn = new MySqlCommand(query, _connection);
                    commandReturn.Parameters.AddWithValue("@DepartureLocation", Arrival);
                    commandReturn.Parameters.AddWithValue("@ArrivalLocation", Departure);

                    using (var readerReturn = await commandReturn.ExecuteReaderAsync())
                    {
                        if (!readerReturn.HasRows)
                        {
                            MessageBox.Show("Sorry, No available flights");
                            this.ReturnDates.Clear();
                            this.DepartureDates.Clear();
                            return;
                        }

                        while (await readerReturn.ReadAsync())
                        {
                            this.DepartureDates.Add(((DateTime)readerReturn["DepartureDate"]).ToString("MMMM dd, yyyy"));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occured while selecting Dates {e.Message} ");

            }
            finally
            {
               await _connection.CloseAsync();
            }
        }
    }
}


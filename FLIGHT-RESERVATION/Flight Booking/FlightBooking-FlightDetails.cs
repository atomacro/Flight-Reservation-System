using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;
using FLIGHT_RESERVATION.ViewBookings;
using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FLIGHT_RESERVATION.Dashboard.FlightDetails;
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
            this.SuspendLayout();
            OneWay.AutoSize = true;
            OneWay.Location = new Point(0, 0);
            RoundTrip.AutoSize = true;
            RoundTrip.Location = new Point(0, 0);
            pnlFlightBooking.Controls.Add(RoundTrip);
            pnlFlightBooking.Controls.Add(OneWay);
            OneWay.BringToFront();
            this.ResumeLayout();
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
        //set sortState
        private string sortState = "All";
        private async void btnSortLocal_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(btnSortLocal, btnSortInternational, "Local");
            await RefreshDepartureLocations();
        }

        private async void btnSortInternational_Click(object sender, EventArgs e)
        {
            UpdateButtonStates(btnSortInternational, btnSortLocal, "International");
            await RefreshDepartureLocations();
        }

        private void UpdateButtonStates(Button activeButton, Button inactiveButton, string state)
        {
            ActiveButton(activeButton);
            InactiveButton(inactiveButton);

            this.sortState = state;
        }

        private async Task RefreshDepartureLocations()
        {
            await setDepartureLocations(RoundTrip, "Round Trip");
            await setDepartureLocations(OneWay, "One Way");
        }

        private void ActiveButton(Button btn)
        {
            btn.ForeColor = Color.White;
            btn.BackColor = ColorTranslator.FromHtml("#763AEE");
        }

        private void InactiveButton(Button btn)
        {
            btn.ForeColor = Color.Black;
            btn.BackColor = ColorTranslator.FromHtml("#e6e9f0");
        }

        //trips is an Interface class under FlightBooking-FlightDetails
        Database_FlightDetails db_FlightDetails = new Database_FlightDetails();

        private async Task setDepartureLocations(Trips trip, String Type)
        {
            trip.cboDepartureLocationControl.Items.Clear();


            await db_FlightDetails.selectLocations(this.sortState, null, Type);
            trip.SetDepartureLocation(db_FlightDetails.DepartureLocations);
            trip.cboArrivalLocationControl.Items.Clear();
            trip.cboArrivalLocationControl.SelectedItem = null;
            trip.lblArrivalAirportNameControl.Text = "";
            trip.cboDepartureDateControl.Items.Clear();
            trip.cboReturnDateControl?.Items.Clear();
        }
        private async Task SetComboBoxItems(Trips trip, String Type)
        {

            HashSet<String> returnDates = new HashSet<String>();

            await db_FlightDetails.selectLocations(this.sortState, null, Type);
            trip.SetDepartureLocation(db_FlightDetails.DepartureLocations);

            async void HandleArrivalLocations(object sender, EventArgs e)
            {
                db_FlightDetails.DepartureDates.Clear();
                db_FlightDetails.ReturnDates.Clear();
                trip.cboDepartureDateControl.Items.Clear();
                if(trip.cboReturnDateControl != null) trip.cboReturnDateControl.Items.Clear();

                trip.cboArrivalLocationControl.Items.Clear();
                await db_FlightDetails.selectLocations(this.sortState, trip.cboDepartureLocationControl.Text, Type);
                trip.SetArrivalLocation(db_FlightDetails.ArrivalLocations);
                trip.cboArrivalLocationControl.SelectedItem = null;
                trip.lblArrivalAirportNameControl.Text = "";
                trip.lblDepartureAirportNameControl.Text = db_FlightDetails.DepartureLocations[trip.cboDepartureLocationControl.Text];
            }

            if (trip.cboReturnDateControl != null)
            {
                trip.cboReturnDateControl.SelectedIndexChanged += HandleDateChange;
            }
            async void HandleLocationChangeDate(object sender, EventArgs e)
            {
                if (trip.cboDepartureLocationControl.SelectedItem != null && trip.cboArrivalLocationControl.SelectedItem != null)
                {
                   await db_FlightDetails.selectDates(trip.cboDepartureLocationControl.Text, trip.cboArrivalLocationControl.Text, Type, trip);
                   trip.SetDates(db_FlightDetails.DepartureDates, db_FlightDetails.ReturnDates);
                    returnDates = db_FlightDetails.ReturnDates;
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

            trip.cboArrivalLocationControl.SelectedIndexChanged -= HandleLocationChangeDate;
            trip.cboDepartureLocationControl.SelectedIndexChanged -= HandleArrivalLocations;

            trip.cboArrivalLocationControl.SelectedIndexChanged += HandleLocationChangeDate;
            trip.cboDepartureLocationControl.SelectedIndexChanged += HandleArrivalLocations;

            if (trip.cboReturnDateControl != null)
            {

                trip.cboDepartureDateControl.SelectedIndexChanged += (s, e) =>
                {
                    List<string> viableReturn = new List<string>();
                    trip.cboReturnDateControl.Items.Clear();
                    if (String.IsNullOrWhiteSpace(trip.cboDepartureDateControl.Text)) return;
                    DateTime selectedDepartureDate = DateTime.Parse(trip.cboDepartureDateControl.Text);

                    foreach (string date in returnDates)
                    {
                        DateTime returnDate = DateTime.Parse(date);
                        if (selectedDepartureDate < returnDate)
                        {
                            trip.cboReturnDateControl.Items.Add(date);
                            viableReturn.Add(date);
                        }
                    }
                    if(viableReturn.Count == 0)
                    {
                        MessageBox.Show("Sorry, no available flights for the selected departure date");
                    }
                };

            }
        }
    }

    public class Database_FlightDetails
    {
        //5 hashmap, 2 List

        private MySqlConnection _connection;
        private MySqlConnection connection;

        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        public Dictionary<String, String> ArrivalLocations;
        public Dictionary<String, String> DepartureLocations;
        public HashSet<String> ReturnDates;
        public HashSet<String> DepartureDates;
        public Database_FlightDetails()
        {
            this.ArrivalLocations = new Dictionary<String, String>();
            this.DepartureLocations = new Dictionary<String, String>();
            this.ReturnDates = new HashSet<String>();
            this.DepartureDates = new HashSet<String>();

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
            connection = new MySqlConnection(connectionString);
        }

        public async Task selectLocations(string SortState, string From, string Type)
        {
            try
            {
                if (ArrivalLocations != null) ArrivalLocations.Clear();
                if (DepartureLocations != null) DepartureLocations.Clear();
               await connection.OpenAsync();

                string sortCondition = SortState == "All" ? "" : $@"flights.Type = ""{SortState}""";
                string arrivalCondition = "";
                string returnCondition = "";

                if (Type == "One Way")
                {
                    arrivalCondition = From == null ? "" : $@"DepartureLocation.AirportLocation = ""{From}""";
                }
                else if (Type == "Round Trip")
                {
                    arrivalCondition = From == null ? "" : $@"DepartureLocation.AirportLocation = ""{From}"" AND ";
                    returnCondition = From == null ? "" : $@"ArrivalLocation.AirportLocation = ""{From}"" AND ";
                }

                string whereClause = "";
                if (!string.IsNullOrEmpty(sortCondition) && !string.IsNullOrEmpty(arrivalCondition))
                {
                    whereClause = $@"WHERE {sortCondition} AND {arrivalCondition}";
                }
                else if (!string.IsNullOrEmpty(sortCondition))
                {
                    whereClause = $@"WHERE {sortCondition}";
                }
                else if (!string.IsNullOrEmpty(arrivalCondition))
                {
                    whereClause = $@"WHERE {arrivalCondition}";
                }


                string query = "SELECT DISTINCT DepartureLocation.AirportFullName AS DepartureLocation, " +
                               "DepartureLocation.AirportLocation AS DepartureAirportLocation, " +
                               "ArrivalLocation.AirportFullName AS ArrivalLocation, " +
                               "ArrivalLocation.AirportLocation AS ArrivalAirportLocation " +
                               "FROM airport AS DepartureLocation " +
                               "JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID " +
                               "JOIN airport AS ArrivalLocation " +
                               "ON flights.ArrivalAirportID = ArrivalLocation.AirportID " +
                               $"{whereClause} AND Flights.DepartureDate >= NOW() " +
                               "ORDER BY DepartureLocation.AirportLocation ASC, ArrivalLocation.AirportLocation ASC;";

                if (Type == "Round Trip")
                {
                    string returnWhereClause = "";
                    string returnLocation = From == null ? "" : $@"DepartureAirportLocation = ""{From}""";
                    if (!string.IsNullOrEmpty(sortCondition) && !string.IsNullOrEmpty(returnCondition))
                    {
                        returnWhereClause = $@"WHERE {sortCondition} AND {returnCondition}";
                    }
                    else if (!string.IsNullOrEmpty(sortCondition))
                    {
                        returnWhereClause = $@"WHERE {sortCondition}";
                    }
                    else if (!string.IsNullOrEmpty(returnCondition))
                    {
                        returnWhereClause = $@"WHERE {returnCondition}";
                    }


                    query = $@"
                    SELECT *
                    FROM (
                        SELECT DISTINCT 
                            DepartureLocation.AirportFullName AS DepartureLocation, 
                            DepartureLocation.AirportLocation AS DepartureAirportLocation, 
                            ArrivalLocation.AirportFullName AS ArrivalLocation, 
                            ArrivalLocation.AirportLocation AS ArrivalAirportLocation, 
                            Flights.DepartureDate AS DepartureDate,
                            Flights.ArrivalDate AS ArrivalDate
                        FROM airport AS DepartureLocation
                        JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID
                        JOIN airport AS ArrivalLocation ON flights.ArrivalAirportID = ArrivalLocation.AirportID
                        WHERE
                          {(SortState == "All" ? "" : $"flights.Type = '{SortState}' AND ")}
                          {(string.IsNullOrEmpty(From) ? "" : $"DepartureLocation.AirportLocation = '{From}' AND ")}
                          Flights.DepartureDate >= NOW()
                        UNION
                        SELECT DISTINCT 
                            DepartureLocation.AirportFullName AS DepartureLocation, 
                            DepartureLocation.AirportLocation AS DepartureAirportLocation, 
                            ArrivalLocation.AirportFullName AS ArrivalLocation, 
                            ArrivalLocation.AirportLocation AS ArrivalAirportLocation, 
                            Flights.DepartureDate AS DepartureDate,
                            Flights.ArrivalDate AS ArrivalDate
                        FROM airport AS DepartureLocation
                        JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID
                        JOIN airport AS ArrivalLocation ON flights.ArrivalAirportID = ArrivalLocation.AirportID
                        WHERE
                          {(SortState == "All" ? "" : $"flights.Type = '{SortState}' AND ")}
                          {(string.IsNullOrEmpty(From) ? "" : $"ArrivalLocation.AirportLocation = '{From}' AND ")}
                          Flights.DepartureDate >= NOW()

                    ) AS CombinedResults
                    WHERE 
                    {(string.IsNullOrWhiteSpace(returnLocation) ? "" : $"{returnLocation} AND ")}
                    DepartureDate <= ArrivalDate
                    ORDER BY DepartureLocation ASC, ArrivalLocation ASC;
                    ";

                }

                MySqlCommand command = new MySqlCommand(query, connection);
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
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occurred while selecting locations: {e.Message}");
                Console.WriteLine(e.Message);
            }

            finally
            {
                await connection.CloseAsync();
            }
        }


        public async Task selectDates(String Departure, String Arrival, String Type, Trips trip)
        {
            try
            {
                await _connection.OpenAsync();
                String query = "SELECT DISTINCT flights.DepartureDate " +
                    "FROM flights JOIN airport AS Departure ON " +
                    "flights.DepartureAirportID = Departure.AirportID " +
                    "JOIN airport AS Arrival ON flights.ArrivalAirportID = Arrival.AirportID " +
                    "WHERE Departure.AirportLocation = @DepartureLocation " +
                    "AND Arrival.AirportLocation = @ArrivalLocation " +
                    "AND flights.DepartureDate >= NOW() " +
                    "AND flights.ArrivalDate > flights.DepartureDate; ";

                MySqlCommand commandDeparture = new MySqlCommand(query, _connection);
                commandDeparture.Parameters.AddWithValue("@DepartureLocation", Departure);
                commandDeparture.Parameters.AddWithValue("@ArrivalLocation", Arrival);
                

                using (var readerDeparture = await commandDeparture.ExecuteReaderAsync())
                {

                    if (DepartureDates != null) DepartureDates.Clear();

                    if (!readerDeparture.HasRows && trip.cboDepartureLocationControl.Text != null && trip.cboArrivalLocationControl.Text != null) {
                        MessageBox.Show("Sorry, No departure flights");
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
                    if (ReturnDates != null) ReturnDates.Clear();

                    MySqlCommand commandReturn = new MySqlCommand(query, _connection);
                    commandReturn.Parameters.AddWithValue("@DepartureLocation", Arrival);
                    commandReturn.Parameters.AddWithValue("@ArrivalLocation", Departure);

                    using (var readerReturn = await commandReturn.ExecuteReaderAsync())
                    {
                        if (!readerReturn.HasRows && trip.cboDepartureLocationControl.Text != null && trip.cboArrivalLocationControl.Text != null)
                        {
                            MessageBox.Show("Sorry, No return flights");
                            this.ReturnDates.Clear();
                            this.DepartureDates.Clear();
                            return;
                        }

                        while (await readerReturn.ReadAsync())
                        {
                            this.ReturnDates.Add(((DateTime)readerReturn["DepartureDate"]).ToString("MMMM dd, yyyy"));
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


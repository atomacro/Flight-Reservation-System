using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public partial class FlightBooking_FlightDetails : UserControl
    {
        public FlightBooking_FlightDetails()
        {
            InitializeComponent();
        }

        String state = "One Way";
        Round_Trip RoundTrip = new Round_Trip();
        One_Way OneWay = new One_Way();
        private Trips CurrentTrip;  


        private void FlightBooking_FlightDetails_Load(object sender, EventArgs e)
        {
            SetComboBoxItems(RoundTrip, state);
            OneWay.AutoSize = true;
            OneWay.Location = new Point(0, 0);
            pnlFlightBooking.Controls.Add(OneWay);

        }
        private void btnChangeType_Click(object sender, EventArgs e)
        {

                
            if (state == null) state = "One Way";

            if (!pnlFlightBooking.Controls.Contains(OneWay))
            {
                OneWay.AutoSize = true;
                OneWay.Location = new Point(0, 0);
                pnlFlightBooking.Controls.Add(OneWay);
            }

            if (!pnlFlightBooking.Controls.Contains(RoundTrip))
            {
                RoundTrip.AutoSize = true;
                RoundTrip.Location = new Point(0, 0);
                pnlFlightBooking.Controls.Add(RoundTrip);
            }

            if (state == "One Way")
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.TwoWayButton;
                state = "Two Way";
                OneWay.Hide();
                RoundTrip.Show();
                SetComboBoxItems(RoundTrip, state);

            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
                state = "One Way";
                RoundTrip.Hide();
                OneWay.Show();
                SetComboBoxItems(OneWay, state);
            }
        }


        //trips is an Interface class under FlightBooking-FlightDetails
        private void SetComboBoxItems(Trips trip, String Type)
        {

            var db_FlightDetails = new Database_FlightDetails();
            

            trip.cboArrivalLocationControl.SelectedIndexChanged -= HandleLocationChange;
            trip.cboDepartureLocationControl.SelectedIndexChanged -= HandleLocationChange; //remove existing Event Handlers
            trip.SetDepartureLocation(db_FlightDetails.DepartureLocations);
            trip.SetArrivalLocation(db_FlightDetails.ArrivalLocations);
            trip.cboArrivalLocationControl.SelectedIndexChanged += HandleLocationChange; //add new Event Handler
            trip.cboDepartureLocationControl.SelectedIndexChanged += HandleLocationChange;


            void HandleLocationChange(object sender, EventArgs e)
            {
                if(trip.cboDepartureLocationControl.SelectedItem != null && trip.cboArrivalLocationControl.SelectedItem != null)
                {
                    db_FlightDetails.selectDates(trip.cboDepartureLocationControl.Text, trip.cboArrivalLocationControl.Text, Type);
                    trip.SetDates(db_FlightDetails.DepartureDates, db_FlightDetails.ReturnDates);
                }
            }
        }
    }


    public class Database_FlightDetails
    {
        //5 hashmap, 2 List

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
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
            selectLocations();
        }

        public void selectLocations()
        {

            try
            {
           
                _connection.Open();

                String query = "SELECT DepartureLocation.AirportFullName AS DepartureLocation, " +
                "DepartureLocation.AirportLocation AS DepartureAirportLocation, " +
                "ArrivalLocation.AirportFullName AS ArrivalLocation, " +
                "ArrivalLocation.AirportLocation AS ArrivalAirportLocation " +
                "FROM airport AS DepartureLocation " +
                "JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID " +
                "JOIN airport AS ArrivalLocation " +
                "ON flights.ArrivalAirportID = ArrivalLocation.AirportID";

                MySqlCommand command = new MySqlCommand(query, _connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                            string arrivalLocation = reader.GetString("ArrivalLocation");
                            string arrivalAirportLocation = reader.GetString("ArrivalAirportLocation");
                            string departureLocation = reader.GetString("DepartureLocation");
                            string departureAirportLocation = reader.GetString("DepartureAirportLocation");

                            if (!this.ArrivalLocations.ContainsKey(arrivalAirportLocation))
                            {
                                this.ArrivalLocations.Add(arrivalAirportLocation, arrivalLocation);
                            }

                            if (!this.DepartureLocations.ContainsKey(departureAirportLocation))
                            {
                                this.DepartureLocations.Add(departureAirportLocation, departureLocation);
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

                _connection.Close();
            }

        }

        public void selectDates(String Departure, String Arrival, String Type)
        {
            try
            {
                _connection.Open();
                String query = "SELECT flights.DepartureDate " +
                    "FROM flights JOIN airport AS Departure ON " +
                    "flights.DepartureAirportID = Departure.AirportID " +
                    "JOIN airport AS Arrival ON flights.ArrivalAirportID = Arrival.AirportID " +
                    "WHERE Departure.AirportLocation = @DepartureLocation " +
                    "AND Arrival.AirportLocation = @ArrivalLocation";

                MySqlCommand commandDeparture = new MySqlCommand(query, _connection);
                commandDeparture.Parameters.AddWithValue("@DepartureLocation", Departure);
                commandDeparture.Parameters.AddWithValue("@ArrivalLocation", Arrival);
                

                using (MySqlDataReader readerDeparture = commandDeparture.ExecuteReader())
                {
                    if (!readerDeparture.HasRows) {
                        MessageBox.Show("Sorry, No available flights for departure");
                        return; 
                    }

                    while (readerDeparture.Read())
                    {
                        this.DepartureDates.Add(readerDeparture.GetDateTime("DepartureDate").ToString("MMMM dd, yyyy"));
                    }
                }

                if (Type == "Two Way")
                {

                    MySqlCommand commandReturn = new MySqlCommand(query, _connection);
                    commandReturn.Parameters.AddWithValue("@DepartureLocation", Arrival);
                    commandReturn.Parameters.AddWithValue("@ArrivalLocation", Departure);

                    using (MySqlDataReader readerReturn = commandReturn.ExecuteReader())
                    {
                        if (!readerReturn.HasRows)
                        {
                            MessageBox.Show("Sorry, No available flights for return");
                            return;
                        }

                        while (readerReturn.Read())
                        {
                            this.ReturnDates.Add(readerReturn.GetDateTime("DepartureDate").ToString("MMMM dd, yyyy"));
                        }
                    }
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show($"An error has occured while selecting Dates {e.Message} ");

            }
            finally
            {
                _connection.Close();
            }
        }
    }
}


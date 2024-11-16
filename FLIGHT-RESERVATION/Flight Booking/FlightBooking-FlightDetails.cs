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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

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
            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
                state = "One Way";
                RoundTrip.Hide();
                OneWay.Show();
            }
        }

        private void setComboBoxItems()
        {
            //RoundTrip.setDepartureLocation() hashmap <String, String> location, airportname
            //RoundTrip.setArrivalLocation(); hashmap <String, String> location, airportname
            //RoundTrip.setDates(); hashmap <String, List<String>> ArrivalDate, ReturnDates suited for twoway
            //OneWay.setArrivalLocation()
            //OneWay.setDepartureDate();
            //OneWay.setDepartureDate(); List <String>
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
        public Dictionary<String, List<String>> TwoWayDates;
        public List<String> OneWayDates;
        public Database_FlightDetails()
        {

            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

        public void selectLocations()
        {

            try
            {
           
                _connection.Open();

                String query = "SELECT DepartureLocation.AirportFullName AS DepartureLocation,  " +
                "DepartureLocation.AirportLocation AS DepartureAirportLocation," +
                "ArrivalLocation.AirportFullName AS ArrivalLocation, " +
                "ArrivalLocation.AirportLocation AS ArrivalAirportLocation" +
                "FROM airport AS DepartureLocation " +
                "JOIN flights ON flights.DepartureAirportID = DepartureLocation.AirportID" +
                "JOIN airport AS ArrivalLocation " +
                "ON flights.ArrivalAirportID = ArrivalLocation.AirportID";

                MySqlCommand command = new MySqlCommand(query, _connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.ArrivalLocations.Add(reader.GetString("ArrivalLocation"), reader.GetString("ArrivalAirportLocation"));
                        this.DepartureLocations.Add(reader.GetString("DepartureLocation"), reader.GetString("DepartureAirportLocation"));
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

        public void selectOneWayDates(String From, String To)
        {
            try
            {
                _connection.Open();
                String query = "SELECT flights.DepartureDate " +
                    "FROM flights JOIN airport AS Departure ON " +
                    "flights.DepartureAirportID = Departure.AirportID " +
                    "JOIN airport AS Arrival ON flights.ArrivalAirportID = Arrival.AirportID " +
                    "WHERE Departure.AirportLocation = @Departure" +
                    "AND Arrival.AirportLocation = @Arrival";

                MySqlCommand command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@DepartureLocation", From);
                command.Parameters.AddWithValue("@ArrivalLocation", To); 
                
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.OneWayDates.Add(reader.GetDateTime("DepartureDate").ToString("MMMM-dd-yyyy"));
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

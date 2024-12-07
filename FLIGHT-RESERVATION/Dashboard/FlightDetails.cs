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

namespace FLIGHT_RESERVATION.Dashboard
{
    public partial class FlightDetails : Form
    {
        private int _flightID;

        public FlightDetails(int flightID, string DepartureLocation, string ArrivalLocation, string DepartureTime, string ArrivalTime)
        {
            InitializeComponent();
            _flightID = flightID;

            SetupInitialUI(
                DepartureLocation,
                ArrivalLocation,
                DepartureTime,
                ArrivalTime
            );
        }

        private void SetupInitialUI(string departureLocation, string arrivalLocation, string departureTime, string arrivalTime)
        {
            lblLocation1.Text = departureLocation;
            lblLocation2.Text = arrivalLocation;
            lblTime1.Text = departureTime;
            lblTime2.Text = arrivalTime;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FlightDetails_Load(object sender, EventArgs e)
        {
            PopulateFlightDetails();
        }

        private void PopulateFlightDetails()
        {
            DB_FlightDetails details = new DB_FlightDetails();
            details.GetFlightDetails(_flightID);

            lblAirplaneNumber.Text = details.AirplaneNum;
            lblDepartureDate.Text = details.DepartureDate.ToString("MMMM dd, yyyy");
            lblArrivalDate.Text = details.ArrivalDate.ToString("MMMM dd, yyyy");
            lblDepartureAirport.Text = details.DepartureAirport;
            lblArrivalAirport.Text = details.ArrivalAirport;
            lblFlightPrice.Text = details.Price.ToString("N2") + " Php";
            lblFlightType.Text = details.FlightType;

        }

        public class DB_FlightDetails
        {
            private DatabaseConnection dbConnection = DatabaseConnection.Instance;
            public string AirplaneNum;
            public DateTime DepartureDate;
            public DateTime ArrivalDate;
            public string DepartureAirport;
            public string ArrivalAirport;
            public int Price;
            public string FlightType;

            public void GetFlightDetails(int flightID)
            {
                dbConnection.OpenConnection();

                string query = 
                    $@"SELECT 
                        Flights.AirplaneNumber,
                        Flights.DepartureDate,
                        Flights.ArrivalDate,
                        DepartureAirport.AirportFullName AS DepartureName, 
                        DepartureAirport.AirportLocation AS DepartureLocation,
                        ArrivalAirport.AirportFullName AS ArrivalName,
                        ArrivalAirport.AirportLocation AS ArrivalLocation,
                        Flights.FlightPrice,
                        Flights.Type AS FlightType
                        FROM 
                            flights
                        JOIN 
                            Airport AS DepartureAirport ON Flights.DepartureAirportID = DepartureAirport.AirportID
                        JOIN 
                            Airport AS ArrivalAirport ON Flights.ArrivalAirportID = ArrivalAirport.AirportID
                        WHERE 
                            Flights.FlightID = @FlightID;";
                try
                {
                    MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                    command.Parameters.AddWithValue("@FlightID", flightID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AirplaneNum = reader.GetString("AirplaneNumber");
                            DepartureDate = reader.GetDateTime("DepartureDate");
                            ArrivalDate = reader.GetDateTime("ArrivalDate");

                            string departureAirportName = reader.GetString("DepartureName");
                            string departureAirportLocation = reader.GetString("DepartureLocation");
                            DepartureAirport = $"{departureAirportName}\n{departureAirportLocation}";

                            string arrivalAirportName = reader.GetString("ArrivalName");
                            string arrivalAirportLocation = reader.GetString("ArrivalLocation");
                            ArrivalAirport = $"{arrivalAirportName}\n{arrivalAirportLocation}";

                            Price = reader.GetInt32("FlightPrice");
                            FlightType = reader.GetString("FlightType");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }
    }
}

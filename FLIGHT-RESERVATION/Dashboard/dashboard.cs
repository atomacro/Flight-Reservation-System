using FLIGHT_RESERVATION.ViewBookings;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLIGHT_RESERVATION.Dashboard;

namespace FLIGHT_RESERVATION
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private async void dashboard_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            InitializeSort();
            await PopulateBookings("All");
            ResumeLayout();
        }

        //
        // UI Methods
        //
        private void InitializeSort()
        {
            string State = "All";
            ActiveButton(btnSortAll);

            btnSortAll.Click += async (s, e) =>
            {
                State = "All";
                ActiveButton(btnSortAll);
                InactiveButton(btnSortInternational, btnSortLocal);
                
                pnlBookings.Controls.Clear();
                await PopulateBookings(State);
            };

            btnSortLocal.Click += async (s, e) =>
            {
                State = "Local";
                ActiveButton(btnSortLocal);
                InactiveButton(btnSortAll, btnSortInternational);

                pnlBookings.Controls.Clear();
                await PopulateBookings(State);
            };

            btnSortInternational.Click += async (s, e) =>
            { 
                State = "International";
                ActiveButton(btnSortInternational);
                InactiveButton(btnSortAll, btnSortLocal);

                pnlBookings.Controls.Clear();
                await PopulateBookings(State);
            };
        }

        private void ActiveButton(Button btn)
        {
            btn.ForeColor = Color.White;
            btn.BackColor = ColorTranslator.FromHtml("#763AEE");
        }

        private void InactiveButton(Button btn1, Button btn2)
        {
            btn1.ForeColor = Color.Black;
            btn1.BackColor = ColorTranslator.FromHtml("#e6e9f0");
            btn2.ForeColor = Color.Black;
            btn2.BackColor = ColorTranslator.FromHtml("#e6e9f0");
        }

        //
        // Populate user control 
        //
        private async Task PopulateBookings(String sortState)
        {
            SuspendLayout();
            AvailableFlights flight = new AvailableFlights();
            await flight.QuerySelect(sortState);
            for (int i = 0; i < flight.DepartureDate.Count; i++)
            {
                Bookings bookings = new Bookings();

                int currentIndex = i;
                bookings.btnViewBookingDetails.Click += (s, e) =>
                {
                    var flightDetails = new FlightDetails(
                        flight.FlightID[currentIndex],
                        flight.DepartureLocation[currentIndex],
                        flight.ArrivalLocation[currentIndex],
                        flight.DepartureTime[currentIndex],
                        flight.ArrivalTime[currentIndex]);
                    flightDetails.ShowDialog();
                };

                bookings.Margin = new Padding(0, 0, 0, 10);
                bookings.SetDate(flight.DepartureDate[i]);
                bookings.setLocation(flight.DepartureLocation[i], flight.ArrivalLocation[i]);
                bookings.setTime(flight.DepartureTime[i], flight.ArrivalTime[i]);
                bookings.setAirplaneNumber(flight.AirplaneNumber[i]);
                pnlBookings.Controls.Add(bookings);

            }
            ResumeLayout();
        }

        //
        // MySQL Database Methods 
        //
        public class AvailableFlights
        {
            private DatabaseConnection dbConnection;
            public List<int> FlightID = new List<int>();
            public List<string> DepartureDate = new List<String>();
            public List<string> DepartureLocation = new List<String>();
            public List<string> ArrivalLocation = new List<String>();
            public List<string> DepartureTime = new List<string>();
            public List<string> ArrivalTime = new List<string>();
            public List<string> AirplaneNumber = new List<string>();

            public AvailableFlights()
            {
                DepartureDate.Clear();
                DepartureLocation.Clear();
                ArrivalLocation.Clear();
                DepartureTime.Clear();
                ArrivalTime.Clear();
                AirplaneNumber.Clear();

                dbConnection = DatabaseConnection.Instance;
            }

            public async Task QuerySelect(string SortState)
            {
                dbConnection.OpenConnection();

                string sortQuery = SortState == "All" ? "" : $@"WHERE Type = ""{SortState}""";
                
                string query =
                    $@"SELECT Flights.DepartureDate, Flights.ArrivalDate, Flights.AirplaneNumber, Flights.FlightID,
                    ArrivalAirport.AirportCode AS ArrivalAirportCode, DepartureAirport.AirportCode AS DepartureAirportCode
                    FROM flights
                    JOIN Airport AS DepartureAirport ON Flights.DepartureAirportID = DepartureAirport.AirportID
                    JOIN Airport AS ArrivalAirport ON Flights.ArrivalAirportID = ArrivalAirport.AirportID
                    {sortQuery} AND Flights.DepartureDate >= NOW()
                    ORDER BY Flights.DepartureDate ASC; ";

                try
                {
                    MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            //get Date input to DateTime 
                            DateTime Departure = (DateTime)reader["DepartureDate"];
                            DateTime Arrival = (DateTime)reader["ArrivalDate"];
                            //convert to specific formats
                            string DepartureTime = Departure.ToString("HH:mm");
                            string ArrivalTime = Arrival.ToString("HH:mm");
                            string Date = Departure.ToString("MMMM dd, yyyy");

                            //get Departure and Arrival Location in db
                            string DepartureLocation = (string)reader["DepartureAirportCode"];
                            string ArrivalLocation = (string)reader["ArrivalAirportCode"];

                            string AirplaneNumber = (string)reader["AirplaneNumber"];
                            int FlightID = (int)reader["FlightID"];

                            //populate list
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
                    MessageBox.Show($"Database Error: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving data. Please try again. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }
    }
}

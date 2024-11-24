using MySql.Data.MySqlClient;
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
    public partial class Payment : UserControl
    {

        FlightBooking_Session session = FlightBooking_Session.Instance;
        float DepartureSubTotal { get; set; } = 0;
        float ReturnSubTotal { get; set; } = 0;
        float AddonSubTotal { get; set; } = 0;

        public Payment()
        {

            InitializeComponent();
        }



        public void Initialize(String type)
        {

            foreach (string prefix in new[] { "Departure", "Return"})
            {
                foreach (string suffix in new[] { "From", "To", "DepartureTime", "ArrivalTime" , "PlaneNumber" ,"Passengers", "PassengersPrice", "SubtotalPrice" })
                {
                    string controlName = $"lbl{prefix}{suffix}";
                    Control[] controls = this.Controls.Find(controlName, true);
                    if (controls.Length > 0 && controls[0] is Label label)
                    {
                        label.Text = "";
                    }
                }
            }

            lblAddons.Text = "";
            lblAddonPrice.Text = "";
            lblAddonSubtotal.Text = "";
            lblSubtotalPrice.Text = "";
            lblAddonSubtotal.Text = "";

            if (type == "One Way")
            {
                picLine2.Dispose();
                pnlFlightReturn.Dispose();
                lblReturnSeatClass.Dispose();
                pnlReturnExpenses.Dispose();
                pnlReturnPrices.Dispose();


                foreach (string suffix in new[] { "From", "To", "DepartureTime", "ArrivalTime", "PlaneNumber", "Passengers", "PassengersPrice", "SubtotalPrice" })
                {
                    string controlName = $"lblReturn{suffix}";
                    Control[] controls = this.Controls.Find(controlName, true);
                    if (controls.Length > 0 && controls[0] is Label label)
                    {
                        label.Dispose();
                    }
                }
            }


        }


        public void setAddons()
        {
            int AddonCount = 3;
            StringBuilder Addons = new StringBuilder();
            StringBuilder Prices = new StringBuilder();


            foreach (var item in session.Addons)
            { 
                if (!item.Value)
                {
                    AddonCount -= 1;
                    continue;
                }

                Addons.AppendLine(item.Key);
                if (item.Value) {
                    float Price = 0;
                    if (item.Key == "Food") Price = 500.00f;
                    if (item.Key == "Baggage") Price = 700.00f;
                    if (item.Key == "Transport") Price = 1000.00f;

                    this.AddonSubTotal += Price;
                    Prices.AppendLine(String.Format("{0:0.00}", Price));
                }

            }

            if (AddonCount == 0)
            {
                lblAddon.Dispose();
                lblAddonPrice.Dispose();
                lblAddons.Dispose();
                lblAddonSubtotal.Dispose();
                lblAddonSubtotalPrice.Dispose();
                pnlAddons.Dispose();
                pnlAddonsPrices.Dispose();
                picLine3.Dispose();
                return;
            }

            lblAddons.Text = Addons.ToString();
            lblAddonPrice.Text = Prices.ToString();
            lblAddonSubtotal.Text = "Subtotal";
            lblAddonSubtotalPrice.Text = String.Format("{0:0.00}",this.AddonSubTotal);


        }

        public async Task setExpenses(String type)
        {

            //int AdultCount = 2;
            //int ChildrenCount = 2;
            //int InfantCount = 2;
            String SeatClass = session.FlightDetails.ContainsKey("Seat Class") ? session.FlightDetails["Seat Class"] : "Economy";
            float DepartureSubTotal = 0;
            float ReturnSubTotal = 0;

            int AdultCount = session.FlightDetails.ContainsKey("Number of Infants") ? Int32.Parse(session.FlightDetails["Number of Adults"]) : 0 ;
            int ChildrenCount = session.FlightDetails.ContainsKey("Number of Infants") ? Int32.Parse(session.FlightDetails["Number of Children"]) : 0;
            int InfantCount = session.FlightDetails.ContainsKey("Number of Infants") ? Int32.Parse(session.FlightDetails["Number of Infants"]) : 0;


            if (type == "Round Trip")
            {
                Flight Return = new Flight();
                await Return.SelectFlight(session.ReturnAirplaneNumber);
                lblReturnArrivalTime.Text = Return.ArrivalTime;
                lblDepartureDepartureTime.Text = Return.DepartureTime;
                lblReturnFrom.Text = Return.DepartureLocation;
                lblReturnTo.Text = Return.ArrivalLocation;

                lblReturnPlaneNumber.Text = $"Plane Number: {Return.AirplaneNumber}";
                lblReturnPassengers.Text = Passengers();
                lblReturnArrivalTime.Text = Return.ArrivalTime;
                lblReturnDepartureTime.Text = Return.DepartureTime;
                lblReturnFrom.Text = Return.DepartureLocation;
                lblReturnTo.Text = Return.ArrivalLocation;
                lblReturnSeatClass.Text = $"Seat Class: {SeatClass}";
                lblReturnPassengersPrice.Text = PassengerTicketPrices(Return, ref ReturnSubTotal);
                lblReturnSubTotalPrice.Text = String.Format("{0:0.00}", ReturnSubTotal);
                this.ReturnSubTotal = ReturnSubTotal;
            }

            Flight Departure = new Flight();
            await Departure.SelectFlight(session.DepartureAirplaneNumber);


            lblDeparturePlaneNumber.Text = $"Plane Number: {Departure.AirplaneNumber}";
            lblDeparturePassengers.Text = Passengers();
            lblDepartureArrivalTime.Text = Departure.ArrivalTime;
            lblDepartureDepartureTime.Text = Departure.DepartureTime;
            lblDepartureFrom.Text = Departure.DepartureLocation;
            lblDepartureTo.Text = Departure.ArrivalLocation;
            lblDepartureSeatClass.Text = $"Seat Class: {SeatClass}";
            lblDeparturePassengersPrice.Text = PassengerTicketPrices(Departure, ref DepartureSubTotal);
            lblDepartureSubtotalPrice.Text = String.Format("{0:0.00}", DepartureSubTotal);
            this.DepartureSubTotal = DepartureSubTotal;

            String Passengers()
            { 
                StringBuilder sb = new StringBuilder();

                if(AdultCount > 0)
                {
                    sb.AppendLine($"x{AdultCount} Adult");
                }

                if (ChildrenCount > 0)
                {
                    sb.AppendLine($"x{ChildrenCount} Children");
                }

                if (InfantCount > 0)
                {
                    sb.AppendLine($"x{InfantCount} Infant");
                }

                return sb.ToString();
            }

            String PassengerTicketPrices(Flight flight, ref float SubTotal)
            {
                StringBuilder sb = new StringBuilder();
                float price = flight.Price;
                float multiplier = 1;

                if (SeatClass == "Business") multiplier = 2f;
                if (SeatClass == "Business Economy") multiplier = 1.5f;
                if (SeatClass == "First Class") multiplier = 2.5f;

                if(AdultCount > 0)
                {
                    float adultTickets = (float) (price * multiplier) * AdultCount;
                    SubTotal += adultTickets;

                    sb.AppendLine($"{String.Format("{0:0.00}", adultTickets)}");
                }
                if (ChildrenCount > 0) {
                    float childrenTickets = (float) ((price * multiplier) * 0.75) * ChildrenCount;
                    SubTotal += childrenTickets;

                    sb.AppendLine($"{String.Format("{0:0.00}", childrenTickets)}");
                }
                if (InfantCount > 0)
                {
                    float infantTickets = (float) ((price * multiplier) * 0.50) * InfantCount;
                    SubTotal += infantTickets;

                    sb.AppendLine($"{String.Format("{0:0.00}", infantTickets)}");
                }

                
                return sb.ToString();
            }


        }

        private async void Payment_Load(object sender, EventArgs e)
        {
            String type = session.Type == null ? "One Way" : session.Type;

            Initialize(type);
            await setExpenses(type);
            setAddons();
            lblSubtotalPrice.Text = String.Format("{0:0.00}", this.DepartureSubTotal + this.ReturnSubTotal + this.AddonSubTotal);

        }

        private void lblTermsAndConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Terms and Conditions", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

    public class Flight
    {
        private MySqlConnection _connection;
        private String DataBaseName = "airplaneticketingsystem2024";
        private String UserName = "root";
        private String Password = "";
        public String DepartureLocation { get; set; }
        public String DepartureTime { get; set; }
        public String ArrivalLocation { get; set; }
        public String ArrivalTime { get; set; }
        public String AirplaneNumber { get; set; }
        public float Price { get; set; }



        public Flight()
        {
            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

       public async Task SelectFlight(string airplaneNumber)
        {
            try
            {
               await _connection.OpenAsync();

                string query = "SELECT DepartureLocation.AirportCode AS DepartureAirportCode, " +
                "ArrivalLocation.AirportCode AS ArrivalAirportCode, " +
                "flights.ArrivalDate, flights.DepartureDate, flights.AirplaneNumber, " +
                "flights.FlightPrice " +
                "FROM flights " +
                "JOIN airport AS DepartureLocation ON flights.DepartureAirportID = DepartureLocation.AirportID " +
                "JOIN airport AS ArrivalLocation ON ArrivalLocation.AirportID = flights.ArrivalAirportID " +
                "WHERE flights.AirplaneNumber = @AirplaneNumber";

                MySqlCommand command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@AirplaneNumber", airplaneNumber);

                using (var reader = await command.ExecuteReaderAsync()) {
                    if (!reader.HasRows) {
                        return;
                    }
                    while (await reader.ReadAsync())
                    {
                        DepartureLocation = (String) reader["DepartureAirportCode"];
                        ArrivalLocation = (String) reader["ArrivalAirportCode"];
                        DepartureTime = ((DateTime)reader["DepartureDate"]).ToString("hh:mm");
                        ArrivalTime = ((DateTime)reader["ArrivalDate"]).ToString("hh:mm");
                        AirplaneNumber = (String)reader["AirplaneNumber"];
                        Price = float.Parse(reader["FlightPrice"].ToString());
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { await _connection.CloseAsync(); }
        }



    }
}

using FLIGHT_RESERVATION.Flight_Booking;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_Payment;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC.Multiplier;
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
        float DepartureFlightPrice = 0;
        float ReturnFlightPrice = 0;
        
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

            this.SuspendLayout();

            try { 
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
                this.ReturnFlightPrice = Return.Price;
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

            this.DepartureFlightPrice = Departure.Price;
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
                    float multiplier = 1;

                    if (SeatClass == "Premium Economy") multiplier = 2f;
                    if (SeatClass == "Business") multiplier = 1.5f;
                    if (SeatClass == "First Class") multiplier = 2.5f;
                    float AdultSubtotal = 0;
                    float ChildrenSubtotal = 0;
                    float InfantSubtotal = 0;

                    foreach(var item in session.PassengerDetails)
                    {
                        var innerentry = item.Value;

                        if (innerentry["Type"] == "Adult")
                        {
                            Boolean discounted = innerentry["Discounted"] == "Yes" ? true : false;
                            AdultSubtotal += CalculatePrice(discounted, 1.0f, multiplier);
                        }
                        else if (innerentry["Type"] == "Children")
                        {
                            Boolean discounted = innerentry["Discounted"] == "Yes" ? true : false;
                            ChildrenSubtotal += CalculatePrice(discounted, 0.75f, multiplier);
                        }
                        else if (innerentry["Type"] == "Infant")
                        {
                            Boolean discounted = innerentry["Discounted"] == "Yes" ? true : false;
                            InfantSubtotal += CalculatePrice(discounted, 0.5f, multiplier);
                        }
                    }


                    float CalculatePrice(Boolean Discounted, float typeMultiplier, float seatMultiplier)
                    {
                        float basePrice = (flight.Price * typeMultiplier) * seatMultiplier;
                        float subtotal = 0;
                        if (Discounted) {
                            float discount = basePrice * 0.20f;
                            subtotal = basePrice - discount;
                        }
                        else
                        {
                            float tax = basePrice * 0.12f;
                            subtotal = basePrice + tax;
                        }
                        return subtotal;  
                    }

                    SubTotal += AdultSubtotal + ChildrenSubtotal + InfantSubtotal;
                    if (AdultSubtotal > 0) sb.AppendLine($"{String.Format("{0:0.00}", AdultSubtotal)}");
                    if (ChildrenSubtotal > 0) sb.AppendLine($"{String.Format("{0:0.00}", ChildrenSubtotal)}");
                    if (InfantSubtotal > 0) sb.AppendLine($"{String.Format("{0:0.00}", InfantSubtotal)}");

                    return sb.ToString();
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        private async void Payment_Load(object sender, EventArgs e)
        {
            String type = session.Type == null ? "One Way" : session.Type;


            this.SuspendLayout();
            Initialize(type);
            await setExpenses(type);
            setAddons();
            lblSubtotalPrice.Text = String.Format("{0:0.00}", this.DepartureSubTotal + this.ReturnSubTotal + this.AddonSubTotal);
            session.BookingSubTotal = this.DepartureSubTotal + this.ReturnSubTotal + this.AddonSubTotal;
            this.ResumeLayout();
        }

        private void lblTermsAndConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var termsForm = new TermsAndConditions())
            {
                if (termsForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Terms and conditions accepted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkTermsAndConditions.Checked = true;
                }
                else
                {
                    chkTermsAndConditions.Checked = false;
                }
            }

        }

 

        private void btnReturnViewDetails_Click(object sender, EventArgs e)
        {
            String SeatClass = session.FlightDetails.ContainsKey("Seat Class") ? session.FlightDetails["Seat Class"] : "Economy";
            float multiplier = 1;
            if (SeatClass == "Premium Economy") multiplier = 2f;
            if (SeatClass == "Business") multiplier = 1.5f;
            if (SeatClass == "First Class") multiplier = 2.5f;

            var PaymentDetails = new PaymentDetails();
            PaymentDetails.IntializeDetails(lblReturnFrom.Text, lblReturnTo.Text, ReturnFlightPrice, ReturnSubTotal, multiplier);
            PaymentDetails.ShowDialog();
        }

        private void btnDepartureViewDetails_Click(object sender, EventArgs e)
        {
            String SeatClass = session.FlightDetails.ContainsKey("Seat Class") ? session.FlightDetails["Seat Class"] : "Economy";
            float multiplier = 1;
            if (SeatClass == "Premium Economy") multiplier = 2f;
            if (SeatClass == "Business") multiplier = 1.5f;
            if (SeatClass == "First Class") multiplier = 2.5f;

            var PaymentDetails = new PaymentDetails();
            PaymentDetails.IntializeDetails(lblDepartureFrom.Text, lblDepartureTo.Text, DepartureFlightPrice, DepartureSubTotal ,multiplier);
            PaymentDetails.ShowDialog();
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
                if (_connection.State != ConnectionState.Open)
                    await _connection.OpenAsync();

                string query = @"SELECT DepartureLocation.AirportCode AS DepartureAirportCode, 
                ArrivalLocation.AirportCode AS ArrivalAirportCode, 
                flights.ArrivalDate, flights.DepartureDate, 
                flights.AirplaneNumber, flights.FlightPrice 
                FROM flights 
                JOIN airport AS DepartureLocation ON flights.DepartureAirportID = DepartureLocation.AirportID 
                JOIN airport AS ArrivalLocation ON ArrivalLocation.AirportID = flights.ArrivalAirportID 
                WHERE flights.AirplaneNumber = @AirplaneNumber; "; 

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

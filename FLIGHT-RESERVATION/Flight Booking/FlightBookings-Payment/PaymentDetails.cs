using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_Payment
{
    public partial class PaymentDetails : Form
    {
  

        public PaymentDetails()
        {
            InitializeComponent();
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {

        }
        public void IntializeDetails(String from, String to, float flightPrice, float SubTotal ,float SeatMultiplier)
        {

            var session = FlightBooking_Session.Instance;

            int currentRow = 0;
            int currentColumn = 0;

            List<String> PassengerNames = new List<String>();
            List<String> PassengerTypes = new List<String>();
            List<Boolean> Discounts = new List<Boolean>();

            foreach(var item in session.PassengerDetails)
            {
                PassengerNames.Add(item.Value["First Name"] + " " +item.Value["Last Name"]);
                PassengerTypes.Add(item.Value["Type"]);
                Discounts.Add(item.Value["Discounted"] == "Yes"? true : false);
            }

            lblFlight.Text = $"{from} to {to}";
            string formattedFlightPrice = flightPrice.ToString("N2");
            lblFlightPrice.Text = $"{formattedFlightPrice} Php";
            string formattedSubtotal = SubTotal.ToString("N2");
            lblSubTotal.Text = $"Total:          {formattedSubtotal} Php"; ;


            for (int i = 0; i < PassengerNames.Count; i++)
            {
                var PassengerNameLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Text = $"Passenger Name: {PassengerNames[i]} "
                };
                var PassengerTypeLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Passenger Type"
                };
                var SeatClassLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Seat Class"
                };
                var BasePriceLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Base Price"
                };
                var DiscountLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Discount"
                };
                var ValueAddedTaxLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Value Added Tax (12%)"

                };
                var SubtotalLabel = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = "Subtotal"
                };


                //Values

                float multiplier = 0;
                if (PassengerTypes[i] == "Adult") multiplier = 1.0f;
                if (PassengerTypes[i] == "Child") multiplier = 0.75f;
                if (PassengerTypes[i] == "Infant") multiplier = 0.5f;


                var PassengerType = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = PassengerTypes[i]
                };
                var SeatClass = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = session.FlightDetails["Seat Class"]
                };
                var BasePrice = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = $"{String.Format("{0:0.00}", ((flightPrice * multiplier) * SeatMultiplier))}"
                };

                float taxDiscount = 0;
                float DiscountPrice = 0;
                float basePrice = ((flightPrice * multiplier) * SeatMultiplier);
                float subtotal = 0;
                float tax = basePrice * 0.12f;


                String DiscountPriceString = "";
                if (Discounts[i])
                {
                    taxDiscount = basePrice * 0.12f;
                    DiscountPrice = 0.20f * basePrice;
                    subtotal = basePrice - DiscountPrice;

                    DiscountPriceString = $"Tax Exempt: {String.Format("{0:0.00}", -taxDiscount)} \n" +    
                    $"20% Discount: {String.Format("{0:0.00}", -DiscountPrice)}";
                }
                else
                {
                    subtotal = basePrice + tax;
                    DiscountPriceString = "0";
                }


                var Discount = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = DiscountPriceString.ToString()
                };
                var ValueAddedTax = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = $"{String.Format("{0:0.00}", tax)}"

                };
                var Subtotal = new Label()
                {
                    Font = new System.Drawing.Font("Kantumruy Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                    AutoSize = true,
                    Dock = DockStyle.Right,
                    Text = $"{subtotal}"
                };


                pnlDetails.Controls.Add(PassengerNameLabel, currentColumn, currentRow++);
                
                pnlDetails.Controls.Add(PassengerTypeLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(PassengerType, currentColumn + 1, currentRow++);

                pnlDetails.Controls.Add(SeatClassLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(SeatClass, currentColumn + 1, currentRow++);

                pnlDetails.Controls.Add(BasePriceLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(BasePrice, currentColumn + 1, currentRow++);

                pnlDetails.Controls.Add(ValueAddedTaxLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(ValueAddedTax, currentColumn + 1, currentRow++);


                pnlDetails.Controls.Add(DiscountLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(Discount, currentColumn + 1, currentRow++);


                pnlDetails.Controls.Add(SubtotalLabel, currentColumn, currentRow);
                pnlDetails.Controls.Add(Subtotal, currentColumn + 1, currentRow++);
            }
        }
    }
}
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_PaymentDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    public partial class FlightBooking_PaymentDetails : UserControl
    {

        String type { get; set; } = "Card";
        CardDetails cardDetails = new CardDetails();
        GCash gcash = new GCash();



        public FlightBooking_PaymentDetails()
        {
            InitializeComponent();
        }



        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!ValidateContents()) { return; }
            Console.WriteLine(GenerateTransactionId());
        }

        public static string GenerateTransactionId()
        {
            string prefix = "ATS";

            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999); 

            return $"{prefix}{randomNumber}";
        }

        public bool ValidateContents()
        {
            if (type == "Card" && cardDetails.ValidateInput()) return true;
            return false;

        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            if(type == "Card"){
                  btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.GCash_button;
                  type = "GCash";
                  cardDetails.Hide();
                  gcash.Show();
            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.Card_button;
                type = "Card";
                cardDetails.Show();
                gcash.Hide();
            }
        }

        private void FlightBooking_PaymentDetails_Load(object sender, EventArgs e)
        {
            cardDetails.AutoSize = true;
            cardDetails.Location = new Point(0, 0);
            gcash.AutoSize = true;
            gcash.Location = new Point(0, 0);
            pnlPaymentDetails.Controls.Add(cardDetails);
            pnlPaymentDetails.Controls.Add(gcash);
            gcash.Hide();
        }
    }
}

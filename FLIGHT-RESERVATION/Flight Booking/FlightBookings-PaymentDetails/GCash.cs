using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_PaymentDetails
{
    public partial class GCash : UserControl
    {
        public GCash()
        {
            InitializeComponent();
        }

        private void GCash_Load(object sender, EventArgs e)
        {
            String totalPrice = FlightBooking_Session.Instance.BookingSubTotal.ToString("N2");
            lblTotalPrice.Text = $"{totalPrice} Php";
        }
    }
}

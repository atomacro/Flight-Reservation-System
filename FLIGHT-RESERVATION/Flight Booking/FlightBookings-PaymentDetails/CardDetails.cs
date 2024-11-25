using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_
{
    public partial class CardDetails : UserControl
    {

        public CardDetails()
        {
            InitializeComponent();
        }
        private void CardDetails_Load(object sender, EventArgs e)
        {
            String totalPrice = FlightBooking_Session.Instance.BookingSubTotal.ToString("N2");
            lblBookingTotal.Text = $"Booking Total: {totalPrice}";

        }
    }
}

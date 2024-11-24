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

        public bool isReferenceNumberValid()
        {
            if (!Regex.IsMatch(txtReferenceNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Reference number must be Numeric", "Reference number invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtReferenceNumber.Text.Length != 13) {
                MessageBox.Show("Reference number must be 13 digits long", "Reference number invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtReferenceNumber.Text))
            {
                MessageBox.Show("Fill up all fields","Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GCash_Load(object sender, EventArgs e)
        {
            String totalPrice = FlightBooking_Session.Instance.BookingSubTotal.ToString("N2");
            lblTotalPrice.Text = $"{totalPrice} Php";
        }
    }
}

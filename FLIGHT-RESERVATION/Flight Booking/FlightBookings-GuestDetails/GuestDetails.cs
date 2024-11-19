using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails
{
    public partial class GuestDetails : UserControl
    {
        public GuestDetails(String type, int num)
        {
            InitializeComponent();
            String label = $"{type} {num} Details";
            if (num == 0) label = "Passenger Details";
            lblDetails.Text = label;
        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {
            txtFirstName.TextChanged += (s, @event) =>
            {
               lblDetails.Text = txtFirstName.Text + "'s Details";
            };
        }


    }
}

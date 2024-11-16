using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;
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
    public partial class FlightBooking_FlightDetails : UserControl
    {
        public FlightBooking_FlightDetails()
        {
            InitializeComponent();
        }

        String state = "One Way";
        Round_Trip RoundTrip = new Round_Trip();
        One_Way OneWay = new One_Way();
        private void btnChangeType_Click(object sender, EventArgs e)
        {
           

            if (state == null) state = "One Way";

            if (!pnlFlightBooking.Controls.Contains(OneWay))
            {
                OneWay.AutoSize = true;
                OneWay.Location = new Point(0, 0);
                pnlFlightBooking.Controls.Add(OneWay);
            }

            if (!pnlFlightBooking.Controls.Contains(RoundTrip))
            {
                RoundTrip.AutoSize = true;
                RoundTrip.Location = new Point(0, 0);
                pnlFlightBooking.Controls.Add(RoundTrip);
            }

            if (state == "One Way")
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.TwoWayButton;
                state = "Two Way";
                OneWay.Hide();
                RoundTrip.Show();
            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.OneWayButton;
                state = "One Way";
                RoundTrip.Hide();
                OneWay.Show();
            }
        }
    }
}

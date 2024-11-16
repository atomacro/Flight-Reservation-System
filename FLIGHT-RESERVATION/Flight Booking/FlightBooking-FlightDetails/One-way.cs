using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails
{
    public partial class One_Way : UserControl
    {
        public One_Way()
        {
            InitializeComponent();
        }

        private void picCompanions_Click(object sender, EventArgs e)
        {

        }

        public void setDepartureLocation(Dictionary<String, String> departure) {
            cboDepartureLocation.Items.Clear();
            cboDepartureLocation.Items.AddRange(departure.Keys.ToArray());
            cboDepartureLocation.Click += (s, e) =>
            {
                if (cboDepartureLocation.SelectedItem != null)
                {
                    lblDepartureLocation.Text = departure[cboDepartureLocation.SelectedItem.ToString()];
                }
            };
        }
    }
}

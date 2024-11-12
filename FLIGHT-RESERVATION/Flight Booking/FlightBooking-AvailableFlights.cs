using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights;
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
    public partial class FlightBooking_AvailableFlights : UserControl
    {
        public FlightBooking_AvailableFlights()
        {
            InitializeComponent();
        }

        private void FlightBooking_AvailableFlights_Load(object sender, EventArgs e)
        {
            PopulateAvailableBookings();
        }








        public void PopulateAvailableBookings()
        {
            List<AvailableFlights> availableFlights = new List<AvailableFlights>();

            int selectedIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                var AvailableFlight = new AvailableFlights();
                AvailableFlight.Click += (s, e) =>
                {
                    selectedIndex = availableFlights.IndexOf(AvailableFlight); // get index of the selected Flight
                    setSelected(availableFlights, selectedIndex); // set the border of the AvailableFlight
                };

                availableFlights.Add(AvailableFlight); // add every instance of AvailableFlights to the list
                pnlAvailableFlights.Controls.Add(AvailableFlight);
            }
        }

        public void setSelected(List<AvailableFlights> availableFlights, int index)
        {
            for (int  i = 0;  i < availableFlights.Count;  i++)
            {
                if(i != index)
                {
                    availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border); //reset the borders of unselected
                    continue;
                }

                availableFlights[i].setBorder(global::FLIGHT_RESERVATION.Properties.Resources.Selected_Border); //set border to selected

            }
        }

        // this.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.Selected_Border;
        // this.BackgroundImage = global::FLIGHT_RESERVATION.Properties.Resources.Unselected_Border;

    }
}

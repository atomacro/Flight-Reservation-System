using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBooking_AddOns
{
    public partial class FlightBooking_AddOns : UserControl
    {
        public FlightBooking_AddOns()
        {
            InitializeComponent();
            Select();
        }

        public Dictionary<String, Boolean> Addons { get; set; }

        new public void Select()
        {
            Boolean Food = false;
            Boolean Baggage = false;
            Boolean Services = false;

            picBaggage.Click += (sender, e) => SelectImage(ref Baggage, picBaggage);
            picFood.Click += (sender, e) => SelectImage(ref Food, picFood);
            picServices.Click += (sender, e) => SelectImage(ref Services, picServices);



            void SelectImage(ref Boolean condition, PictureBox pic)
            {
                if (condition)
                {
                    pic.Image = global::FLIGHT_RESERVATION.Properties.Resources.ADDONS_UNSELECTED;
                    condition = false;
                }
                else
                {
                    pic.Image = global::FLIGHT_RESERVATION.Properties.Resources.ADDONS_SELECTED;
                    condition = true;
                }

            }
        }
    }
}

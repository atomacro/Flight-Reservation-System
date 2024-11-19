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
        }

        public Dictionary<String, Boolean> Addons { get; set; }

        public void Select()
        {
            Boolean Food = false;
            Boolean Baggage = false;
            Boolean Services = false;

            picBaggage.Click += (sender, e) => SelectImage(Baggage, picBaggage);
            picFood.Click += (sender, e) => SelectImage(Baggage, picFood);
            picServices.Click += (sender, e) => SelectImage(Baggage, picServices);



            void SelectImage(Boolean cond, PictureBox pic)
            {
                if (cond)
                {
                    pic.Image = global::FLIGHT_RESERVATION.Properties.Resources.ADDONS_UNSELECTED;
                    cond = false;
                    return;
                }
                pic.Image = global::FLIGHT_RESERVATION.Properties.Resources.ADDONS_SELECTED;
                Baggage = true;
            }

        }


    }
}

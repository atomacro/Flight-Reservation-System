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

        public Dictionary<String, Boolean> Addons = new Dictionary<string, Boolean>();
        Boolean Food;
        Boolean Baggage;
        Boolean Transport;

        new public void Select()
        {
            this.Food = false;
            this.Baggage = false;
            this.Transport = false;

            picBaggage.Click += (sender, e) => SelectImage(ref Baggage, borderBaggage);
            picFood.Click += (sender, e) => SelectImage(ref Food, borderFood);
            picTransport.Click += (sender, e) => SelectImage(ref Transport, borderTransport);

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

         public void HandleSubmit(Object sender, EventArgs e)
        {

            if (Addons != null) Addons.Clear();
            Addons["Food"] = Food;
            Addons["Baggage"] = Baggage;
            Addons["Transport"] = Transport;
            FlightBooking_Session.Instance.setAddons(Addons);

        }

    }
}

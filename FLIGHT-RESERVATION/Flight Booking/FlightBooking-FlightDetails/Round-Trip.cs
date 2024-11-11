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
    public partial class Round_Trip : UserControl
    {
        public Round_Trip()
        {
            InitializeComponent();
        }

        private void Round_Trip_Load(object sender, EventArgs e)
        {
            foreach (ComboBox cbo in this.Controls.OfType<ComboBox>().ToList())
            {
                cbo.DropDownStyle = ComboBoxStyle.DropDownList
                ComboBox currentCbo = cbo;

            }
        }

        private void picLine_Click(object sender, EventArgs e)
        {

        }
    }
}

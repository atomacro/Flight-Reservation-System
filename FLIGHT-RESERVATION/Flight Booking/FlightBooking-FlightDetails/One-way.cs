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
    public partial class One_Way : UserControl, Trips
    {

        public ComboBox cboArrivalLocationControl => this.cboArrivalLocation;
        public ComboBox cboDepartureLocationControl => this.cboDepartureLocation;
        public ComboBox cboDepartureDateControl => this.cboDepartureDate;
        public ComboBox cboReturnDateControl => null;


        public One_Way()
        {
            InitializeComponent();
        }

        private void One_Way_Load(object sender, EventArgs e)
        {
            foreach (ComboBox cbo in this.Controls.OfType<ComboBox>().ToList())
            {
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.Font = new Font("Kantumruy Pro Medium", 12.0f);

            }

            foreach (Label label in this.Controls.OfType<Label>().ToList())
            {
                if (label == lblAdult || label == lblChildren || label == lblInfant)
                {
                    continue;
                }
                label.ForeColor = ColorTranslator.FromHtml("#9C9C9C");
            }
        }

        public void SetArrivalLocation(Dictionary<string, string> locations)
        {

            cboArrivalLocation.Items.Clear();
            cboArrivalLocation.Items.AddRange(locations.Keys.ToArray());
            cboArrivalLocation.SelectedIndexChanged += (s, e) =>
            {
                lblArrivalLocation.Text = locations[cboArrivalLocation.Text];
            };
        }
        public void SetDepartureLocation(Dictionary<string, string> locations)
        {
            cboDepartureLocation.Items.Clear();
            cboDepartureLocation.Items.AddRange(locations.Keys.ToArray());
            cboDepartureLocation.SelectedIndexChanged += (s, e) =>
            {
                lblDepartureLocation.Text = locations[cboDepartureLocation.Text];
            };
        }

        public void SetDates(List<string> departureDates, List<string> returnDates = null)
        {
            cboDepartureDate.Items.Clear();
            cboDepartureDate.Items.AddRange(departureDates.ToArray());
        }
    }
}

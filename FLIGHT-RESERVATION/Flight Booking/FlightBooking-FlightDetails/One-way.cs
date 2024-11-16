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

        private void One_Way_Load(object sender, EventArgs e)
        {
            foreach (ComboBox cbo in this.Controls.OfType<ComboBox>().ToList())
            {
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.Font = new Font("Kantumruy Pro", 12.0f, FontStyle.Bold);

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

        public void setDepartureLocation(Dictionary<String, String> departure)
        {
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

        public void setArrivalLocation(Dictionary<String, String> arrival)
        {
            cboArrivalLocation.Items.Clear();
            cboArrivalLocation.Items.AddRange(arrival.Keys.ToArray());
            cboArrivalLocation.Click += (s, e) =>
            {
                if (cboArrivalLocation.SelectedItem != null)
                {
                    lblArrivalLocation.Text = arrival[cboDepartureLocation.SelectedItem.ToString()];
                }
            };
        }

        public void setDepartureDate(List<String> departureDate) {
            cboDepartureDate.Items.Clear();
            cboDepartureDate.Items.AddRange(departureDate.ToArray());
            
        }
    }
}

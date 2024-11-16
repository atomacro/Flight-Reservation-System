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
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.Font = new Font("Kantumruy Pro", 12.0f, FontStyle.Bold);

            }

            foreach (Label label in this.Controls.OfType<Label>().ToList())
            {
                if(label == lblAdult || label == lblChildren || label == lblInfant)
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
        public void setDates(Dictionary<string, List<string>> departureDates)
        {
            cboDepartureDate.Items.Clear();
            cboDepartureDate.Items.AddRange(departureDates.Keys.ToArray());
            cboDepartureDate.SelectedIndexChanged -= OnDepartureDateChanged;
            cboDepartureDate.SelectedIndexChanged += OnDepartureDateChanged;
            void OnDepartureDateChanged(object sender, EventArgs e)
            {
                if (cboDepartureDate.SelectedItem != null)
                {
                    cboReturnDate.Items.Clear();
                    foreach (string returnDate in departureDates[cboDepartureDate.SelectedItem.ToString()])
                    {
                        cboReturnDate.Items.Add(returnDate);
                    }
                }
            }
        }


    }
}

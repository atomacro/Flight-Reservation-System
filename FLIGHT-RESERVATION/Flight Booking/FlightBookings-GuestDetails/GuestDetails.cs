using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails
{
    public partial class GuestDetails : UserControl
    {
        public GuestDetails(String type, int num)
        {
            InitializeComponent();
            String label = $"{type} {num} Details";
            if (num == 0) label = "Passenger Details";
            lblDetails.Text = label;
        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {
            HandleText();
            foreach (TextBox txt in this.Controls.OfType<TextBox>().ToArray()) {

                txt.BackColor = ColorTranslator.FromHtml("#F4F4F4");
            }
        }

        public void HandleText()
        {
            txtFirstName.TextChanged += (s, @event) =>
            {
                lblDetails.Text = txtFirstName.Text + "'s Details";
            };

            txtAge.TextChanged += (s, @event) =>
            {
                if (string.IsNullOrWhiteSpace(txtAge.Text)) return;

                if (!int.TryParse(txtAge.Text, out int num) || num < 0 || num > 110)
                {
                    MessageBox.Show("Age must be from range 0 - 110 only");
                    txtAge.Text = "";
                    btnFocus.Focus();
                }
            };
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

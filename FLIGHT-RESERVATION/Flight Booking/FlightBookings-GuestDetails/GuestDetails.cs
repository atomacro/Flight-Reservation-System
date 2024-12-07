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
        public String type;

        public GuestDetails(String type, int num)
        { 
            InitializeComponent();
            String label = $"{type} {num} Details";
            if (num == 0) label = "Passenger Details";
            lblDetails.Text = label;

            Console.WriteLine(type);
            if (type == "Passenger" || type == "Adult") this.type = "Adult";
            else if (type == "Child")
            {
                this.type = "Child";
                chkDiscounted.Visible = false;
            }
            else if (type == "Infant")
            {
                this.type = "Infant";
                chkDiscounted.Visible = false;
            }

        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>().ToArray()) {

                txt.BackColor = ColorTranslator.FromHtml("#F4F4F4");
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text)) return;

            if (!int.TryParse(txtAge.Text, out int num) || num < 0 || num > 110)
            {
                txtAge.Text = "";
                MessageBox.Show("Age must be from range 0 - 110 only");
                btnFocus.Focus();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //lblDetails.Text = txtFirstName.Text + "'s Details";

        }
    }
}

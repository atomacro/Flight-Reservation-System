using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public partial class FlightBookings_GuestDetails : UserControl
    {
        public FlightBookings_GuestDetails()
        {
            InitializeComponent();
        }


        //private int numAdults = int.Parse(FlightDetails_Session.Instance.FlightDetails["Number of Adults"]);
        //private int numChildren = int.Parse(FlightDetails_Session.Instance.FlightDetails["Number of Children"]);
        //private int numInfants = int.Parse(FlightDetails_Session.Instance.FlightDetails["Number of Infants"]);

        private int numAdults = 2;
        private int numChildren = 0;
        private int numInfants = 0;
        Dictionary<String, GuestDetails> guestDetails = new Dictionary<string, GuestDetails>();
        private void InitializeGuestDetails()
        {
            if (numAdults + numChildren + numInfants > 1)
            {
                int total = numAdults + numChildren + numInfants;
                if (total % 2 != 0) total += 1;
                int numRows = (total / 2);

                TableLayoutPanel GuestDetailsLayout = new TableLayoutPanel()
                {
                    Width = pnlGuestDetails.Width,
                    AutoSize = true,
                    Dock = DockStyle.Top
                };
                int xCenter = (pnlGuestDetails.Width - GuestDetailsLayout.Width) / 2;
                GuestDetailsLayout.Location = new Point(xCenter + 20, GuestDetailsLayout.Location.Y);

                GuestDetailsLayout.Width = pnlGuestDetails.Width / 2;
                GuestDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                GuestDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                int currentColumn = 0;
                int currentRow = 0;

                InitializeGuestDetails("Adult", numAdults);
                InitializeGuestDetails("Children", numChildren);
                InitializeGuestDetails("Infant", numInfants);


                void InitializeGuestDetails(String type, int counter)
                {
                    for (int i = 1; i <= counter; i++)
                    {
                        var GuestDetails = new GuestDetails(type, i) { Margin = new Padding(0, 25, 0, 0) };
                        GuestDetailsLayout.Controls.Add(GuestDetails, currentColumn, currentRow);
                        if (currentColumn == 1) { currentColumn = 0; currentRow++; }
                        else currentColumn++;
                        guestDetails[$"{type} {i}"] = GuestDetails;
                    }
                }

                pnlGuestDetails.Controls.Add(GuestDetailsLayout);
            }
            else
            {
                var GuestDetails = new GuestDetails("Passenger", 0);
                pnlGuestDetails.Controls.Add(GuestDetails);
                GuestDetails.AutoSize = true;
                GuestDetails.Left = (pnlGuestDetails.Width - GuestDetails.Width) / 2;
                GuestDetails.Top = (pnlGuestDetails.Height - GuestDetails.Height) / 2;
                guestDetails["Adult 1"] = GuestDetails;
            }

            btnContinue.Click += Validate;


            void Validate(object s, EventArgs e)
            {
                foreach (var item in guestDetails)
                {

                    foreach (TextBox txt in item.Value.Controls.OfType<TextBox>().ToList())
                    {
                        if (string.IsNullOrWhiteSpace(txt.Text))
                        {
                            MessageBox.Show($"{txt} cannot be empty");
                            return;
                        }
                    }

                    var birthdateBox = item.Value.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "txtBirthdate");
                    if (birthdateBox != null &&
                        !DateTime.TryParseExact(birthdateBox.Text, "MMMM dd, yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                    {
                        MessageBox.Show("Birthdate must be in 'MMMM dd, yyyy' format.\nExample: January 1, 2001.");
                        return;
                    }
                }
                MessageBox.Show("Clear");
            }
        }

        private void FlightBookings_GuestDetails_Load(object sender, EventArgs e)
        {
            InitializeGuestDetails();
        }

        private void guestDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}

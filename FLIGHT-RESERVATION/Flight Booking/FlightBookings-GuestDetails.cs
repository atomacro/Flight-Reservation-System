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

        private int numAdults = 3;
        private int numChildren = 2;
        private int numInfants = 1;
        new Dictionary<String, GuestDetails> guestDetails = new Dictionary<string, GuestDetails>();
        private void InitializeGuestDetails()
        {
            if(numAdults + numChildren + numInfants > 1)
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
                btnContinue.Click += (s, e) => { Console.WriteLine(guestDetails["Adult 1"].txtFirstName.Text);};
            }
            else
            {
                var GuestDetails = new GuestDetails("Passenger", 0);
                pnlGuestDetails.Controls.Add(GuestDetails);
                GuestDetails.AutoSize = true;
                GuestDetails.Left = (pnlGuestDetails.Width - GuestDetails.Width) / 2;
                GuestDetails.Top = (pnlGuestDetails.Height - GuestDetails.Height) / 2;
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

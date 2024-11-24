using FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    public partial class FlightBooking_PaymentDetails : UserControl
    {
        public FlightBooking_PaymentDetails()
        {
            InitializeComponent();
        }



        private void btnContinue_Click(object sender, EventArgs e)
        {
            String firstName = cardDetails1.txtFirstName.Text;
            Console.WriteLine(firstName);


        }
    }
}

﻿using System;
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

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblDetails.Text = $"{txtFirstName.Text.Trim()} 's Details";
            Console.WriteLine(txtFirstName.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using FLIGHT_RESERVATION.Flight_Booking;
using FLIGHT_RESERVATION.ViewBookings;

namespace FLIGHT_RESERVATION
{
    public partial class Bookings : UserControl
    {
        private string TransactionID;
        private string FlightID;

        public Bookings()
        {
            InitializeComponent();
            lblTime1.ForeColor = ColorTranslator.FromHtml("#9F8FFF");
            lblTime2.ForeColor = ColorTranslator.FromHtml("#9F8FFF");

            this.TransactionID = TransactionID;
            this.FlightID = FlightID;
        }
        public void SetDate(string date)
        {
            lblDate.Text = date;
        }
        public void setLocation(string location1, string location2)
        {
            lblLocation1.Text = location1;
            lblLocation2.Text = location2;
        }

        public void setTime(string time1, string time2)
        {
            lblTime1.Text = time1;
            lblTime2.Text = time2;
        }

        public void setAirplaneNumber(String airplaneNumber) { 
            lblAirplaneNumber.Text = "Flight: " + airplaneNumber;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime1_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation2_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void lblLocation1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }

        private void lblAirplaneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}


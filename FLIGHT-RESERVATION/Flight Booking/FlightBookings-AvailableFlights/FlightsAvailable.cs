﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings_AvailableFlights
{
    public partial class FlightsAvailable : UserControl
    {
        public FlightsAvailable()
        {
            InitializeComponent();
            lblTime1.ForeColor = ColorTranslator.FromHtml("#9C9C9C");
            lblTime2.ForeColor = ColorTranslator.FromHtml("#9C9C9C");
        }

        public void setLocations(String location1, String location2)
        {
            lblLocation1.Text = location1;
            lblLocation2.Text = location2;
        }

        public void setAirplaneNumber(String airplaneNumber) { 
        
            lblAirplaneNumber.Text = airplaneNumber;
        }

        public void setTime(String time1, String time2)
        {
            lblTime1.Text = time1;
            lblTime2.Text = time2;
        }

        public void setSeatsAvailable(String SeatsAvailable)
        {
            lblSeatsAvailable.Text = $"{SeatsAvailable} Seats Available";
        }

        public void setBorder(Image img)
        {
            this.BackgroundImage = img;
        }

        public void setPrice(float price)
        {
            lblPrice.Text = $"Price: {price}.00";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }

        private void lblSeatsAvailable_Click(object sender, EventArgs e)
        {

        }

        private void FlightsAvailable_Load(object sender, EventArgs e)
        {

        }
    }
}




﻿using System;
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
    public partial class Bookings : UserControl
    {
        public Bookings()
        {
            InitializeComponent();
        }

        public void SetDate(DateTime date) {
            lblDate.Text = date.ToString();
        }
        public void setLocation(string location1, string location2) { 
            lblLocation1.Text = location1;
            lblLocation2.Text = location2;
        }

        public void setTime(string time1, string time2) { 
            lblTime1.Text = time1;
            lblTime2.Text = time2;
        }

    }
}

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
    public partial class View_Bookings : UserControl
    {
        public View_Bookings()
        {
            InitializeComponent();
        }

        private void View_Bookings_Load(object sender, EventArgs e)
        {
            Bookings booking = new Bookings();
        }
    }
}

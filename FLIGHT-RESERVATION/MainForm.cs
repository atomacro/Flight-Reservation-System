﻿using FLIGHT_RESERVATION.ViewBookings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FLIGHT_RESERVATION
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String formColor = "#E6E9F0";
            this.BackColor = ColorTranslator.FromHtml(formColor);
            Header.BackColor = Color.White;
            SetButtonBorders();
            InitializeSidebar();
            SetHeader("DASHBOARD");
            SetIndicator(btnDashboard, pnlIndicator1);
        }

        public void SetIndicator(Button activeButton, Panel pnlIndicator)
        {
            ResetButtonColors();
            pnlIndicator.BackColor = ColorTranslator.FromHtml("#A780F4");
            activeButton.BackColor = ColorTranslator.FromHtml("#F4F3FF");
        }


        public void SetHeader(string PageName)
        {
            Fonts fonts = new Fonts();
            lblPageName.Text = PageName;
            lblPageName.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            lblPageName.Font = fonts.KantumruyProBold(35.0F);
        }

        public void SetButtonBorders()
        {
            Button[] btns = { btnDashboard, btnFlightBooking, btnViewBookings, btnProfile, btnLogout };

            foreach (Button btn in btns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
            }

            Panel[] panels = { pnlIndicator1, pnlIndicator2, pnlIndicator3, pnlIndicator4 };
            foreach (Panel pnl in panels)
            {
                pnl.BackColor = Color.White;
            }
        }

        public void ResetButtonColors()
        {
            foreach (Control control in this.Controls)
            {
                switch (control)
                {
                    case Button btn:
                        btn.BackColor = Color.White;
                        break;
                    case Panel pnl:
                        pnl.BackColor = Color.White;
                        break;
                }
            }
        }

        private void InitializeSidebar()
        {
            btnDashboard.Click += (sender, e) =>
            {
                SetIndicator(btnDashboard, pnlIndicator1);
                SetHeader("DASHBOARD");
                pnlMain.Controls.Clear();
            };
            btnFlightBooking.Click += (sender, e) =>
            {
                SetIndicator(btnFlightBooking, pnlIndicator2);
                SetHeader("FLIGHT BOOKING");

                pnlMain.Controls.Clear();

                ViewBookings.ViewBookings vb = new ViewBookings.ViewBookings();
                vb.AutoSize = true;
                vb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                pnlMain.Controls.Add(vb);
            };
            btnViewBookings.Click += (sender, e) =>
            {
                SetIndicator(btnViewBookings, pnlIndicator3);
                SetHeader("VIEW BOOKINGS");
                pnlMain.Controls.Clear();
            };
            btnProfile.Click += (sender, e) =>
            {
                SetIndicator(btnProfile, pnlIndicator4);
                SetHeader("PROFILE");
                pnlMain.Controls.Clear();
            };
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void viewBookings1_Load(object sender, EventArgs e)
        {

        }

        private void viewBookings1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

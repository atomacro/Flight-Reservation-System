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
using FLIGHT_RESERVATION.Flight_Booking;
using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_AddOns;
using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;

namespace FLIGHT_RESERVATION
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //pnlMain.BackColor = Color.Transparent;
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

            UpdateUIBasedOnLoginStatus(Session.IsLoggedIn);

        }

        // ------ UI Related Methods ------
        public void SetIndicator(Button activeButton, Panel pnlIndicator)
        {
            ResetButtonColors();
            pnlIndicator.BackColor = ColorTranslator.FromHtml("#A780F4");
            activeButton.BackColor = ColorTranslator.FromHtml("#F4F3FF");
        }


        public void SetHeader(string PageName)
        {
            lblPageName.Text = PageName;
            lblPageName.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            lblPageName.Font = new Font("Kantumruy Pro", 35.0F, FontStyle.Bold);
        }

        public void SetButtonBorders()
        {
            Button[] btns = { btnDashboard, btnFlightBooking, btnViewBookings, btnProfile, btnLogout, btnLogin };

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


        private void ViewBookings()
        {
            var FlightDetails = new FlightBooking_FlightDetails();

            FlightDetails.OneWay.btnSearchFlight.Click += (s, e) =>
            {
                SetupFlightSearch(FlightDetails.OneWay, "One Way");
            };

            FlightDetails.RoundTrip.btnSearchFlight.Click += (s, e) =>
            {
                SetupFlightSearch(FlightDetails.RoundTrip, "Round Trip");
            };

            AddControl(FlightDetails, pnlMain);

            void SetupFlightSearch(Trips segment, string tripType)
            {
                if (!FlightDetails.HandleSubmit(segment, tripType))
                {
                    return;
                }

                FlightDetails.Hide();

                var AvailableFlightsDeparture = new FlightBooking_AvailableFlights("Departure");
                var AvailableFlightsReturn = new FlightBooking_AvailableFlights("Return");

                AvailableFlightsDeparture.btnBack.Click += (sender, @event) =>
                {

                    FlightDetails.Show();
                    AvailableFlightsDeparture.Hide();
                };

                AvailableFlightsDeparture.btnContinueAvailableFlights.Click += (sender, @event) =>
                {
                    if (!AvailableFlightsDeparture.SubmitSelectedAirplane()) return;
                    AvailableFlightsDeparture.Hide();
                    if (tripType == "Round Trip") AvailableFlightsReturn.Show();
                    //show next form pwede diff methods
                };

                AddControl(AvailableFlightsDeparture, pnlMain);

                if (tripType == "Round Trip")
                {
                    AvailableFlightsReturn.btnBack.Click += (sender, @event) =>
                    {
                        AvailableFlightsDeparture.Show();
                        AvailableFlightsReturn.Hide();
                    };
                    AvailableFlightsReturn.btnContinueAvailableFlights.Click += (sender, @event) =>
                    {

                        if (!AvailableFlightsReturn.SubmitSelectedAirplane()) return;
                        //AvailableFlightsReturn.Hide();
                        //show next form pwede diff methods
                    };

                    AddControl(AvailableFlightsReturn, pnlMain);
                    AvailableFlightsReturn.Hide();
                }
            }
        }
        private void InitializeSidebar()
        {
            btnDashboard.Click += (sender, e) =>
            {
                SetIndicator(btnDashboard, pnlIndicator1);
                SetHeader("DASHBOARD");
                ClearControls(pnlMain);

            };
            btnFlightBooking.Click += (sender, EventArgs) =>
            {
                SetIndicator(btnFlightBooking, pnlIndicator2);
                SetHeader("FLIGHT BOOKING");
                ClearControls(pnlMain);

                ViewBookings();
            };
            btnViewBookings.Click += (sender, e) =>
            {
                SetIndicator(btnViewBookings, pnlIndicator3);
                SetHeader("VIEW BOOKINGS");
                ClearControls(pnlMain);
                
                var viewBookings = new ViewBookings.ViewBookings();
                AddControl(viewBookings, pnlMain);
                
            };
            btnProfile.Click += (sender, e) =>
            {
                SetIndicator(btnProfile, pnlIndicator4);
                SetHeader("PROFILE");
                ClearControls(pnlMain);

            };
            btnLogin.Click += LoginControl_OpenLoginForm;
            btnLogout.Click += (sender, e) =>
            {
                Session.IsLoggedIn = false;
                Session.CurrentUser = string.Empty;
                UpdateUIBasedOnLoginStatus(Session.IsLoggedIn);
            };
        }

        private void ClearControls(Panel pnl)
        {
            foreach (Control control in pnl.Controls)
            {
                control.Dispose();
            }
            pnl.Controls.Clear();
        }

        private void AddControl(Control control, Panel pnl)
        {
            pnl.AutoSize = true;
            pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl.Controls.Add(control);
            control.BringToFront();
        }

        public void UpdateUIBasedOnLoginStatus(bool isLoggedIn)
        {
            btnLogin.Visible = !isLoggedIn;
            btnLogout.Visible = isLoggedIn;
        }

        // ------ LOGIN NAVIGATION ------
        private void LoginControl_LoginSuccessful(object sender, EventArgs e) // Goes to dashboard after successful login
        {
            Session.IsLoggedIn = true;
            UpdateUIBasedOnLoginStatus(Session.IsLoggedIn);
            SetIndicator(btnDashboard, pnlIndicator1);
            SetHeader("DASHBOARD");
            ClearControls(pnlMain);

            // ---- NOTE: only for example. CHANGE TO DASHBOARD USER CONTROL
            //var viewBookings = new ViewBookings.ViewBookings();
            //AddControl(viewBookings, pnlMain);
        }

        private void LoginControl_OpenSignUpForm(object sender, EventArgs e) // From login form => sign up form
        {
            SetHeader("SIGN UP");
            ClearControls(pnlMain);
            var signup = new SignUp();
            AddControl(signup, pnlMain);

            signup.SignUpSuccessful += LoginControl_LoginSuccessful;
            signup.OpenLoginForm += LoginControl_OpenLoginForm;
        }

        private void LoginControl_OpenLoginForm(object sender, EventArgs e) // From signup form => login form
        {
            ResetButtonColors();
            SetHeader("LOGIN");
            ClearControls(pnlMain);
            var login = new Login();
            AddControl(login, pnlMain);

            login.LoginSuccessful += LoginControl_LoginSuccessful;
            login.OpenSignUpForm += LoginControl_OpenSignUpForm;
            login.OpenForgotPasswordForm += LoginControl_OpenForgotPasswordForm;
        }

        private void LoginControl_OpenForgotPasswordForm(object sender, EventArgs e) // From signup form => login form
        {
            ResetButtonColors();
            SetHeader("LOGIN");
            ClearControls(pnlMain);
            var forgotPassword = new ForgotPassword();
            AddControl(forgotPassword, pnlMain);

            forgotPassword.OpenLoginForm += LoginControl_OpenLoginForm;
        }
    }
}

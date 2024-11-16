using FLIGHT_RESERVATION.ViewBookings;
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


                //var FlightBookingsTwoWay = new FlightBooking_TwoWay();
                //AddControl(FlightBookingsTwoWay, pnlMain);
                //FlightBookingsTwoWay.round_Trip1.btnSearchFlight.Click += (s, e) => 
                //{FlightBookingsTwoWay.Visible = false;
                //    var FlightBookingsAvailableFlights = new FlightBooking_AvailableFlights();
                //    AddControl(FlightBookingsAvailableFlights, pnlMain);

                //    FlightBookingsAvailableFlights.btnBack.Click += (h, q) =>
                //    {
                //        FlightBookingsAvailableFlights.Visible = false;
                //        FlightBookingsTwoWay.Visible = true;
                //    };
                //};

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
            btnLogin.Click += (sender, eventArgs) =>
            {
                SetHeader("LOGIN");
                ClearControls(pnlMain);

                var login = new Login();
                AddControl(login, pnlMain);
                login.LoginSuccessful += LoginControl_LoginSuccessful;
            };
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
        }

        public void UpdateUIBasedOnLoginStatus(bool isLoggedIn)
        {
            btnLogin.Visible = !isLoggedIn;
            btnLogout.Visible = isLoggedIn;
        }

        // ------ NAVIGATION ------
        private void LoginControl_LoginSuccessful(object sender, EventArgs e)
        {
            UpdateUIBasedOnLoginStatus(Session.IsLoggedIn);
            SetIndicator(btnDashboard, pnlIndicator1);
            SetHeader("DASHBOARD");
            ClearControls(pnlMain);

            // ---- NOTE: only for example. CHANGE TO DASHBOARD USER CONTROL
            //var viewBookings = new ViewBookings.ViewBookings();
            //AddControl(viewBookings, pnlMain);
        }
    }
}

using FLIGHT_RESERVATION.ViewBookings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FLIGHT_RESERVATION.Account;
using FLIGHT_RESERVATION.Flight_Booking;
using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_AddOns;
using FLIGHT_RESERVATION.Flight_Booking.FlightBooking_FlightDetails;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails;

namespace FLIGHT_RESERVATION
{
    public partial class MainForm : Form
    {

        ViewBookings.ViewBookings viewBookings = new ViewBookings.ViewBookings();
        FlightBooking_FlightDetails FlightDetails = new FlightBooking_FlightDetails();
        dashboard dashboard = new dashboard();
        SignUp signUp = new SignUp();

        public MainForm()
        {
            InitializeComponent();
            FlightBookings(FlightDetails);

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
            AddControl(dashboard, pnlMain);

            UpdateUIBasedOnLoginStatus(Session.IsLoggedIn);

            AddControl(viewBookings, pnlMain);
            AddControl(FlightDetails, pnlMain);
            viewBookings.Hide();
            FlightDetails.Hide();




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            Button[] btns = { btnDashboard, btnFlightBooking, btnViewBookings, btnAccount, btnLogout, btnLogin };

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


        private void FlightBookings(FlightBooking_FlightDetails FlightDetails)
        {

            FlightDetails.OneWay.btnSearchFlight.Click += (s, e) =>
            {
                SetupFlightSearch(FlightDetails.OneWay, "One Way");
            };

            FlightDetails.RoundTrip.btnSearchFlight.Click += (s, e) =>
            {
                SetupFlightSearch(FlightDetails.RoundTrip, "Round Trip");
            };

            FlightDetails.Show();

            void SetupFlightSearch(Trips segment, string tripType)
            {
                if (!FlightDetails.HandleSubmit(segment, tripType))
                {
                    MessageBox.Show("Please fill up all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    else SetupGuestDetails(AvailableFlightsDeparture);
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
                        AvailableFlightsReturn.Hide();
                        SetupGuestDetails(AvailableFlightsReturn);
                    };

                    AddControl(AvailableFlightsReturn, pnlMain);
                    AvailableFlightsReturn.Hide();
                }
            }

            void SetupGuestDetails(Control PreviousPanel)
            {
                var GuestDetails = new FlightBookings_GuestDetails();
                AddControl(GuestDetails, pnlMain);
               
                GuestDetails.btnBack.Click += (s, e) =>
                {
                    GuestDetails.Dispose();
                    PreviousPanel.Show();
                };
                GuestDetails.btnContinue.Click += (s, e) =>
                {
                    if (!GuestDetails.Validate())
                    {
                        return;
                    }

                    FlightBooking_Session.Instance.setGuestDetails(GuestDetails.guestDetails);
                    GuestDetails.Hide();
                    SetupAddons(GuestDetails);
                };
            }

            void SetupAddons(Control PreviousPanel) 
            {
                var Addons = new FlightBooking_AddOns();
                AddControl(Addons, pnlMain);

                Addons.btnBack.Click += (s, e) =>
                {
                    Addons.Dispose();
                    PreviousPanel.Show();
                };

                Addons.btnContinue.Click += Addons.HandleSubmit;
                Addons.btnContinue.Click += (s, e) => { SetupPayment(Addons); Addons.Hide(); };
               
            }

            void SetupPayment(Control PreviousPanel)
            {
                var Payment = new Payment();

                AddControl(Payment, pnlMain);

                Payment.btnBack.Click += (s, @event) =>
                {
                    Payment.Dispose();
                    PreviousPanel.Show();
                };

                Payment.btnContinue.Click += (s, e) => {

                    if (!Payment.chkTermsAndConditions.Checked)
                    {
                        MessageBox.Show("Please accept terms and conditions", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    SetupPaymentDetails(Payment);
                
                };
            }

            void SetupPaymentDetails(Control PreviousPanel)
            {
                var PaymentDetails = new FlightBooking_PaymentDetails();
                AddControl(PaymentDetails, pnlMain);
                PaymentDetails.btnBack.Click += (s, @event) =>
                {
                    PaymentDetails.Dispose();
                    PreviousPanel.Show();
                };

                PaymentDetails.btnContinue.Click += (s, @event) =>
                {
                    if (!PaymentDetails.ValidateContents()){ return;  }
                    Console.WriteLine(PaymentDetails.GenerateTransactionId());

                    //Inserting to Database
                };
            }
        }
        private void InitializeSidebar()
        {
            btnDashboard.Click += (sender, e) =>
            {
                SetIndicator(btnDashboard, pnlIndicator1);
                SetHeader("DASHBOARD");
                ClearControls(pnlMain);
                AddControl(dashboard, pnlMain);
            };
            btnFlightBooking.Click += (sender, EventArgs) =>
            {
                SetIndicator(btnFlightBooking, pnlIndicator2);
                SetHeader("FLIGHT BOOKING");
                ClearControls(pnlMain);
                AddControl(FlightDetails, pnlMain);
            };
            btnViewBookings.Click += (sender, e) =>
            {
                SetIndicator(btnViewBookings, pnlIndicator3);
                SetHeader("VIEW BOOKINGS");
                ClearControls(pnlMain);
                AddControl(viewBookings, pnlMain);
                
            };
            btnAccount.Click += (sender, e) =>
            {
                SetIndicator(btnAccount, pnlIndicator4);
                SetHeader("ACCOUNT");
                ClearControls(pnlMain);

                if (Session.IsLoggedIn)
                {
                    var account = new AccountSettings();
                    AddControl(account, pnlMain);
                }
                else { LoginControl_OpenLoginForm(this, EventArgs.Empty); }
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
                control.Hide();
            }
        }

        private void AddControl(Control control, Panel pnl)
        {
            if (!pnl.Contains(control))
            {
                pnl.AutoSize = true;
                pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                pnl.Controls.Add(control);
                control.BringToFront();
                return;
            }
            control.Show();
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
            AddControl(dashboard, pnlMain);
        }

        private void LoginControl_OpenSignUpForm(object sender, EventArgs e) // From login form => sign up form
        {
            SetHeader("SIGN UP");
            ClearControls(pnlMain);
            AddControl(signUp, pnlMain);

            signUp.SignUpSuccessful += LoginControl_LoginSuccessful;
            signUp.OpenLoginForm += LoginControl_OpenLoginForm;
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
            ClearControls(pnlMain);
            var forgotPassword = new ForgotPassword();
            AddControl(forgotPassword, pnlMain);

            forgotPassword.OpenLoginForm += LoginControl_OpenLoginForm;
        }

        
    }
}

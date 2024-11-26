using FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_;
using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_PaymentDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLIGHT_RESERVATION.Flight_Booking
{
    public partial class FlightBooking_PaymentDetails : UserControl
    {

        String type { get; set; } = "Card";
        CardDetails cardDetails = new CardDetails();
        GCash gcash = new GCash();
        Dictionary<String, String> CardDetails = new Dictionary<String, String>();



        public FlightBooking_PaymentDetails()
        {
            InitializeComponent();
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            if (type == "Card")
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.GCash_button;
                type = "GCash";
                cardDetails.Hide();
                gcash.Show();
            }
            else
            {
                btnChangeType.Image = global::FLIGHT_RESERVATION.Properties.Resources.Card_button;
                type = "Card";
                cardDetails.Show();
                gcash.Hide();
            }
        }

        private void FlightBooking_PaymentDetails_Load(object sender, EventArgs e)
        {
            cardDetails.AutoSize = true;
            cardDetails.Location = new Point(0, 0);
            gcash.AutoSize = true;
            gcash.Location = new Point(0, 0);
            pnlPaymentDetails.Controls.Add(cardDetails);
            pnlPaymentDetails.Controls.Add(gcash);
            gcash.Hide();
        }



        public string GenerateTransactionId()
        {
            string prefix = "ATS";

            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999); 

            return $"{prefix}{randomNumber}";
        }

        new Validator Validate = new Validator();

        public bool ValidateContents()
        {
            if (type == "Card") {
                return ValidateInput();
            }
            else if (type == "GCash")
            {
                return Validate.isReferenceNumberValid(gcash.txtReferenceNumber.Text);
            } 

            return false;

        }

        public void FillData()
        {
            CardDetails["First Name"] = cardDetails.txtFirstName.Text;
            CardDetails["Last Name"] = cardDetails.txtLastName.Text;
            CardDetails["Card Number"] = cardDetails.txtCardNumber.Text;
            CardDetails["CVV"] = cardDetails.txtCVV.Text;
            CardDetails["Expiry Date"] = cardDetails.txtExpiryDate.Text;
            CardDetails["Street Address"] = cardDetails.txtStreetAddress.Text;
            CardDetails["City/Town"] = cardDetails.txtCity.Text;
            CardDetails["Country"] = cardDetails.txtCountry.Text;
            CardDetails["Zip Code"] = cardDetails.txtZipCode.Text;
            FlightBooking_Session.Instance.setCardDetails(CardDetails);
        }

        public bool ValidateInput()
        {


            foreach (var ctr in cardDetails.Controls.OfType<CustomControls.RoundedTextBox>().ToArray())
            {
                if (String.IsNullOrWhiteSpace(ctr.Text))
                {
                    MessageBox.Show($"Fill Up All Fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (!Validate.IsValidCreditCard(cardDetails.txtCardNumber.Text)){ return false;}
            if (!Validate.isCVVValid(cardDetails.txtCVV.Text)){return false;}
            if (!Validate.isExpiryDateValid(cardDetails.txtExpiryDate.Text)){return false; }
            if (!Validate.isZipCodeValid(cardDetails.txtZipCode.Text)){return false; }
            if(!Validate.isCreditCardNotExpired(cardDetails.txtExpiryDate.Text)) { return false; }
            return true;
        }
    }

    class Validator
    {
        public bool isReferenceNumberValid(String ReferenceNumber)
        {
            if (!Regex.IsMatch(ReferenceNumber, @"^\d+$"))
            {
                MessageBox.Show("Reference number must be Numeric", "Reference number invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ReferenceNumber.Length != 13)
            {
                MessageBox.Show("Reference number must be 13 digits long", "Reference number invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(ReferenceNumber))
            {
                MessageBox.Show("Fill up all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool isCreditCardNotExpired(String expiryDate)
        {
            DateTime.TryParseExact(expiryDate, "MMMM yyyy",
             System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None,
            out DateTime ExpiryDate);
                
                DateTime CurrentDate = DateTime.Now;

            if(ExpiryDate < CurrentDate)
            {
                return false;
            }

            return true;

        }
        public bool isZipCodeValid(string ZipCode)
        {
            if (!Regex.IsMatch(ZipCode, @"^\d+$"))
            {
                MessageBox.Show("Zip code must be", "Zip code is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool isExpiryDateValid(string ExpiryDate)
        {
            if (DateTime.TryParseExact(ExpiryDate, "MMMM yyyy",
             System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None,
            out DateTime expiryDate))
            {
                return true;
            }

            MessageBox.Show("Invalid Expiry Date format must be MM YYYY \n Ex. January 2030", "Expiry Date Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
        public bool isCVVValid(string CVV)
        {
            if (!Regex.IsMatch(CVV, @"^\d+$"))
            {
                MessageBox.Show("CVV must be Numeric", "CVV Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CVV.Length != 4 && CVV.Length != 3)
            {
                Console.WriteLine(CVV);
                MessageBox.Show("CVV must be 3 - 4 digits only", "CVV Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool IsValidCreditCard(string cardNumber)
        {
            // Remove spaces or hyphens
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            // Regex to ensure the format is digits only and 13-19 characters long
            if (!Regex.IsMatch(cardNumber, @"^\d{13,19}$"))
            {
                MessageBox.Show("Card Number must be 13-19 characters long", "Card Number Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return LuhnCheck(cardNumber);
        }
        private static bool LuhnCheck(string number)
        {
            int sum = 0;
            bool doubleDigit = false;

            // Process each digit starting from the right
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9) digit -= 9;
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }

            if (sum % 10 == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Card Number", "Card Number Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

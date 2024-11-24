using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace FLIGHT_RESERVATION.Flight_Booking.FlightBookings__CardDetails_
{
    public partial class CardDetails : UserControl
    {

        public CardDetails()
        {
            InitializeComponent();
        }

        Validator Validate = new Validator();

        public bool ValidateInput()
        {
            foreach (Control ctr in this.Controls.OfType<CustomControls.RoundedTextBox>().ToList())
            {
                if (ctr.Text.Length == 0)
                {
                    MessageBox.Show("Fill Up All Fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; 
                }
            }

            if (!Validate.IsValidCreditCard(txtCardNumber.Text))
            {
                return false;
            }

            if (!Validate.isCVVValid(txtCVV.Text))
            {
                return false;
            }

            if (!Validate.isExpiryDateValid(txtExpiryDate.Text))
            {
                return false;
            }

            return true;
        }


    }

    class Validator
    {

        public bool isExpiryDateValid(string ExpiryDate)
        {
            if (DateTime.TryParseExact(ExpiryDate, "MM yyyy",
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

            if(CVV.Length != 4 || CVV.Length != 3)
            {
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

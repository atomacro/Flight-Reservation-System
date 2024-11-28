using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.Account
{
    public partial class AccountSettings : UserControl
    {
        public AccountSettings()
        {
            InitializeComponent();
            txtCurrentPassword.Enabled = false;
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            Session session = new Session();
            User user = session.GetAccountInfo();

            if (user == null)
            {
                MessageBox.Show("Error with the account information.","Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                txtFName.Text = user.FirstName;
                txtLName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtCurrentPassword.Text = user.Password;
                txtCurrentPassword.IsPassword = true;
                txtNewPassword.IsPassword = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // TRY: save null textboxes

            string email = txtEmail.Text;
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string password = txtNewPassword.Text;

            if (isValidInfo(email, password))
            {
                Session session = new Session();
                //session.UpdateAccountInfo
            }

        }

        private bool isValidInfo(string email, string password)
        {

            StringBuilder errors = new StringBuilder();

            if (!Validation.IsValidEmail(email))
            {
                errors.AppendLine("Please enter a valid email.");
            }

            if (!Validation.IsValidPassword(password))
            {
                errors.AppendLine("Password must be at least 8 characters.");
            }

            string errorMessage = errors.ToString();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Account Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnHidePassword1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = true;
            btnShowPassword1.Visible = true;
            btnHidePassword1.Visible = false;
        }

        private void btnHidePassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = true;
            btnShowPassword2.Visible = true;
            btnHidePassword2.Visible = false;
        }

        private void btnShowPassword1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = false;
            btnHidePassword1.Visible = true;
            btnShowPassword1.Visible = false;
        }

        private void btnShowPassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = false;
            btnHidePassword2.Visible = true;
            btnShowPassword2.Visible = false;
        }
    }
}

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
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            Session session = new Session();
            User user = session.GetAccountInfo();

            if (user == null)
            {
                MessageBox.Show("Error with loading the account information.","Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                txtFName.Text = user.FirstName;
                txtLName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtCurrentPassword.IsPassword = true;
                txtCurrentPassword.Text = user.Password;
                txtCurrentPassword.Enabled = false;
                txtNewPassword.IsPassword = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            User user = session.GetAccountInfo();

            string email = txtEmail.Text;
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string password = txtNewPassword.Text;

            bool hasChanges = firstName != user.FirstName || lastName != user.LastName || email != user.Email ||
                              (password != user.Password && !string.IsNullOrWhiteSpace(password));

            if (!hasChanges)
            {
                MessageBox.Show("No changes to save.","Account Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isValidInfo(email, password))
            {
                bool updateSuccess = session.UpdateAccountInfo(firstName, lastName, email, password);

                if (updateSuccess)
                {
                    MessageBox.Show("Account information updated successfully!", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.None);
                    user.Password = password;
                    txtCurrentPassword.Text = user.Password;
                }
                else
                {
                    MessageBox.Show("Failed to update account information. Please try again.", "Account Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool isValidInfo(string email, string password)
        {

            StringBuilder errors = new StringBuilder();

            if (Validation.IsTextboxEmpty(txtEmail) || Validation.IsTextboxEmpty(txtFName) ||
                Validation.IsTextboxEmpty(txtLName))
            {
                errors.AppendLine("Name and email cannot be blank.");
            }

            if (!Validation.IsValidEmail(email))
            {
                errors.AppendLine("Please enter a valid email.");
            }

            if (!Validation.IsValidPassword(password) && !string.IsNullOrWhiteSpace(password))
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
            btnFocus.Focus();
        }

        private void btnHidePassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = true;
            btnShowPassword2.Visible = true;
            btnHidePassword2.Visible = false;
            btnFocus.Focus();

        }

        private void btnShowPassword1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = false;
            btnHidePassword1.Visible = true;
            btnShowPassword1.Visible = false;
            btnFocus.Focus();

        }

        private void btnShowPassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = false;
            btnHidePassword2.Visible = true;
            btnShowPassword2.Visible = false;
            btnFocus.Focus();


        }
    }
}

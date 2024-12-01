using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public partial class SignUp : UserControl
    {
        public event EventHandler SignUpSuccessful;
        public event EventHandler OpenLoginForm;

        public SignUp()
        {
            InitializeComponent();
            txtPassword.IsPassword = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Session session = new Session();

            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            bool validUserInfo = ValidateRegistration(firstName, lastName, email, password);

            if (validUserInfo)
            {
                User user = new User(firstName, lastName, email, password);
                bool registrationSuccess = session.RegisterUser(user);

                if (registrationSuccess)
                {
                    SignUpSuccessful?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show($"This email address is already registered.",
                        "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ----- UI and Navigation Related
        private void lblLogin_Click(object sender, EventArgs e)
        {
            OpenLoginForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
            txtPassword.Focus();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = false;
            btnHidePassword.Visible = true;
            btnShowPassword.Visible = false;
            txtPassword.Focus();
        }

        public static bool ValidateRegistration(string firstName, string lastName, string email, string password)
        {
            using (StringWriter writer = new StringWriter())
            {
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    writer.WriteLine("Fields cannot be empty.");
                }

                if (!Validation.IsValidEmail(email))
                {
                    writer.WriteLine("Please enter a valid email.");
                }

                if (!Validation.IsValidPassword(password))
                {
                    writer.WriteLine("Password must be at least 8 characters.");
                }

                string errorMessage = writer.ToString();

                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                return true;
            }
        }
    }
}

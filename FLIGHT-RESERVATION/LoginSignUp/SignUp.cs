using System;
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
    public partial class SignUp : UserControl
    {
        public event EventHandler SignUpSuccessful;
        public event EventHandler OpenLoginForm;

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();
            
            bool validUserInfo =
                user.ValidateRegistration(txtFName.Text, txtLName.Text, txtEmail.Text, txtPassword.Text);

            if (validUserInfo)
            {
                Session session = new Session();
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
    }
}

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
    public partial class Login : UserControl
    {
        public event EventHandler LoginSuccessful;
        public event EventHandler OpenSignUpForm;
        public EventHandler OpenForgotPasswordForm;
        private string _email;
        private string _password;
        Session Session = new Session();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _email = txtEmail.Text;
            _password = txtPassword.Text;
            if (!Validation.IsValidEmail(_email))
            {
                MessageBox.Show("Please enter a valid email.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            bool userIsAuthenticated = Session.AuthenticateUser(_email, _password);
            if (userIsAuthenticated)
            {
                MessageBox.Show("Login Successful!");
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----- UI and Navigation Related
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

        private void lblSignup_Click(object sender, EventArgs e)
        {
            OpenSignUpForm?.Invoke(this, EventArgs.Empty);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            OpenForgotPasswordForm?.Invoke(this,EventArgs.Empty);
        }
    }
}

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
            if (!Session.IsValidEmail(_email))
            {
                MessageBox.Show("Please enter a valid email.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            bool userIsAuthenticated = Session.AuthenticateUser(_email, _password);
            if (userIsAuthenticated)
            {
                Session.IsLoggedIn = true;
                MessageBox.Show("Login Successful!");
                LoginSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
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

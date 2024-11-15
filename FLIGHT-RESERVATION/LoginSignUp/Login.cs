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
        private string _email;
        private string _password;
        Session Session = new Session();

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isAuthenticated = Session.AuthenticateUser(txtEmail.Text, txtPassword.Text);

            if (isAuthenticated)
            {
                Session.IsLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblSignup_Click(object sender, EventArgs e)
        {

        }
    }
}

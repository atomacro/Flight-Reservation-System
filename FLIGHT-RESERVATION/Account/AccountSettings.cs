using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MessageBox.Show("Error with the account information.","Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                txtFName.PlaceholderText = user.FirstName;
                txtLName.PlaceholderText = user.LastName;
                txtEmail.PlaceholderText = user.Email;
                txtCurrentPassword.PlaceholderText = user.Password;
            }
        }

        private void btnHidePassword1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = true;
            btnShowPassword1.Visible = true;
            btnHidePassword1.Visible = false;
            txtCurrentPassword.Focus();
        }

        private void btnHidePassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = true;
            btnShowPassword2.Visible = true;
            btnHidePassword2.Visible = false;
            txtNewPassword.Focus();
        }

        private void btnShowPassword1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = false;
            btnHidePassword1.Visible = true;
            btnShowPassword1.Visible = false;
            txtCurrentPassword.Focus();
        }

        private void btnShowPassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = false;
            btnHidePassword2.Visible = true;
            btnShowPassword2.Visible = false;
            txtNewPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

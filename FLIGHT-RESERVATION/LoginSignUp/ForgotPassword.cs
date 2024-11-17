using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FLIGHT_RESERVATION
{
    public partial class ForgotPassword : UserControl
    {
        public EventHandler OpenLoginForm;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Session session = new Session();

            using (StringWriter writer = new StringWriter())
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    writer.WriteLine("Please enter both email and password.");
                }

                if (!Validation.IsValidPassword(txtPassword.Text))
                {
                    writer.WriteLine("Password must be at least 8 characters long.");
                }

                if (!session.IsEmailInDatabase(txtEmail.Text))
                {
                    writer.WriteLine("Email address not found.");
                }

                string errorMessage = writer.ToString();
                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage, "Change Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bool changePasswordSuccess = session.ChangePassword(txtEmail.Text, txtPassword.Text);
            
            if (changePasswordSuccess)
            {
                MessageBox.Show("Password changed successfully.", "Change Password", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                OpenLoginForm?.Invoke(this, EventArgs.Empty);
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

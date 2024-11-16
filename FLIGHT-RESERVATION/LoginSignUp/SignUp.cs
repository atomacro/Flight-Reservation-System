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

        private void lblLogin_Click(object sender, EventArgs e)
        {
            OpenLoginForm?.Invoke(this, EventArgs.Empty);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            User user = new User();
            string userValidationMessage =
                user.ValidateRegistration(txtFName.Text, txtLName.Text, txtEmail.Text, txtPassword.Text);

            if (string.IsNullOrWhiteSpace(userValidationMessage))
            {
                SignUpSuccessful?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(userValidationMessage, "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

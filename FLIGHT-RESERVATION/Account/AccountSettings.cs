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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            Session session = new Session();
            User user = session.GetAccountInfo();

            if (user == null)
            {
                MessageBox.Show("hala");

            }
            else
            {
                txtFName.Text = user.FirstName;
                txtLName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtCurrentPassword.Text = user.Password;
            }
        }
    }
}

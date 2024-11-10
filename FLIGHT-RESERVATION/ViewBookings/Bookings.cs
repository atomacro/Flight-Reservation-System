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
    public partial class Bookings : UserControl
    {
        public Bookings()
        {
            InitializeComponent();
            Fonts fonts = new Fonts();
            lblDate.Font = fonts.KantumruyProMedium(20.0F);
            lblLocation1.Font = fonts.KantumruyProBold(28.0F);
            lblLocation2.Font = fonts.KantumruyProBold(28.0F);
            lblTime1.Font = fonts.KantumruyProRegular(15.0F);
            lblTime2.Font = fonts.KantumruyProRegular(15.0F);

        }
        public void SetDate(string date)
        {
            lblDate.Text = date;
        }
        public void setLocation(string location1, string location2)
        {
            lblLocation1.Text = location1;
            lblLocation2.Text = location2;
        }

        public void setTime(string time1, string time2)
        {
            lblTime1.Text = time1;
            lblTime2.Text = time2;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTime1_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation2_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {

        }

        private void lblLocation1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTime2_Click(object sender, EventArgs e)
        {

        }
    }
}


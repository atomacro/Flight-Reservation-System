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
            Fonts fonts = new Fonts();
            InitializeComponent();
            lblDate.Font = fonts.KantumruyProMedium(15.0F);
            lblLocation1.Font = fonts.KantumruyProBold(25.0F);
            lblLocation2.Font = fonts.KantumruyProBold(25.0F);
            lblTime1.Font = fonts.KantumruyProRegular(12.0F);
            lblTime2.Font = fonts.KantumruyProRegular(12.0F);
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

    }
}


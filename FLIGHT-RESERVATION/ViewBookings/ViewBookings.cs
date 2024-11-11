using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION.ViewBookings
{
    public partial class ViewBookings : UserControl
    {
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {


            String[] Location1 = { "MNL", "BCD", "SIN", "BCL"};
            String[] Location2 = { "BCD", "SIN", "MNL", "THA" };
            String[] Date = { "November 09, 2024", "November 10, 2024", "November 11, 2024", "November 12, 2024" };
            String[] Time1 = { "13:34", "10:30", "05:17", "10:30" };
            String[] Time2 = { "07:45", "18:40", "15:30", "16:30" };



            for (int i = 0; i < 4; i++)
            {
                Bookings bookings = new Bookings();
                //bookings.BackgroundImageLayout = ImageLayout.Stretch;
                //bookings.Size = new System.Drawing.Size(699, 180);
                bookings.Margin = new Padding(0, 0, 0, 10);
                bookings.SetDate(Date[i]);
                bookings.setLocation(Location1[i], Location2[i]);
                bookings.setTime(Time1[i], Time2[i]);
                pnlBookings.Controls.Add(bookings);
                
            }
        }

    }
}

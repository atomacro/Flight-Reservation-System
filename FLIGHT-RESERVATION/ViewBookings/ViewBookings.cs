using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            String[] Location1 = { "MNL", "BCD", "SIN" };
            String[] Location2 = { "BCD", "SIN", "MNL" };
            String[] Date = { "November 09, 2024", "November 10, 2024", "November 11, 2024" };
            String[] Time1 = { "13:34", "10:30", "05:17" };
            String[] Time2 = { "07:45", "18:40", "15:30" };


            for (int i = 0; i < 3; i++)
            {
                Bookings bookings = new Bookings();
                bookings.Name = "b";
                bookings.AutoSize = true;
                bookings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                bookings.SetDate(Date[i]);
                bookings.setLocation(Location1[i], Location2[i]);
                bookings.setTime(Time1[i], Time2[i]);
                pnlBookings.Controls.Add(bookings);
            }
        }

        private void pnlBookings_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

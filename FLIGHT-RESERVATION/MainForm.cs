using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace FLIGHT_RESERVATION
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        private Font KantumruyProBold()
        {
            byte[] fontData = Properties.Resources.KantumruyPro_Bold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.KantumruyPro_Bold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.KantumruyPro_Bold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], 35.0F);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            String formColor = "#E6E9F0";
            this.BackColor = ColorTranslator.FromHtml(formColor);
            Header.BackColor = Color.White;
            SetButtonBorders();
            InitializeSidebar();
            SetHeader("DASHBOARD");
            SetIndicator(btnDashboard, pnlIndicator1);
        }

        public void SetIndicator(Button activeButton, Panel pnlIndicator)
        {
            ResetButtonColors();
            pnlIndicator.BackColor = ColorTranslator.FromHtml("#A780F4");
            activeButton.BackColor = ColorTranslator.FromHtml("#F4F3FF");
        }


        public void SetHeader(string PageName)
        {
            lblPageName.Text = PageName;
            lblPageName.ForeColor = ColorTranslator.FromHtml("#5C5C5C");
            lblPageName.Font = KantumruyProBold();
        }

        public void SetButtonBorders()
        {
            Button[] btns = { btnDashboard, btnFlightBooking, btnViewBookings, btnProfile, btnLogout };

            foreach (Button btn in btns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
            }

            Panel[] panels = { pnlIndicator1, pnlIndicator2, pnlIndicator3, pnlIndicator4 };
            foreach (Panel pnl in panels)
            {
                pnl.BackColor = Color.White;
            }
        }

        public void ResetButtonColors()
        {
            foreach (Control control in this.Controls)
            {
                switch (control)
                {
                    case Button btn:
                        btn.BackColor = Color.White;
                        break;
                    case Panel pnl:
                        pnl.BackColor = Color.White;
                        break;
                }
            }
        }

        private void InitializeSidebar()
        {
            btnDashboard.Click += (sender, e) =>
            {
                SetIndicator(btnDashboard, pnlIndicator1);
                SetHeader("DASHBOARD");
            };
            btnFlightBooking.Click += (sender, e) =>
            {
                SetIndicator(btnFlightBooking, pnlIndicator2);
                SetHeader("FLIGHT BOOKING");
            };
            btnViewBookings.Click += (sender, e) =>
            {
                SetIndicator(btnViewBookings, pnlIndicator3);
                SetHeader("VIEW BOOKINGS");
            };
            btnProfile.Click += (sender, e) =>
            {
                SetIndicator(btnProfile, pnlIndicator4);
                SetHeader("PROFILE");
            };
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}

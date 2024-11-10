using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLIGHT_RESERVATION
{
    internal class Fonts
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();



        public Font KantumruyProBold()
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

        public Font KantumruyProMedium()
        {
            byte[] fontData = Properties.Resources.KantumruyPro_Medium;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.KantumruyPro_Medium.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.KantumruyPro_Medium.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[1], 35.0F);
        }

        public Font KantumruyProRegular()
        {
            byte[] fontData = Properties.Resources.KantumruyPro_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.KantumruyPro_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.KantumruyPro_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[2], 35.0F);
        }

        public Font KantumruyProSemiBold()
        {
            byte[] fontData = Properties.Resources.KantumruyPro_SemiBold;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.KantumruyPro_SemiBold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.KantumruyPro_SemiBold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[3], 35.0F);
        }
    }
}

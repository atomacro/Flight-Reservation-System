using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLIGHT_RESERVATION
{
    using System;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Runtime.InteropServices;

    namespace FLIGHT_RESERVATION
    {
        internal class Fonts
        {
            [DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

            public Font KantumruyProBold(float size)
            {
                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = Properties.Resources.KantumruyPro_Bold;
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontData.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);

                return new Font(fonts.Families[0], size);
            }

            public Font KantumruyProMedium(float size)
            {
                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = Properties.Resources.KantumruyPro_Medium;
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontData.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);

                return new Font(fonts.Families[0], size);
            }

            public Font KantumruyProRegular(float size)
            {
                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = Properties.Resources.KantumruyPro_Regular;
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontData.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);

                return new Font(fonts.Families[0], size);
            }
            public Font KantumruyProSemiBold(float size)
            {
                PrivateFontCollection fonts = new PrivateFontCollection();
                byte[] fontData = Properties.Resources.KantumruyPro_SemiBold;
                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontData.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);

                return new Font(fonts.Families[0], size);
            }
        }
    }

}

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

        public PrivateFontCollection fontCollection = new PrivateFontCollection();

        private Font LoadFont(byte[] fontData, int size)
        {

                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                uint dummy = 0;
                fontCollection.AddMemoryFont(fontPtr, fontData.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
                Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fontCollection.Families[fontCollection.Families.Length - 1], size);        
        }

        public Font KantumruyProBold(int size)
        {
            return LoadFont(Properties.Resources.KantumruyPro_SemiBold, size);
        }

        public Font KantumruyProMedium(int size)
        {
            return LoadFont(Properties.Resources.KantumruyPro_Medium, size);
        }

        public Font KantumruyProRegular(int size)
        {
            return LoadFont(Properties.Resources.KantumruyPro_Regular, size);
        }

        public Font KantumruyProSemiBold(int size)
        {
            return LoadFont(Properties.Resources.KantumruyPro_SemiBold, size);
        }
    }
}

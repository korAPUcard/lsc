using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LifeSupportCalculator
{
    public class FontLibrary
    {
        private static FontLibrary inst = new FontLibrary();
        public PrivateFontCollection privateFont = new PrivateFontCollection();
        public static FontFamily[] Families
        {
            get
            {
                return inst.privateFont.Families;
            }
        }

        public FontLibrary()
        {
            AddFontFromMemory();
        }

        private void AddFontFromMemory()
        {
            List<byte[]> fonts = new List<byte[]>();
            fonts.Add(Properties.Resources.NOTO_SANS);// Index[0]
            fonts.Add(Properties.Resources.NOTO_SANS_ITALIC);
            fonts.Add(Properties.Resources.NOTO_SANS_KR);
            fonts.Add(Properties.Resources.NOTO_SANS_JP);
            fonts.Add(Properties.Resources.ORBITRON);

            foreach (byte[] font in fonts)
            {
                IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
                Marshal.Copy(font, 0, fontBuffer, font.Length);
                privateFont.AddMemoryFont(fontBuffer, font.Length);
            }
        }

    }
}

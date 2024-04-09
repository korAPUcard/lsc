using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace LifeSupportCalculator
{
    class FontManager
    {
        private static FontManager instance = new FontManager();
        public PrivateFontCollection privateFont = new PrivateFontCollection();
        public static FontFamily[] fontFamilys
        {
            get
            {
                return instance.privateFont.Families;
            }
        }

        public FontManager()
        {
            AddFontFromMemory();
        }

        private void AddFontFromMemory()
        {
            List<byte[]> fonts = new List<byte[]>();
            fonts.Add(Properties.Resources.NOTO_SANS);
            fonts.Add(Properties.Resources.NOTO_SANS_ITALIC);
            fonts.Add(Properties.Resources.NOTO_SANS_KR);
            fonts.Add(Properties.Resources.ORBITRON);

            foreach (byte[] font in fonts)
            {
                IntPtr fontBuffer = Marshal.AllocCoTaskMem(font.Length);
                Marshal.Copy(font, 0, fontBuffer, font.Length);
                privateFont.AddMemoryFont(fontBuffer, font.Length);

                Marshal.FreeHGlobal(fontBuffer);//메모리 해제
            }
        }
    }
}

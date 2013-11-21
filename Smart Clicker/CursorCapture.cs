using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Smart_Clicker
{
    public class CursorCapture
    {
        public static Bitmap[] clickAndDragBitmaps;
        public Dictionary<Byte[], Boolean> clickAndDragDictionary;

        public CursorCapture()
        {
            clickAndDragDictionary = new Dictionary<Byte[], Boolean>();

            Bitmap sizeAllCursor = BitmapFromCursor(Cursors.SizeAll);
            Bitmap sizeNESW = BitmapFromCursor(Cursors.SizeNESW);
            Bitmap sizeNS = BitmapFromCursor(Cursors.SizeNS);
            Bitmap sizeNWSE = BitmapFromCursor(Cursors.SizeNWSE);
            Bitmap sizeWE = BitmapFromCursor(Cursors.SizeWE);

            clickAndDragBitmaps = new Bitmap[5] { sizeAllCursor, sizeNESW, sizeNS, sizeNWSE, sizeWE };
        }

        private Bitmap BitmapFromCursor(Cursor cur)
        {
            Win32Stuff.ICONINFO ii;
            Win32Stuff.GetIconInfo(cur.Handle, out ii);

            Bitmap bmp = Bitmap.FromHbitmap(ii.hbmColor);
            Win32Stuff.DeleteObject(ii.hbmColor);
            Win32Stuff.DeleteObject(ii.hbmMask);

            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
            Bitmap dstBitmap = new Bitmap(bmData.Width, bmData.Height, bmData.Stride, PixelFormat.Format32bppArgb, bmData.Scan0);
            bmp.UnlockBits(bmData);

            return new Bitmap(dstBitmap);
        }

        public bool IsClickAndDrag(Bitmap currentMouse)
        {
            // Go through each known cursor in clickAndDrag
            foreach (Bitmap cursor in clickAndDragBitmaps)
            {
                // if bitmaps are close
                if (CompareCursorBitmaps(cursor, currentMouse))
                {
                    return true;
                }
            }
            return false;
        }

        /*************************************************************************
        * method for retrieving the current bitmap of the global cursor
        **************************************************************************/
        public static cursorInTime CaptureCursor()
        {
            Bitmap bmp;
            IntPtr hicon;
            Win32Stuff.CURSORINFO ci = new Win32Stuff.CURSORINFO();
            Win32Stuff.ICONINFO icInfo;
            ci.cbSize = Marshal.SizeOf(ci);
            try
            {
                if (Win32Stuff.GetCursorInfo(out ci))
                {
                    if (ci.flags == Win32Stuff.CURSOR_SHOWING)
                    {
                        hicon = Win32Stuff.CopyIcon(ci.hCursor);
                        Win32Stuff.GetIconInfo(hicon, out icInfo);
                        while (icInfo.hbmMask == IntPtr.Zero)
                        {
                            Win32Stuff.GetIconInfo(hicon, out icInfo);
                            System.Diagnostics.Debug.Print("Retrying cursor capture.");
                        }
                        int x = ci.ptScreenPos.x - ((int)icInfo.xHotspot);
                        int y = ci.ptScreenPos.y - ((int)icInfo.yHotspot);
                        using (Bitmap maskBitmap = Bitmap.FromHbitmap(icInfo.hbmMask))
                        {
                            // Is this a monochrome cursor?
                            // This portion taken from http://stackoverflow.com/questions/918990/c-sharp-capturing-the-mouse-cursor-image
                            if (maskBitmap.Height == maskBitmap.Width * 2)
                            {
                                // Reverting to simple saving and no cleanup because of an object leak
                                Rectangle sourceRectangle = new Rectangle(0, 0, maskBitmap.Width, maskBitmap.Height / 2);

                                Bitmap secondBitmap = maskBitmap.Clone(sourceRectangle, PixelFormat.DontCare);
                                
                                bmp = secondBitmap;
                            }
                            else
                            {
                                Icon ic = Icon.FromHandle(hicon);
                                bmp = ic.ToBitmap();
                                Win32Stuff.DestroyIcon(ic.Handle);
                            }
                        }
                        Win32Stuff.DeleteObject(hicon);
                        Win32Stuff.DeleteObject(icInfo.hbmColor);
                        Win32Stuff.DeleteObject(icInfo.hbmMask);
                        Win32Stuff.DeleteObject(ci.hCursor);
                        return new cursorInTime(x, y, bmp);
                    }
                }
            }
            catch (ExternalException e)
            {
                System.Diagnostics.Debug.Print(e.ToString());
            }
            return null;
        }

        public bool CompareCursorBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            int totalPixelCount = bmp1.Height*bmp1.Width;
            int pixelMatchCount = 0;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    if (bmp1.GetPixel(i,j).Equals(bmp2.GetPixel(i,j)))
                    {
                        pixelMatchCount++;
                    }
                }
            }

            double proportion = (double) pixelMatchCount / (double) totalPixelCount;

            if (proportion > 0.9)
            {
                return true;
            }

            return false;
        }
 
    }
}

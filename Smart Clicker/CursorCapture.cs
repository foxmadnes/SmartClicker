using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace Smart_Clicker
{
    // Low level interface to capture cursor images and location, as well as compare bitmaps
    public class CursorCapture
    {
        public static Bitmap[] clickAndDragBitmaps;
        public Dictionary<Byte[], Boolean> clickAndDragDictionary;
        private static double EQUALITY_PERCENTAGE = 0.9;

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

        // Used for system resize cursors, on application startup
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

        // Method for retrieving the current bitmap of the global cursor
        public static cursorInTime CaptureCursor()
        {
            Bitmap bmp;
            Win32Stuff.CURSORINFO ci = new Win32Stuff.CURSORINFO();
            Win32Stuff.ICONINFO icInfo;
            ci.cbSize = Marshal.SizeOf(ci);
            try
            {
                if (Win32Stuff.GetCursorInfo(out ci))
                {
                    if (ci.flags == Win32Stuff.CURSOR_SHOWING)
                    {
                        Win32Stuff.GetIconInfo(ci.hCursor, out icInfo);

                        // If fetch failed, something wrong with current cursor, give up
                        if (icInfo.hbmMask == IntPtr.Zero)
                        {
                            Win32Stuff.DeleteObject(icInfo.hbmColor);
                            Win32Stuff.DeleteObject(icInfo.hbmMask);
                            Win32Stuff.DeleteObject(ci.hCursor);
                            return null;
                        }

                        int x = ci.ptScreenPos.x - ((int)icInfo.xHotspot);
                        int y = ci.ptScreenPos.y - ((int)icInfo.yHotspot);

                        using (Bitmap maskBitmap = Bitmap.FromHbitmap(icInfo.hbmMask))
                        {
                            // Is this a monochrome cursor?
                            if (maskBitmap.Height == maskBitmap.Width * 2)
                            {
                                bmp = maskBitmap.Clone(new Rectangle(0, 0, maskBitmap.Width, maskBitmap.Height / 2), PixelFormat.DontCare);
                            }
                            else
                            {
                                Icon ic = Icon.FromHandle(ci.hCursor);
                                bmp = ic.ToBitmap();
                                Win32Stuff.DestroyIcon(ic.Handle);
                                ic.Dispose();
                            }
                            maskBitmap.Dispose();
                        }
                        Win32Stuff.DeleteObject(icInfo.hbmColor);
                        Win32Stuff.DeleteObject(icInfo.hbmMask);
                        Win32Stuff.DestroyIcon(ci.hCursor);
                        return new cursorInTime(x, y, bmp);
                    }
                }
            }
            // GDI+ Had a bad day getting the cursor, API says ignore and try again
            catch (ExternalException e)
            {
                System.Diagnostics.Debug.Print(e.ToString());
                using (StreamWriter w = File.AppendText("Cursor-Bug-External-Exception-Log.txt"))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                    w.WriteLine("  :");
                    w.WriteLine("  :{0}", e.ToString());
                    w.WriteLine("-------------------------------");
                }
            }
            //Invalid cursor information! The cursor is likely blank.
            catch (ArgumentException e)
            {
                System.Diagnostics.Debug.Print(e.ToString());
                using (StreamWriter w = File.AppendText("Cursor-Bug-Argument-Exception-Log.txt"))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                    w.WriteLine("  :");
                    w.WriteLine("  :{0}", e.ToString());
                    w.WriteLine("-------------------------------");
                }
            }
            return null;
        }

        #region BitmapComparison

        // Compare a bitmap with known resize cursors
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

        // Bit by bit comparison of two bitmaps to check if they are similar
        // Necessary due to dynamic shadowing and smoothing in Windows Cursors
        public bool CompareCursorBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1.Height != bmp2.Height || bmp1.Width != bmp2.Width)
            {
                return false;
            }

            int totalPixelCount = bmp1.Height * bmp1.Width;
            int pixelMatchCount = 0;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    if (bmp1.GetPixel(i, j).Equals(bmp2.GetPixel(i, j)))
                    {
                        pixelMatchCount++;
                    }
                }
            }

            double proportion = (double)pixelMatchCount / (double)totalPixelCount;

            if (proportion > EQUALITY_PERCENTAGE)
            {
                return true;
            }

            return false;
        }

        #endregion


 
    }
}

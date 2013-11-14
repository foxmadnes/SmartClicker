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
    class CursorCapture
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
            /*
            //create instance or System.Drawing.ImageConverter to convert image to a byte array
            ImageConverter converter = new ImageConverter();
            //create byte arrays, for currentCursor
            byte[] currentMouseBytes = new byte[1];

            //convert images to byte array
            currentMouseBytes = (byte[])converter.ConvertTo(currentMouse, currentMouseBytes.GetType());

            //now compute a hash for current cursor from the byte arrays
            SHA256Managed sha = new SHA256Managed();
            byte[] currentMouseHash = sha.ComputeHash(currentMouseBytes);
            
            if (clickAndDragDictionary.ContainsKey(currentMouseHash))
            {
                return clickAndDragDictionary[currentMouseHash];
            }
            */
            // Go through each known cursor in clickAndDrag
            foreach (Bitmap cursor in clickAndDragBitmaps)
            {
                // if bitmaps are close
                if (CompareCursorBitmaps(cursor, currentMouse))
                {
                    // add to dictionary to avoid overhead
                    //clickAndDragDictionary.Add(currentMouseHash, true);
                    return true;
                }
            }

            // None match, add to dictionary to avoid next time
            //clickAndDragDictionary.Add(currentMouseHash, false);
            return false;
        }

        /*************************************************************************
        * method for retrieving the current bitmap of the global cursor
        **************************************************************************/
        public static cursorInTime CaptureCursor()
        {
            return new cursorInTime(0,0,0, null);
            Bitmap bmp;
            IntPtr hicon;
            Win32Stuff.CURSORINFO ci = new Win32Stuff.CURSORINFO();
            Win32Stuff.ICONINFO icInfo;
            ci.cbSize = Marshal.SizeOf(ci);
            if (Win32Stuff.GetCursorInfo(out ci))
            {
                if (ci.flags == Win32Stuff.CURSOR_SHOWING)
                {
                    hicon = Win32Stuff.CopyIcon(ci.hCursor);
                    Win32Stuff.GetIconInfo(hicon, out icInfo);
                    int x = ci.ptScreenPos.x - ((int)icInfo.xHotspot);
                    int y = ci.ptScreenPos.y - ((int)icInfo.yHotspot);
                    using (Bitmap maskBitmap = Bitmap.FromHbitmap(icInfo.hbmMask))
                    {
                        // Is this a monochrome cursor?
                        // This portion taken from http://stackoverflow.com/questions/918990/c-sharp-capturing-the-mouse-cursor-image
                        if (maskBitmap.Height == maskBitmap.Width * 2)
                        {
                            Bitmap resultBitmap = new Bitmap(maskBitmap.Width, maskBitmap.Width);

                            Graphics desktopGraphics = Graphics.FromHwnd(Win32Stuff.GetDesktopWindow());
                            IntPtr desktopHdc = desktopGraphics.GetHdc();

                            IntPtr maskHdc = Win32Stuff.CreateCompatibleDC(desktopHdc);
                            IntPtr oldPtr = Win32Stuff.SelectObject(maskHdc, maskBitmap.GetHbitmap());

                            using (Graphics resultGraphics = Graphics.FromImage(resultBitmap))
                            {
                                IntPtr resultHdc = resultGraphics.GetHdc();

                                // These two operation will result in a black cursor over a white background.
                                // Later in the code, a call to MakeTransparent() will get rid of the white background.
                                Win32Stuff.BitBlt(resultHdc, 0, 0, 32, 32, maskHdc, 0, 32, (int) Win32Stuff.TernaryRasterOperations.SRCCOPY);
                                Win32Stuff.BitBlt(resultHdc, 0, 0, 32, 32, maskHdc, 0, 0, (int) Win32Stuff.TernaryRasterOperations.SRCINVERT);

                                resultGraphics.ReleaseHdc(resultHdc);
                            }

                            IntPtr newPtr = Win32Stuff.SelectObject(maskHdc, oldPtr);
                            Win32Stuff.DeleteObject(newPtr);
                            Win32Stuff.DeleteDC(maskHdc);
                            desktopGraphics.ReleaseHdc(desktopHdc);

                            // Remove the white background from the BitBlt calls,
                            // resulting in a black cursor over a transparent background.
                            // resultBitmap.MakeTransparent(Color.White);
                            bmp = resultBitmap;
                        }
                        else
                        {
                            Icon ic = Icon.FromHandle(hicon);
                            bmp = ic.ToBitmap();
                        }
                    }
                    Win32Stuff.DeleteObject(hicon);
                    if (icInfo.hbmColor != IntPtr.Zero) Win32Stuff.DeleteObject(icInfo.hbmColor);
                    if (icInfo.hbmMask != IntPtr.Zero) Win32Stuff.DeleteObject(icInfo.hbmMask);
                    Win32Stuff.DeleteObject(ci.hCursor);
                    return new cursorInTime(x, y, 0, bmp);
                }
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

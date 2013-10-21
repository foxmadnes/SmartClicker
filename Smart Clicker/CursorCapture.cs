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
        public const Int32 CURSOR_SHOWING = 0x00000001;
        [StructLayout(LayoutKind.Sequential)]
        public struct ICONINFO
        {
            public bool fIcon;         // Specifies whether this structure defines an icon or a cursor. A value of TRUE specifies 
            public Int32 xHotspot;     // Specifies the x-coordinate of a cursor's hot spot. If this structure defines an icon, the hot 
            public Int32 yHotspot;     // Specifies the y-coordinate of the cursor's hot spot. If this structure defines an icon, the hot 
            public IntPtr hbmMask;     // (HBITMAP) Specifies the icon bitmask bitmap. If this structure defines a black and white icon, 
            public IntPtr hbmColor;    // (HBITMAP) Handle to the icon color bitmap. This member can be optional if this 
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct CURSORINFO
        {
            public Int32 cbSize;        // Specifies the size, in bytes, of the structure. 
            public Int32 flags;         // Specifies the cursor state. This parameter can be one of the following values:
            public IntPtr hCursor;          // Handle to the cursor. 
            public POINT ptScreenPos;       // A POINT structure that receives the screen coordinates of the cursor. 
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public Int32 x;
            public Int32 y;
        }

        [DllImport("user32.dll", EntryPoint = "GetCursorInfo", SetLastError=true)]
        public static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll", EntryPoint = "CopyIcon")]
        public static extern IntPtr CopyIcon(IntPtr hIcon);

        [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
        public static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

        [DllImport("user32.dll", EntryPoint = "LoadCursor")]
        static extern IntPtr LoadCursor(IntPtr hInstance, IntPtr lpzName);

        [DllImport("user32.dll", EntryPoint = "SetCursor")]
        static extern IntPtr SetCursor(IntPtr hCursor);

        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern bool DeleteObject(IntPtr hObject);


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
            ICONINFO ii;
            GetIconInfo(cur.Handle, out ii);

            Bitmap bmp = Bitmap.FromHbitmap(ii.hbmColor);
            DeleteObject(ii.hbmColor);
            DeleteObject(ii.hbmMask);

            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
            Bitmap dstBitmap = new Bitmap(bmData.Width, bmData.Height, bmData.Stride, PixelFormat.Format32bppArgb, bmData.Scan0);
            bmp.UnlockBits(bmData);

            return new Bitmap(dstBitmap);
        }

        
        public static Bitmap GetBitmapFromCursor(int cursor)
        {
            IntPtr cursorPointer = LoadCursor(IntPtr.Zero, (IntPtr) cursor);
            SetCursor(cursorPointer);
            Bitmap bitmap = CaptureCursor();

            return CaptureCursor();
        }
        

        public bool IsClickAndDrag()
        {
            Bitmap currentMouse = CaptureCursor();

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

            // Go through each known cursor in clickAndDrag
            foreach (Bitmap cursor in clickAndDragBitmaps)
            {
                // if bitmaps are close
                if (CompareCursorBitmaps(cursor, currentMouse))
                {
                    // add to dictionary to avoid overhead
                    clickAndDragDictionary.Add(currentMouseHash, true);
                    return true;
                }
            }

            // None match, add to dictionary to avoid next time
            clickAndDragDictionary.Add(currentMouseHash, false);
            return false;
        }

        /*************************************************************************
        * method for retrieving the current bitmap of the global cursor
        **************************************************************************/
        public static Bitmap CaptureCursor()
        {
            Bitmap bmp;
            IntPtr hicon;
            CURSORINFO ci = new CURSORINFO();
            ICONINFO icInfo;
            ci.cbSize = Marshal.SizeOf(ci);
            if (GetCursorInfo(out ci))
            {
                if (ci.flags == CURSOR_SHOWING)
                {
                    hicon = CopyIcon(ci.hCursor);
                    if (GetIconInfo(hicon, out icInfo))
                    {
                      //  x = ci.ptScreenPos.x - ((int)icInfo.xHotspot);
                      //  y = ci.ptScreenPos.y - ((int)icInfo.yHotspot);
                        Icon ic = Icon.FromHandle(hicon);
                        bmp = ic.ToBitmap();
 
                        return bmp;
                    }
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using Gma.UserActivityMonitor;

namespace Smart_Clicker
{
    class ClickDetector
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        private ClickStatus status;
        private List<pointInTime> MouseTracker = new List<pointInTime>();
        private Stopwatch sw = new Stopwatch();

        public ClickDetector(ClickStatus status)
        {
            this.status = status;
        }

        public void detector()
        {
            System.Diagnostics.Debug.WriteLine("weeee");
            HookManager.MouseMoveExt += new EventHandler<MouseEventExtArgs>(HookManager_MouseMoveExt);
        }

        private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
        {
            if (MouseTracker.Count < 50)
            {
                MouseTracker.Add(new pointInTime(e.X, e.Y, sw.ElapsedMilliseconds));
                if (!sw.IsRunning)
                    sw.Start();
            }
            else
            {

                sw.Stop();
                long elapsed = sw.ElapsedMilliseconds;
                long speed = (long) Math.Sqrt(((MouseTracker[0].p.X - MouseTracker[24].p.X) ^ 2 + (MouseTracker[0].p.Y - MouseTracker[24].p.Y) ^ 2));
                if (speed < 1)
                {
                    this.click(MouseTracker[24].p);
                    System.Diagnostics.Debug.WriteLine("Performed click!");
                }
                MouseTracker = new List<pointInTime>();

            }
            
            //System.Diagnostics.Debug.WriteLine(e.Location);
        }

        private void click(Point p)
        {
            switch (this.status.getStatus())
            {
                case (statusEnum.leftClick):
                    mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
                    break;
                case (statusEnum.rightClick):

                case (statusEnum.doubleClick):

                case (statusEnum.leftDown):

                case (statusEnum.leftUp):

                default:
                    break;
            }
        }
    }

    public class pointInTime
    {
        public Point p;
        public long tMS;

        public pointInTime(int x, int y, long et)
        {
            p = new Point(x, y);
            tMS = et;
        }
    }
}

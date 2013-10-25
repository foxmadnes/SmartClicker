using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Clicker
{
    class ClickDetector
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SetCursorPos(int x, int y);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        private ClickStatus status;
        private CursorCapture capture;
        private List<cursorInTime> MouseTracker = new List<cursorInTime>();
        private cursorInTime lastClick;
        private MainForm form;
        private Stopwatch sw = new Stopwatch();

        private Timer timer1;

        public ClickDetector(ClickStatus status, CursorCapture capture, MainForm form)
        {
            this.status = status;
            this.capture = capture;
            this.form = form;
            this.lastClick = new cursorInTime(0, 0, 0, null);
            InitTimer();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100; // in miliseconds
            timer1.Start();
        }

        // TODO: Break this up into smaller subfunctions
        private void timer1_Tick(object sender, EventArgs e)
        {
            cursorInTime cursor = CursorCapture.CaptureCursor();
            if (cursor.p.X == 0 && cursor.p.Y == 0)
            {
                this.form.Activate();
                System.Diagnostics.Debug.WriteLine("recall!");
                return;
            }
            cursor.tMS = timer1.Interval;
            MouseTracker.Add(cursor);

            if (MouseTracker.Count >= 10)
            {
                int currentCursorIndex = MouseTracker.Count -1;
                int breakIndex = -1;
                for (int i = MouseTracker.Count - 1; i > 0; i--)
                {
                    if (closeCursors(MouseTracker[i], MouseTracker[currentCursorIndex]))
                    {
                        continue;
                    }
                    else
                    {
                        breakIndex = i;
                        break;
                    }
                }
                if (breakIndex != -1)
                {
                    MouseTracker.RemoveRange(0, breakIndex);
                }
                else
                {
                    
                    if (closeCursors(MouseTracker[currentCursorIndex], lastClick))
                    {
                        MouseTracker.Clear();
                        return;
                    } 

                    int clickAndDragCursors = MouseTracker.Count(p => capture.IsClickAndDrag(p.cursor));
                    if (clickAndDragCursors > 1)
                    {
                        if (capture.IsClickAndDrag(MouseTracker[currentCursorIndex].cursor))
                        {
                            click(MouseTracker[currentCursorIndex].p, true);
                        }
                        else
                        {
                            // This didn't work - Programs freak out when you click where the mouse isn't
                            // TODO: See if there is any way to get the mouse not to freak out when moved
                            //cursorInTime lastDrag = MouseTracker.Last(p => capture.IsClickAndDrag(p.cursor));
                            //SetCursorPos(lastDrag.p.X, lastDrag.p.Y);
                            //click(lastDrag.p, true);
                        }
                    }
                    else
                    {
                        click(MouseTracker[currentCursorIndex].p, false);
                    }
                    lastClick = MouseTracker[currentCursorIndex];
                    MouseTracker.Clear();
                }
            }
        }

        private Boolean closeCursors(cursorInTime c1, cursorInTime c2)
        {
            if (Math.Abs(c1.p.X - c2.p.X) < 10 && Math.Abs(c1.p.Y - c2.p.Y) < 10)
            {
                return true;
            }
            return false;
        }

        private void click(Point p, Boolean clickAndDrag)
        {
            if (form.ClientRectangle.Contains(p) && (Form.ActiveForm == this.form))
            {
                return;
            }

            if (this.status.getContext())
            {
                if (clickAndDrag)
                {
                    if (this.status.getStatus() != statusEnum.leftUp)
                    {
                        this.status.setStatus(statusEnum.leftDown);
                    }
                }
            }

            switch (this.status.getStatus())
            {
                case (statusEnum.leftClick):
                    mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
                    System.Diagnostics.Debug.WriteLine("Clickety click");
                    break;

                case (statusEnum.rightClick):
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, p.X, p.Y, 0, 0);
                    if (this.status.isLocked())
                    {
                        break;
                    }
                    this.form.setClickDefault();
                    this.status.setStatus(statusEnum.leftClick);
                    break;

                case (statusEnum.doubleClick):
                    mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
                    if (this.status.isLocked())
                    {
                        break;
                    }
                    this.form.setClickDefault();
                    this.status.setStatus(statusEnum.leftClick);
                    break;

                case (statusEnum.leftDown):
                    mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0);
                    this.status.setStatus(statusEnum.leftUp);
                    break;

                case (statusEnum.leftUp):
                    mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0);
                    if (this.status.isLocked())
                    {
                        if (!this.status.getContext())
                        {
                            this.status.setStatus(statusEnum.leftDown);
                        }
                    }
                    this.form.setClickDefault();
                    this.status.setStatus(statusEnum.leftClick);
                    break;

                default:
                    break;
            }
        }
    }

    public class cursorInTime
    {
        public Point p;
        public long tMS;
        public Bitmap cursor;

        public cursorInTime(int x, int y, long et, Bitmap cursor)
        {
            p = new Point(x, y);
            tMS = et;
            this.cursor = cursor;
        }
    }
}

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

        private int CURSOR_DISTANCE = 25;

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

        // This is called every timer1.Interval
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Take snapshot of current cursor
            cursorInTime cursor = CursorCapture.CaptureCursor();

            if (cursor == null)
            {
                return;
            }

            // If mouse is in the top left corner, bring form to front
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
                // Check if the mouse has dwelled and proceed from there
                int currentCursorIndex = this.checkDwell();
                if (currentCursorIndex != -1)
                {
                    // There was a dwell, so we should click
                    checkDragThenClick(currentCursorIndex);
                }
            }
        }

        // Checks if the list of cursors seems to indicate a dwell, and if it is, returns the index of the cursor that should be clicked
        // If the mouse had too much activity (did not dwell), then returns -1
        private int checkDwell()
        {
            // A dwell is designated as a series of 10 captured cursors that don't move outside of a bounding box
            // So we start with the last cursor and compare backwards
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
            // This means that any one of the previous cursors was too far from the current one
            if (breakIndex != -1)
            {
                // So we remove all the ones that don't match 
                // This may be a bit unclear so say the cursors were  R R L R R R R R R
                // Once we find it breaks, we want to remove all the L's so that the next check is sooner
                // AKA now the list is R R R R R R - and within 4 more samples we can check for a dwell again
                MouseTracker.RemoveRange(0, breakIndex);
                return -1;
            }
            else
            {
                return currentCursorIndex;
            }
        }

        // Wrapper function for click() that scans last few cursors to aid click and drag in context mode
        private void checkDragThenClick(int currentCursorIndex)
        {
            // Check if the lastClick as close to the current one
            if (closeCursors(MouseTracker[currentCursorIndex], lastClick))
            {
                // If it was, clear this set of captures cursors
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


        private Boolean closeCursors(cursorInTime c1, cursorInTime c2)
        {
            // Check that X and Y positions of cursor 1 are not more than CURSOR_DISTANCE away
            if (Math.Abs(c1.p.X - c2.p.X) < CURSOR_DISTANCE && Math.Abs(c1.p.Y - c2.p.Y) < CURSOR_DISTANCE)
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

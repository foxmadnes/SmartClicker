using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using interop.UIAutomationCore;

namespace Smart_Clicker
{
    public class ClickDetector
    {

        private ClickStatus status;
        private CursorCapture capture;
        private CustomizationParameters parameters;
        private List<cursorInTime> MouseTracker = new List<cursorInTime>();
        private cursorInTime lastClick;
        private MainForm form;
        private Stopwatch sw = new Stopwatch();
        private int lastSentToBack;

        private Timer timer1;

        private IUIAutomation automator;

        public ClickDetector(ClickStatus status, CursorCapture capture, CustomizationParameters parameters, MainForm form)
        {
            this.status = status;
            this.capture = capture;
            this.parameters = parameters;
            this.form = form;
            this.lastClick = new cursorInTime(-50, -50, null);
            InitTimer();
            this.automator = new CUIAutomation();
            this.lastSentToBack = 0;
        }

        #region Timer Functions

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = this.parameters.clickValues.timeout;
            timer1.Start();
        }

        // Called by CustomUI when changing timer interval
        public void resetTimerInterval()
        {
            timer1.Interval = this.parameters.clickValues.timeout;
        }

        // This is called every timer1.Interval
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Take snapshot of current cursor
            cursorInTime cursor = CursorCapture.CaptureCursor();

            if (cursor == null || (this.status.getCurrentMode() == null && this.status.getBackgroundMode() == ProgramMode.sleepClick))
            {
                cursor.cursor.Dispose();
                return;
            }

            // Magic Number for hiding (fix this)
            if (this.lastSentToBack >= 50) {
                if (Win32Stuff.GetForegroundWindow() == this.form.Handle)
                {
                    if (!this.form.Bounds.Contains(cursor.p) && !this.form.fetcher.Bounds.Contains(cursor.p))
                    {
                        Debug.Print("Sending to back.");
                        this.lastSentToBack = 0;
                        this.form.SendToBack();
                    }
                }
            }
            this.lastSentToBack++;

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
                else
                {
                    // The last click position is not valid anymore, clear it
                    this.lastClick = new cursorInTime(-50, -50, null);
                }
            }
        }

        #endregion

        #region Click Functions

        // Wrapper function for click() that scans last few cursors to aid click and drag in context mode
        private void checkDragThenClick(int currentCursorIndex)
        {
            // Check if the lastClick as close to the current one
            if (closeCursors(MouseTracker[currentCursorIndex], lastClick))
            {
                // If it was, check to see if any of the other cursors have moved far enough from the first click
                if (MouseTracker.Any(p => !closeCursors(p, lastClick)))
                {
                    // We've moved from the last click and come back, continue clicking
                }
                // Otherwise, clear this set of captures cursors - using the current last click as the last click now
                else 
                {
                    this.lastClick = MouseTracker[currentCursorIndex];
                    clearCursors();
                    return;
                }
            }
            if (this.parameters.contextValues.compareCursors)
            {
                int clickAndDragCursors = MouseTracker.Count(p => capture.IsClickAndDrag(p.cursor));
                if (clickAndDragCursors > 1)
                {
                    if (capture.IsClickAndDrag(MouseTracker[currentCursorIndex].cursor))
                    {
                        click(MouseTracker[currentCursorIndex].p, true);
                        Debug.Print("Click and drag cursor click!");
                        lastClick = MouseTracker[currentCursorIndex];
                        clearCursors();
                        return;
                    }
                    else
                    {
                        // This didn't work - Programs freak out when you click where the mouse isn't
                        // TODO: See if there is any way to get the mouse not to freak out when moved
                        // This section would move the cursor back to a resize position if some of the cursors matched,
                        // to help with efficiency
                        //cursorInTime lastDrag = MouseTracker.Last(p => capture.IsClickAndDrag(p.cursor));
                        //SetCursorPos(lastDrag.p.X, lastDrag.p.Y);
                        //click(lastDrag.p, true);
                    }
                }
            }
            click(MouseTracker[currentCursorIndex].p, false);
            lastClick = MouseTracker[currentCursorIndex];
            clearCursors();
        }

        private void click(Point p, Boolean setClickAndDrag)
        {
            Point pt = form.PointToClient(p);

            // Check if the clicking point is inside the form
            bool inside = (pt.X >= 0 && pt.Y >= 0 && pt.X <= (form.Width) && pt.Y <= (form.Height));

            //Should not click inside the mainForm, unless we are in the process of resizing it
            if (inside && (Form.ActiveForm == this.form) && (this.status.currentIndex == 0) && !setClickAndDrag)
            {
                return;
            }

            // Make sure the fetcher stays on top, since other applications could set themselves TopMost
            this.form.fetcher.TopMost = true;

            if (this.status.getActiveMode().isContext)
            {
                if (setClickAndDrag)
                {
                    if (this.status.getCurrentMode() != ProgramMode.clickAndDrag)
                    {
                        this.status.setCurrentMode(ProgramMode.clickAndDrag);
                    }
                }
                uiAutomationCheck(p);
            }
            
            // Get activeMode and perform the current actions for this time step
            ProgramMode activeMode = this.status.getActiveMode();
            Debug.Print("Performing Click Action: " + activeMode.mode[this.status.currentIndex].ToString());
            clickActions(activeMode.mode[this.status.currentIndex], p);
            Debug.Print("f");

            // Increase the timestep and clear if done with current ProgramMode
            this.status.currentIndex++;
            if (this.status.currentIndex > activeMode.mode.Length - 1)
            {
                this.status.clearActiveMode();
                this.form.setClickDefault();
            }
        }

        //Performs all mouse and keyboard actions for this time step
        private void clickActions(Action[] actions, Point p)
        {
            foreach (Action action in actions)
            {
                if (action.GetType() == typeof(MouseAction))
                {
                    performMouseAction((MouseAction) action, p);
                }
                else
                {
                    performKeyboardAction((KeyboardAction) action);
                }
            }
        }

        private void performMouseAction(MouseAction action, Point p)
        {
            Win32Stuff.mouse_event((int) action.clickInt, p.X, p.Y, 0, 0);
        }

        private void performKeyboardAction(KeyboardAction action)
        {
            Win32Stuff.keybd_event(action.key,0, (action.key_up ? 0x02 : 0), 0);
        }

        #endregion

        #region Click Helper Functions

        // Checks if the list of cursors seems to indicate a dwell, and if it is, returns the index of the cursor that should be clicked
        // If the mouse had too much activity (did not dwell), then returns -1
        private int checkDwell()
        {
            // A dwell is designated as a series of 10 captured cursors that don't move outside of a bounding box
            // So we start with the last cursor and compare backwards
            int currentCursorIndex = MouseTracker.Count - 1;
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

        private Boolean closeCursors(cursorInTime c1, cursorInTime c2)
        {
            // Check that X and Y positions of cursor 1 are not more than CURSOR_DISTANCE away
            if (Math.Abs(c1.p.X - c2.p.X) < this.parameters.clickValues.clickBoundingBox && Math.Abs(c1.p.Y - c2.p.Y) < this.parameters.clickValues.clickBoundingBox)
            {
                return true;
            }
            return false;
        }

        // Uses Windows UI Automation API to determine if we should click and Drag in context Mode
        private void uiAutomationCheck(Point p)
        {
            tagPOINT reference = new tagPOINT();
            reference.x = p.X;
            reference.y = p.Y;

            if (this.status.getCurrentMode() != ProgramMode.clickAndDrag)
            {
                try
                {
                    IUIAutomationElement focus = this.automator.ElementFromPoint(reference);

                    // Useful for debugging API support
                    System.Diagnostics.Debug.Print(focus.CurrentControlType.ToString());
                    System.Diagnostics.Debug.Print("localized:" + focus.CurrentLocalizedControlType);

                    if ((focus.CurrentControlType == 50037 && this.parameters.contextValues.supportTitleBars)
                        || (focus.CurrentControlType == 50027 && this.parameters.contextValues.supportScrollBars)
                        || (focus.CurrentControlType == 50018 && this.parameters.contextValues.supportTabs))
                    {
                        this.status.setCurrentMode(ProgramMode.clickAndDrag);
                    }
                }
                catch (COMException e)
                {
                    // No element given, give up
                }
            }
        }

        private void clearCursors()
        {
            foreach (cursorInTime cursor in this.MouseTracker)
            {
                cursor.cursor.Dispose();
            }
            this.MouseTracker.Clear();
        }

        #endregion
    }

    //Represents a snapshot of the cursor
    public class cursorInTime
    {
        public Point p;
        public Bitmap cursor;

        public cursorInTime(int x, int y, Bitmap cursor)
        {
            p = new Point(x, y);
            this.cursor = cursor;
        }
    }
}

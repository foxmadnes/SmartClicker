using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Clicker
{
    public class ClickStatus
    {
        public ProgramMode backgroundMode;
        public ProgramMode currentMode;
        public int currentIndex = 0;
        static private object backgroundLock = new object();
        static private object currentLock = new object();

        public ClickStatus()
        {
            this.backgroundMode = ProgramMode.contextClick;
            this.currentMode = null;
        }

        public void setBackgroundMode(ProgramMode mode)
        {
            lock (backgroundLock)
            {
                this.backgroundMode = mode;
            }
            this.currentIndex = 0;
        }

        public void setCurrentMode(ProgramMode mode)
        {
            lock (currentLock)
            {
                this.currentMode = mode;
            }
            this.currentIndex = 0;
        }

        public void clearActiveMode()
        {
            this.currentIndex = 0;
            if (this.currentMode == null)
            {
                return;
            }
            this.currentMode = null;
        }

        public ProgramMode getBackgroundMode()
        {
            lock (backgroundLock)
            {
                return this.backgroundMode;
            }
        }

        public ProgramMode getCurrentMode()
        {
            lock (currentLock)
            {
                return this.currentMode;
            }
        }

        public ProgramMode getActiveMode()
        {
            if (this.currentMode == null)
            {
                return this.backgroundMode;
            }
            return this.currentMode;
        }
    }
}

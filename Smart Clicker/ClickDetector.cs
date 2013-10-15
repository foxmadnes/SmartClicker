using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gma.UserActivityMonitor;

namespace Smart_Clicker
{
    class ClickDetector
    {
        private ClickStatus status;

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
            System.Diagnostics.Debug.WriteLine(e.Location);
        }

        private void click()
        {

        }
    }
}

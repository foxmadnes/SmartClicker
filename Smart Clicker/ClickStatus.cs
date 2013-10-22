using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Clicker
{
    public enum statusEnum { leftClick, rightClick, doubleClick, leftDown, leftUp, sleepClick};

    public class ClickStatus
    {
        private statusEnum status = statusEnum.leftClick;
        private bool context = false;
        private bool isLocked = false;
        static private object Lock = new object();

        public ClickStatus()
        {

        }

        public void setStatus(statusEnum newStatus)
        {
            lock(Lock)
            {
                this.status = newStatus;
            }
            System.Diagnostics.Debug.WriteLine(this.status.ToString());
        }

        public statusEnum getStatus()
        {
            return this.status;
        }

        public void setContext(bool set)
        {
            this.context = set;
        }

        public bool getContext()
        {
            return this.context;
        }
    }
}

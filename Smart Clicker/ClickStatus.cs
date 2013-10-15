using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Clicker
{
    public enum statusEnum { leftClick, rightClick, doubleClick, leftDown, leftUp };

    public class ClickStatus
    {
        private statusEnum status = statusEnum.leftClick;
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
        }

        public statusEnum getStatus()
        {
            return this.status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Clicker
{

    public class Action
    {
        
    }

    public class MouseAction : Action
    {

        public enum clickType : int 
        {
            leftUp = 0x04,
            leftDown = 0x02, 
            rightUp = 0x10, 
            rightDown = 0x08,
            middleDown = 0x20,
            middleUp = 0x40,
        };

        public clickType clickInt;

        public MouseAction(clickType type)
        {
            this.clickInt = type;
        }
    }

    public class KeyboardAction : Action
    {
        // To be implemented later
    }
}

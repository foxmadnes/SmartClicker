using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Smart_Clicker
{
    // Superclass that holds an arbitrary keyboard or mouse action for Program Mode definition
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
        public Byte key;
        public bool key_up;

        public KeyboardAction(Byte key, bool up)
        {
            this.key = key;
            this.key_up = up;
        }

        #region Static Known Keyboard Actions

        public static KeyboardAction ctrlDown = new KeyboardAction(0x11, false);
        public static KeyboardAction ctrlUp = new KeyboardAction(0x11, true);
        public static KeyboardAction cDown = new KeyboardAction(0x43, false);
        public static KeyboardAction cUp = new KeyboardAction(0x43, true);
        public static KeyboardAction vDown = new KeyboardAction(0x56, false);
        public static KeyboardAction vUp = new KeyboardAction(0x56, true);

        #endregion
    }
}

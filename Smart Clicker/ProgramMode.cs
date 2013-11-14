using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Clicker
{
    public class ProgramMode
    {
        // First array is by click-step, second array is group of actions done in that clickstep
        public Action[][] mode;
        public bool isContext;

        public ProgramMode(Action[][] mode, bool context = false)
        {
            this.mode = mode;
            this.isContext = context;
        }

        public static ProgramMode leftClick = 
            new ProgramMode(new Action[][] { new Action[] {new MouseAction(MouseAction.clickType.leftDown), new MouseAction(MouseAction.clickType.leftUp) } });

        public static ProgramMode rightClick =
            new ProgramMode(new Action[][] { new Action[] { new MouseAction(MouseAction.clickType.rightDown), new MouseAction(MouseAction.clickType.rightUp) } });

        public static ProgramMode doubleClick = 
            new ProgramMode(new Action[][] { new Action[] { new MouseAction(MouseAction.clickType.leftDown), new MouseAction(MouseAction.clickType.leftUp),
                                            new MouseAction(MouseAction.clickType.leftDown), new MouseAction(MouseAction.clickType.leftUp)} });

        public static ProgramMode clickAndDrag =
            new ProgramMode(new Action[][] { new Action[] { new MouseAction(MouseAction.clickType.leftDown) }, new Action[] { new MouseAction(MouseAction.clickType.leftUp) } });

        public static ProgramMode sleepClick =
            new ProgramMode(new Action[][] { new Action[] { } });

        public static ProgramMode contextClick =
            new ProgramMode(new Action[][] { new Action[] { new MouseAction(MouseAction.clickType.leftDown), new MouseAction(MouseAction.clickType.leftUp) } }, true);
    }
}

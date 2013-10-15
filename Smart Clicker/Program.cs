using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Smart_Clicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClickStatus status = new ClickStatus();
            ClickDetector clickDetector = new ClickDetector(status);
            clickDetector.detector();
            Application.Run(new MainForm(status));
        }
    }
}

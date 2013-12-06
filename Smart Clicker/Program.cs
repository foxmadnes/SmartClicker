using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

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
            // Make sure this is the only "Smart Clicker" running!
            bool ok;
            Mutex m = new System.Threading.Mutex(true, "Smart Clicker", out ok);

            if (!ok)
            {
                return;
            }

            // Set handler for all uncaught exceptions, so we can restart
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Set Global application parameters
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the application
            ClickStatus status = new ClickStatus();
            CustomizationParameters customParams = new XmlMethods().loadFromXML();
            MainForm mainForm = new MainForm(status, customParams);
            ClickDetector clickDetector = new ClickDetector(status, new CursorCapture(), customParams, mainForm);
            mainForm.detector = clickDetector;

            Application.ThreadException += new ThreadExceptionEventHandler(mainForm.CatchFatalException);

            Application.Run(mainForm);
            GC.KeepAlive(m);
        } 
    }
}

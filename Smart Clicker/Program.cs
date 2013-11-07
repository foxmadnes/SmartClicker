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
            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClickStatus status = new ClickStatus();
            MainForm mainForm = new MainForm(status);
            ClickDetector clickDetector = new ClickDetector(status, new CursorCapture(), mainForm);

            Fetcher fetcher = new Fetcher(mainForm);

            fetcher.Show();
            Application.Run(mainForm);
            //CustomUI cust1 = new CustomUI();
            //Application.Run(cust1);
        }
    }
}

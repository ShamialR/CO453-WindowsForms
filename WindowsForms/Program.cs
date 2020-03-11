using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
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
            //Application.Run(new Unit1.WelcomeForm());
            //Application.Run(new Unit1.DataEntryForm());
            //Application.Run(new Unit1.CalculatorForm());
            Application.Run(new Unit1.CalculatorV2Form());
        }
    }
}

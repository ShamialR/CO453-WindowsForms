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
            //Application.Run(new WelcomeForm());
            //Application.Run(new Unit1.DataEntryForm());
            //Application.Run(new Unit1.CalculatorForm());
            //Application.Run(new Unit1.CalculatorV2Form());
            //Application.Run(new Unit2.RPSForm());
            //Application.Run(new Unit3.CurrencyConverterForm());
            //Application.Run(new Unit3.PizzaOrderForm());
            //Application.Run(new Unit3.PoshNoshForm());
            //Application.Run(new Unit3.MonkeyBashForm());
            //Application.Run(new Unit3.MyPadForm());
            //Application.Run(new Unit3.TargetForm());
            Application.Run(new Unit3.ChoosePictureForm());
        }
    }
}

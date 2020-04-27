using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit3
{
    /// <summary>
    /// Task 3.1
    /// This class converts british pounds into 3 different
    /// currencies that can be selected from the choice boxes
    /// which are dollars, euros and rupees. This is then 
    /// displayed in the convertedResultLabel label. 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class CurrencyConverterForm : Form
    {
        private double amount;
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void convertDollars(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 1.8;
            convertedResultLabel.Text = amount.ToString() + " Dollars";
        }

        private void convertEuros(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 1.4;
            convertedResultLabel.Text = amount.ToString() + " Euros";
        }

        private void convertRepees(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 80;
            convertedResultLabel.Text = amount.ToString() + " Rupees";
        }

        private void quitApplication(object sender, EventArgs e)
        {
            DialogResult response; 

            response = MessageBox.Show("Are You Sure?", "Quit",
            MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

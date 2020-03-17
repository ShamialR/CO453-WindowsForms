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
    public partial class CurrencyConverterForm : Form
    {
        private double amount;
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void dollarsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 1.8;
            convertedResultLabel.Text = amount.ToString() + " Dollars";
        }

        private void eurosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 1.4;
            convertedResultLabel.Text = amount.ToString() + " Euros";
        }

        private void rupeesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(ukPoundsTextBox.Text) * 80;
            convertedResultLabel.Text = amount.ToString() + " Rupees";
        }

        private void button1_Click(object sender, EventArgs e)
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

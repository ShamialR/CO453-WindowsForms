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
    public partial class PizzaOrderForm : Form
    {

        public const double toppingPrice = 2.50;

        private double pizzaCost = 0;
        private double toppingCost = 0;
        private double totalCost = 0;
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(largeRadioButton.Checked)
            {
                pizzaCost = 12;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumRadioButton.Checked)
            {
                pizzaCost = 8;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (smallRadioButton.Checked)
            {
                pizzaCost = 5;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pineappleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pineappleCheckBox.Checked)
            {
                toppingCost += toppingPrice;
            }
            else
            {
                toppingCost -= toppingPrice;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void rhubarbCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rhubarbCheckBox.Checked)
            {
                toppingCost += toppingPrice;
            }
            else
            {
                toppingCost -= toppingPrice;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                toppingCost += toppingPrice;
            }
            else
            {
                toppingCost -= toppingPrice;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void chocolateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolateCheckBox.Checked)
            {
                toppingCost += toppingPrice;
            }
            else
            {
                toppingCost -= toppingPrice;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }
    }
}

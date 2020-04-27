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
    /// Task 3.2
    /// This class uses radio buttons which allows the user
    /// to select the size of the pizza they want, it then
    /// uses check boxes for toppings and adds the total
    /// cost of the order before displaying it. 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class PizzaOrderForm : Form
    {

        private const double MAX_TOPPING_PRICE = 2.50;
        private double pizzaCost = 0;
        private double toppingCost = 0;
        private double totalCost = 0;
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void chooseLargePizza(object sender, EventArgs e)
        {
            if(largeRadioButton.Checked)
            {
                pizzaCost = 12;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void chooseMediumPizza(object sender, EventArgs e)
        {
            if (mediumRadioButton.Checked)
            {
                pizzaCost = 8;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void chooseSmallPizza(object sender, EventArgs e)
        {
            if (smallRadioButton.Checked)
            {
                pizzaCost = 5;
            }

            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pickPineappleTopping(object sender, EventArgs e)
        {
            if (pineappleCheckBox.Checked)
            {
                toppingCost += MAX_TOPPING_PRICE;
            }
            else
            {
                toppingCost -= MAX_TOPPING_PRICE;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void pickRhubarbTopping(object sender, EventArgs e)
        {
            if (rhubarbCheckBox.Checked)
            {
                toppingCost += MAX_TOPPING_PRICE;
            }
            else
            {
                toppingCost -= MAX_TOPPING_PRICE;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void pickPepperoniTopping(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                toppingCost += MAX_TOPPING_PRICE;
            }
            else
            {
                toppingCost -= MAX_TOPPING_PRICE;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }

        private void pickChocolateTopping(object sender, EventArgs e)
        {
            if (chocolateCheckBox.Checked)
            {
                toppingCost += MAX_TOPPING_PRICE;
            }
            else
            {
                toppingCost -= MAX_TOPPING_PRICE;
            }
            totalCost = pizzaCost + toppingCost;
            pizzaCostLabel.Text = "£ " + totalCost.ToString("0.00");
        }
    }
}

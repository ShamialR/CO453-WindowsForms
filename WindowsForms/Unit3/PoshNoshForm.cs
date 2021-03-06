﻿using System;
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
    /// Task 3.3 - 3.4
    /// This class uses list boxes which allow the user to select
    /// their starters, mains and desserts, this is then added up
    /// to calculate the total price of the meal which is displayed
    ///in the totalCostLabel. 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class PoshNoshForm : Form
    {

        private double totalCost = 0;
        private double starterCost = 0;
        private double maincourseCost = 0;
        private double dessertCost = 0;

        public PoshNoshForm()
        {
            InitializeComponent();
        }

        private void selectStarters(object sender, EventArgs e)
        {
            switch (startersListBox.Text)
            {
                case "Soup of the Day": starterCost = 5.00; break;
                case "Chilli Fish Cakes": starterCost = 5.50; break;
                case "Caesar Salad": starterCost = 4.50; break;
                case "King Prawn CousCous": starterCost = 6.00; break;
                case "Black Pudding Pate": starterCost = 4.00; break;
                case "Chicken Liver Toast": starterCost = 3.50; break;
                case "Prawn Cocktail": starterCost = 5.50; break;
            }
            totalCost = starterCost + maincourseCost + dessertCost;
            totalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }

        private void selectMainCourse(object sender, EventArgs e)
        {
            switch (mainsListBox.Text)
            {
                case "Steak and Chips": maincourseCost = 12.50; break;
                case "Fish and Chips": maincourseCost = 7.50; break;
                case "Vegetable Curry": maincourseCost = 8.00; break;
                case "Chicken Lasagne": maincourseCost = 7.25; break;
            }
            totalCost = starterCost + maincourseCost + dessertCost;
            totalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }

        private void selectDesserts(object sender, EventArgs e)
        {
            switch (dessertsComboBox.Text)
            {
                case "Cake": dessertCost = 3.50; break;
                case "Ice Cream": dessertCost = 2.00; break;
                case "Chocolate": dessertCost = 1.50; break;
                case "Cookie": dessertCost = 1.25; break;
            }
            totalCost = starterCost + maincourseCost + dessertCost;
            totalCostLabel.Text = "£" + totalCost.ToString("0.00");
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
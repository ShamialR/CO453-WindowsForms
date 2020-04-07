﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit4
{
    public partial class TipsterForm : Form
    {
        private double billNumber, peopleNumber, answer;

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public TipsterForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ResultsForm ResultsScreen = new ResultsForm();
            ResultsScreen.Show();
            ResultsScreen.displayTotalBillLabel.Text = billTextBox.Text;
            ResultsScreen.displayPeopleLabel.Text = numberOfPeopleListBox.Text;
            ResultsScreen.displayEachPaysLabel.Text = billTextBox.Text;

            
            billNumber = Convert.ToDouble(ResultsScreen.displayTotalBillLabel.Text);
            peopleNumber = Convert.ToDouble(ResultsScreen.displayPeopleLabel.Text);
            answer = billNumber / peopleNumber;
            ResultsScreen.displayEachPaysLabel.Text = answer.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit1
{
    public partial class CalculatorForm : Form
    {
        private double number1, number2, result;

        private void convertToDouble()
        {
            number1 = Convert.ToDouble(firstNumberText.Text);
            number2 = Convert.ToDouble(secondNumberText.Text);
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 + number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Red;
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 - number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Blue;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 * number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Lime;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (number2 == 0)
            {
                MessageBox.Show("You cannot divide by 0!!!");
            }
            else
            {
                convertToDouble();
                result = number1 / number2;
                resultAnswerLabel.Text = result.ToString();
                this.BackColor = Color.Pink;
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            SplashForm SplashScreen = new SplashForm(); // create new SScreen form object
            SplashScreen.ShowDialog(); // show the splash screen
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            convertToDouble();
            result = Math.Pow(number1, number2);
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Yellow;
        }

        private void averageButton_Click(object sender, EventArgs e)
        {
            convertToDouble();
            result = (number1 + number2) / 2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Cyan;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            resultAnswerLabel.Text = "";
            firstNumberText.Text = "";
            secondNumberText.Text = "";
        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            QuitForm QuitScreen = new QuitForm();
            QuitScreen.ShowDialog();
        }
    }
}
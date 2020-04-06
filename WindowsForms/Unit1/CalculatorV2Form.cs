using System;
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
    /// <summary>
    /// Tasks 1.11
    /// This class is based off an actual calculator.
    /// it has 10 buttons, one for each number, the operator types,
    /// a equals/calculate button, a clear button and a quit button.
    /// The number buttons can be saved, then using a operator button,
    /// the result can be displayed.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class CalculatorV2Form : Form
    {
        private string stringNumber, operationType;
        private double number1, number2, result;
        public CalculatorV2Form()
        {
            InitializeComponent();
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            stringNumber += "0";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number1Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "1";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number2Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "2";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number3Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "3";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number4Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "4";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number5Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "5";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number6Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "6";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number7Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "7";
            resultAnswerLabel.Text = stringNumber;
        }
        private void number8Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "8";
            resultAnswerLabel.Text = stringNumber;
        }

        private void number9Button_Click_1(object sender, EventArgs e)
        {
            stringNumber += "9";
            resultAnswerLabel.Text = stringNumber;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(stringNumber);
            
            if(operationType == "+")
            {
                result = number1 + number2;
                resultAnswerLabel.Text = result.ToString();
            }
            if (operationType == "-")
            {
                result = number1 - number2;
                resultAnswerLabel.Text = result.ToString();
            }
            if (operationType == "x")
            {
                result = number1 * number2;
                resultAnswerLabel.Text = result.ToString();
            }
            if (operationType == "/")
            {
                if (number2 == 0)
                {
                    MessageBox.Show("You cannot divide by 0!!!");
                }
                result = number1 / number2;
                resultAnswerLabel.Text = result.ToString();
            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(stringNumber);
            stringNumber = "";
            operationType = "+";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(stringNumber);
            stringNumber = "";
            operationType = "/";
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(stringNumber);
            stringNumber = "";
            operationType = "-";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(stringNumber);
            stringNumber = "";
            operationType = "x";
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            resultAnswerLabel.Text = "";
            stringNumber = "";
            number1 = 0;
            number1 = 0;
        }
    }
}

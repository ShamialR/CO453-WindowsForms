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
    /// Tasks 1.5 - 1.10
    /// This class is a calculator which uses text entered by the user and
    /// buttons for the operations type to work out the result of the calculation.
    /// Each operation type also buttons change the background of the form
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class CalculatorForm : Form
    {
        private double number1, number2, result;

        private void convertToDouble()
        {
            number1 = Convert.ToDouble(firstNumberText.Text);
            number2 = Convert.ToDouble(secondNumberText.Text);
        }

        private void calculateAddition(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 + number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Red;
            calculationTypePictureBox.Image = Image.FromFile("AddSmall.png");
        }

        private void calculateSubtraction(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 - number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Blue;
            calculationTypePictureBox.Image = Image.FromFile("MinusSmall.png");
        }

        private void calculateMultiplication(object sender, EventArgs e)
        {
            convertToDouble();
            result = number1 * number2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Lime;
            calculationTypePictureBox.Image = Image.FromFile("MultiplySmall.png");
        }

        private void calculateDivision(object sender, EventArgs e)
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
                calculationTypePictureBox.Image = Image.FromFile("DivideSmall.png");
            }
        }

        private void loadCalculatorForm(object sender, EventArgs e)
        {
            SplashForm SplashScreen = new SplashForm(); // create new SScreen form object
            SplashScreen.ShowDialog(); // show the splash screen
        }

        private void calculatePower(object sender, EventArgs e)
        {
            convertToDouble();
            result = Math.Pow(number1, number2);
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Yellow;
            calculationTypePictureBox.Image = null;
        }

        private void calculateAverage(object sender, EventArgs e)
        {
            convertToDouble();
            result = (number1 + number2) / 2;
            resultAnswerLabel.Text = result.ToString();
            this.BackColor = Color.Cyan;
            calculationTypePictureBox.Image = null;
        }

        private void clearAll(object sender, EventArgs e)
        {
            resultAnswerLabel.Text = "";
            firstNumberText.Text = "";
            secondNumberText.Text = "";
            calculationTypePictureBox.Image = null;
        }

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            QuitForm QuitScreen = new QuitForm();
            QuitScreen.ShowDialog();
        }
    }
}
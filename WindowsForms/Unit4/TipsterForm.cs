using System;
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
        private double billNumber, peopleNumber, answer, tip, displayTip, totalBill;
        private double noneTip = 0, normalTip = 10, generousTip = 15, madTip = 20;
        private const double MAX_PERCENTAGE = 100;

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

            try
            {
                billNumber = Convert.ToDouble(ResultsScreen.displayTotalBillLabel.Text);
                peopleNumber = Convert.ToDouble(ResultsScreen.displayPeopleLabel.Text);
                answer = billNumber / peopleNumber;

                tipCalculator();
                
                displayTip = tip * peopleNumber;

                totalBill = billNumber + displayTip;

                answer = totalBill / peopleNumber;
                ResultsScreen.displayTotalBillLabel.Text = totalBill.ToString();
                ResultsScreen.displayTipLabel.Text = displayTip.ToString();
                ResultsScreen.displayEachPaysLabel.Text = answer.ToString();
            }
            catch
            {
                MessageBox.Show("Error in Data Entry");
            }

        }
        private void tipCalculator()
        {
            if (noneTipRadioButton.Checked)
            {
                tip = (answer / MAX_PERCENTAGE) * noneTip;
            }
            else if (normalTipRadioButton.Checked)
            {
                tip = (answer / MAX_PERCENTAGE) * normalTip;
            }
            else if (generousTipRadioButton.Checked)
            {
                tip = (answer / MAX_PERCENTAGE) * generousTip;
            }
            else if (madTipRadioButton.Checked)
            {
                tip = (answer / MAX_PERCENTAGE) * madTip;
            }
        }
    }
}

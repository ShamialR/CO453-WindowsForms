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
    /// <summary>
    /// Task 4.1 - 4.6
    /// This class allows the user to type in their bill amount,
    /// then select what sort of tip they would like to give using
    /// radio buttons, then select the number of people paying,
    /// this will decide how much the bill+tip is split, finally
    /// the calculate button will take the user to the ResultsForm.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class TipsterForm : Form
    {
        private double billNumber, peopleNumber, answer, tip, displayTip, totalBill;
        private double noneTip = 0, normalTip = 10, generousTip = 15, madTip = 20;
        private const double MAX_PERCENTAGE = 100;

        public TipsterForm()
        {
            InitializeComponent();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatePrice(object sender, EventArgs e)
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

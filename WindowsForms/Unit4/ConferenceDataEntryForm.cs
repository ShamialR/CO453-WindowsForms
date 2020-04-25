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
    /// Task 4.7
    /// This class will allow the user to type in their names, select their
    /// school from the list and what they want for dinner.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class ConferenceDataEntryForm : Form
    {
        public double oakridgeSchoolTeacherCount, royalGrammarSchoolTeacherCount, henleyCollegeTeacherCount, bucksNewUniTeacherCount, totalTeachers;
        private int displayOakBill, displayRGSBill, displayHenleyBill, displayBNUBill;
        public const double diningCost = 15, attendanceCost = 50;
        public double mealOrder = 0, totalCost;

        private void clearButton_Click(object sender, EventArgs e)
        {
            attendeeNameTextBox.Text = "";
        }

        public ConferenceDataEntryForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void switchSchoolCases()
        {
            switch (schoolNameListBox.Text)
            {
                case "Oakridge School": oakridgeSchoolTeacherCount += 1; mealOrder += 1; totalTeachers +=1; break;
                case "Royal Grammar School": royalGrammarSchoolTeacherCount += 1; mealOrder += 1; totalTeachers += 1; break;
                case "Henley College": henleyCollegeTeacherCount += 1; mealOrder += 1; totalTeachers += 1; break;
                case "Bucks New Uni": bucksNewUniTeacherCount += 1; mealOrder += 1; totalTeachers += 1; break;
            }
        }
        private void seeBillButton_Click(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();

            ConferenceSeeBillForm SeeBillScreen = new ConferenceSeeBillForm();
            SeeBillScreen.Show();

            SeeBillScreen.displayAttendeeNameLabel.Text = attendeeNameTextBox.Text;
            SeeBillScreen.displaySchoolNameLabel.Text = schoolNameListBox.Text;

            
            mealOrder += diningCost;
            SeeBillScreen.displayDiningCostLabel.Text = mealOrder.ToString();
            SeeBillScreen.displayAttendanceCostLabel.Text = attendanceCost.ToString();

            totalCost = mealOrder + attendanceCost;
            SeeBillScreen.displayTotalCostLabel.Text = totalCost.ToString();

            switchSchoolCases();

            if (schoolNameListBox.GetSelected(0) == true)
            {
                TotalsScreen.displayOakridgeBillLabel.Text += totalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(1) == true)
            {
                TotalsScreen.displayRGSBillLabel.Text += totalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(2) == true)
            {
                TotalsScreen.displayHenleyCollegeBillLabel.Text += totalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(3) == true)
            {
                TotalsScreen.displayBNUBillLabel.Text += totalCost.ToString();
            }

            if (schoolNameListBox.GetSelected(0) == true)
            {
                displayOakBill += 65;

            }
            else if (schoolNameListBox.GetSelected(1) == true)
            {
                displayRGSBill += 65;

            }
            else if (schoolNameListBox.GetSelected(2) == true)
            {
                displayHenleyBill += 65;

            }
            else if (schoolNameListBox.GetSelected(3) == true)
            {
                displayBNUBill += 65;

            }

            mealOrder = 0;
            totalCost = 0;
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();
            TotalsScreen.Show();

            TotalsScreen.displayOakridgeTeachersLabel.Text = oakridgeSchoolTeacherCount.ToString();
            TotalsScreen.displayRGSTeachersLabel.Text = royalGrammarSchoolTeacherCount.ToString();
            TotalsScreen.displayHenleyCollegeTeachersLabel.Text = henleyCollegeTeacherCount.ToString();
            TotalsScreen.displayBNULabel.Text = bucksNewUniTeacherCount.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = totalTeachers.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = totalTeachers.ToString();

            //Different method that is usable for adding price to the bill label in the ConferenceTotalsForm.

            //TotalsScreen.displayOakridgeBillLabel.Text = (oakridgeSchoolTeacherCount * 65).ToString();
            //TotalsScreen.displayRGSBillLabel.Text = (royalGrammarSchoolTeacherCount * 65).ToString();
            //TotalsScreen.displayHenleyCollegeBillLabel.Text = (henleyCollegeTeacherCount * 65).ToString();
            //TotalsScreen.displayBNUBillLabel.Text = (bucksNewUniTeacherCount * 65).ToString();

            TotalsScreen.displayOakridgeBillLabel.Text += displayOakBill;
            TotalsScreen.displayRGSBillLabel.Text += displayRGSBill;
            TotalsScreen.displayHenleyCollegeBillLabel.Text += displayHenleyBill;
            TotalsScreen.displayBNUBillLabel.Text += displayBNUBill;

        }
    }
}

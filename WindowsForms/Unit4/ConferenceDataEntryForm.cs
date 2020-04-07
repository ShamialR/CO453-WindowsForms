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
    public partial class ConferenceDataEntryForm : Form
    {
        private double oakridgeSchoolTeacherCount, royalGrammarSchoolTeacherCount, henleyCollegeTeacherCount, bucksNewUniTeacherCount, totalTeachers;
        private const double diningCost = 15, attendanceCost = 50;
        private double mealOrder, totalCost;
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
                case "Oakridge School": oakridgeSchoolTeacherCount += 1; mealOrder += 1; break;
                case "Royal Grammar School": royalGrammarSchoolTeacherCount += 1; mealOrder += 1; break;
                case "Henley College": henleyCollegeTeacherCount += 1; mealOrder += 1; break;
                case "Bucks New Uni": bucksNewUniTeacherCount += 1; mealOrder += 1; break;
            }
        }
        private void seeBillButton_Click(object sender, EventArgs e)
        {
            ConferenceSeeBillForm SeeBillScreen = new ConferenceSeeBillForm();
            SeeBillScreen.Show();

            SeeBillScreen.displayAttendeeNameLabel.Text = attendeeNameTextBox.Text;
            SeeBillScreen.displaySchoolNameLabel.Text = schoolNameListBox.Text;

            switchSchoolCases();
            mealOrder += diningCost;
            SeeBillScreen.displayDiningCostLabel.Text = mealOrder.ToString();
            SeeBillScreen.displayAttendanceCostLabel.Text = attendanceCost.ToString();

            totalCost = mealOrder + attendanceCost;
            SeeBillScreen.displayTotalCostLabel.Text = totalCost.ToString();
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();
            TotalsScreen.Show();

            switchSchoolCases();
            TotalsScreen.displayOakridgeTeachersLabel.Text = oakridgeSchoolTeacherCount.ToString();
            TotalsScreen.displayRGSTeachersLabel.Text = royalGrammarSchoolTeacherCount.ToString();
            TotalsScreen.displayHenleyCollegeTeachersLabel.Text = henleyCollegeTeacherCount.ToString();
            TotalsScreen.displayBNULabel.Text = bucksNewUniTeacherCount.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = totalTeachers.ToString();
        }
    }
}

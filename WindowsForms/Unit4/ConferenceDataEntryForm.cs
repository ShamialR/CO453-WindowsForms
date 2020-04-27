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
        public const double MAX_DINING_COST = 15, MAX_ATTENDANCE_COST = 50;

        public double OakridgeSchoolTeacherCount, RoyalGrammarSchoolTeacherCount;
        public double HenleyCollegeTeacherCount, BucksNewUniTeacherCount, TotalTeachers;
        public double MealOrder = 0, TotalCost;
        private int displayOakBill, displayRGSBill, displayHenleyBill, displayBNUBill;

        public ConferenceDataEntryForm()
        {
            InitializeComponent();
        }
        private void clearAttendeeName(object sender, EventArgs e)
        {
            attendeeNameTextBox.Text = "";
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void switchSchoolCases()
        {
            switch (schoolNameListBox.Text)
            {
                case "Oakridge School": OakridgeSchoolTeacherCount += 1; MealOrder += 1; TotalTeachers +=1; break;
                case "Royal Grammar School": RoyalGrammarSchoolTeacherCount += 1; MealOrder += 1; TotalTeachers += 1; break;
                case "Henley College": HenleyCollegeTeacherCount += 1; MealOrder += 1; TotalTeachers += 1; break;
                case "Bucks New Uni": BucksNewUniTeacherCount += 1; MealOrder += 1; TotalTeachers += 1; break;
            }
        }
        private void viewBill(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();

            ConferenceSeeBillForm SeeBillScreen = new ConferenceSeeBillForm();
            SeeBillScreen.Show();

            SeeBillScreen.displayAttendeeNameLabel.Text = attendeeNameTextBox.Text;
            SeeBillScreen.displaySchoolNameLabel.Text = schoolNameListBox.Text;

            
            MealOrder += MAX_DINING_COST;
            SeeBillScreen.displayDiningCostLabel.Text = MealOrder.ToString();
            SeeBillScreen.displayAttendanceCostLabel.Text = MAX_ATTENDANCE_COST.ToString();

            TotalCost = MealOrder + MAX_ATTENDANCE_COST;
            SeeBillScreen.displayTotalCostLabel.Text = TotalCost.ToString();

            switchSchoolCases();

            if (schoolNameListBox.GetSelected(0) == true)
            {
                TotalsScreen.displayOakridgeBillLabel.Text += TotalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(1) == true)
            {
                TotalsScreen.displayRGSBillLabel.Text += TotalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(2) == true)
            {
                TotalsScreen.displayHenleyCollegeBillLabel.Text += TotalCost.ToString();
            }
            else if (schoolNameListBox.GetSelected(3) == true)
            {
                TotalsScreen.displayBNUBillLabel.Text += TotalCost.ToString();
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

            MealOrder = 0;
            TotalCost = 0;
        }

        private void viewTotals(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();
            TotalsScreen.Show();

            TotalsScreen.displayOakridgeTeachersLabel.Text = OakridgeSchoolTeacherCount.ToString();
            TotalsScreen.displayRGSTeachersLabel.Text = RoyalGrammarSchoolTeacherCount.ToString();
            TotalsScreen.displayHenleyCollegeTeachersLabel.Text = HenleyCollegeTeacherCount.ToString();
            TotalsScreen.displayBNULabel.Text = BucksNewUniTeacherCount.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = TotalTeachers.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = TotalTeachers.ToString();

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

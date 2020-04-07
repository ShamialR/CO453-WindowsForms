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
    public partial class ConferenceSeeBillForm : Form
    {
        private double oakridgeSchoolTeacherCount, royalGrammarSchoolTeacherCount, henleyCollegeTeacherCount, bucksNewUniTeacherCount, totalTeachers;
        public ConferenceSeeBillForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBillButton_Click(object sender, EventArgs e)
        {
            ConferenceDataEntryForm DataEntryScreen = new ConferenceDataEntryForm();
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();

            switch (DataEntryScreen.schoolNameListBox.Text)
            {
                case "Oakridge School": oakridgeSchoolTeacherCount += 1; totalTeachers += 1;  break;
                case "Royal Grammar School": royalGrammarSchoolTeacherCount += 1; totalTeachers += 1; break;
                case "Henley College": henleyCollegeTeacherCount += 1; totalTeachers += 1; break;
                case "Bucks New Uni": bucksNewUniTeacherCount += 1; totalTeachers += 1; break;
            }
            TotalsScreen.displayOakridgeTeachersLabel.Text = oakridgeSchoolTeacherCount.ToString();
            TotalsScreen.displayRGSTeachersLabel.Text = royalGrammarSchoolTeacherCount.ToString();
            TotalsScreen.displayHenleyCollegeTeachersLabel.Text = henleyCollegeTeacherCount.ToString();
            TotalsScreen.displayBNULabel.Text = bucksNewUniTeacherCount.ToString();
            TotalsScreen.displayTotalTeachersLabel.Text = totalTeachers.ToString();
        }
    }
}

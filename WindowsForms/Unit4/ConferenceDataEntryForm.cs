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
        public ConferenceDataEntryForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seeBillButton_Click(object sender, EventArgs e)
        {
            ConferenceSeeBillForm SeeBillScreen = new ConferenceSeeBillForm();
            SeeBillScreen.Show();
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();
            TotalsScreen.Show();
        }
    }
}

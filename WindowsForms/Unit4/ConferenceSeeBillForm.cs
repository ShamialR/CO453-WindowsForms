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
        public ConferenceSeeBillForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            ConferenceDataEntryForm DataEntryScreen = new ConferenceDataEntryForm();
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();

            this.Close();
        }

        private void acceptBillButton_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you happy with your choice? ", "Confirm Choice", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                MessageBox.Show("Confirmed!", "Confirm Choice");
            }
        }
    }
}

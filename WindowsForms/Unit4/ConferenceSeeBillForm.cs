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
    /// Task 4.8
    /// This class will display the attendees name, their school name,
    /// the price of the ticket, price of attendance and the total cost,
    /// which will have been entered by the user in the ConferenceDataEntryForm.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class ConferenceSeeBillForm : Form
    {
        public ConferenceSeeBillForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {

            ConferenceDataEntryForm DataEntryScreen = new ConferenceDataEntryForm();
            ConferenceTotalsForm TotalsScreen = new ConferenceTotalsForm();

            this.Close();
        }

        private void acceptBill(object sender, EventArgs e)
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

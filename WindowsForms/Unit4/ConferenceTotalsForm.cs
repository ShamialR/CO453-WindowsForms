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
    /// Task 4.9
    /// This class will display the total attendance amount when the totals
    /// button is clicked on the ConferenceDataEntryForm. There will also be
    /// the attendance amount and the bill for each school displayed seperately.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class ConferenceTotalsForm : Form
    {
        public ConferenceTotalsForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

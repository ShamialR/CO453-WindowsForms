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
    /// This class will display the total bill, the amount of people
    /// paying, the tip amount then the amount each person will have
    /// to pay when the bill & tip is divided between them.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

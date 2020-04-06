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
    public partial class TipsterForm : Form
    {
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ResultsForm ResultsScreen = new ResultsForm();
            ResultsScreen.Show();
            ResultsScreen.displayTotalBillLabel.Text = billTextBox.Text;
            ResultsScreen.displayPeopleLabel.Text = numberOfPeopleListBox.Text;
            ResultsScreen.displayEachPaysLabel.Text = billTextBox.Text;
        }
    }
}

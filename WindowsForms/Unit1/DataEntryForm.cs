using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit1
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameText.Text + " " + lastNameText.Text + "\nHappy Programming";
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = " ";
        }

        private void toUpperButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void toLowerButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToLower(); 
        }
    }
}

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
    /// <summary>
    /// Tasks 1.4
    /// This class displays a message using data entered by the user
    /// the message can be changed to all upper/lower case
    /// or the message can be cleared which changes background oclour.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void clickMessageLabel(object sender, EventArgs e)
        {
            
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameText.Text + " " + lastNameText.Text + " from " + townNameText.Text + "\nHappy Programming";
        }

        private void clickLastNameLabel(object sender, EventArgs e)
        {

        }

        private void clearMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            firstNameText.Text = "";
            lastNameText.Text = "";
            townNameText.Text = "";
        }

        private void changeMessageToUpper(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void changeMessageToLower(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToLower(); 
        }

        private void changeMessage(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            firstNameText.BackColor = Color.LightBlue;
            lastNameText.BackColor = Color.LightBlue;
            townNameText.BackColor = Color.LightBlue;

            messageLabel.Text = "Get on with it " + firstNameText.Text + ".";
        }
    }
}
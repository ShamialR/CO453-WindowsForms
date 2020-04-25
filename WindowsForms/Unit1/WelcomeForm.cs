using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    /// <summary>
    /// Tasks 1.1 - 1.3
    /// This class displays a welcome message
    /// once a button is clicked the back and foreground colour of the message is changed
    /// alongside the text of the message.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void loadWelcomeForm(object sender, EventArgs e)
        {

        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showBestComputerMessage(object sender, EventArgs e)
        {
            bragLabel.Text = "Supa Dupa Computer\n Selling for £339";
            bragLabel.BackColor = Color.Aqua;
            bragLabel.ForeColor = Color.Red;
            bragLabel.Size = new System.Drawing.Size(310, 70);
        }

        private void showBestSoftwareMessage(object sender, EventArgs e)
        {
            bragLabel.Text = "C# .NET for Dumbos\n A real bargain at £29.99";
            bragLabel.BackColor = Color.Aqua;
            bragLabel.ForeColor = Color.Red;
            bragLabel.Size = new System.Drawing.Size(310, 70);
        }
    }
}

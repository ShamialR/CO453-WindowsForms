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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowButton1_Click(object sender, EventArgs e)
        {
            bragLabel.Text = "Supa Dupa Computer\n Selling for £339";
            bragLabel.BackColor = Color.Aqua;
            bragLabel.ForeColor = Color.Red;
            bragLabel.Size = new System.Drawing.Size(310, 70);
        }

        private void ShowButton2_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "C# .NET for Dumbos\n A real bargain at £29.99";
            greetingLabel.BackColor = Color.Aqua;
            greetingLabel.ForeColor = Color.Red;
            greetingLabel.Size = new System.Drawing.Size(310, 70);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit3
{
    public partial class MonkeyBashForm : Form
    {

        private int x = 0, y = 0, playerScore = 0, monkeyScore = 0;
        private Random generator = new Random();


        public MonkeyBashForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monkeyPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            monkeyPictureBox.Image = Image.FromFile("monkeySad.jpg");
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox.Left = x;
            monkeyPictureBox.Top = y;
            Refresh();

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;  
        }

    }
}

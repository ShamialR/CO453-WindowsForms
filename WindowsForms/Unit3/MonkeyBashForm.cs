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
            animationTimer.Enabled = false;
            monkeyPictureBox.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            animationTimer.Enabled = true;
            monkeyPictureBox.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void MonkeyBashForm_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("The mouse X position is " + e.X);

            monkeyPictureBox.Image = Image.FromFile("monkey.jpg");
            MessageBox.Show("HAHA, You missed me!", "Monkey");
            monkeyScore += 1;
            missesLabel.Text = "Misses: " + monkeyScore.ToString();
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
            animationTimer.Enabled = false;
        }

    }
}

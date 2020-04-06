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
    public partial class TargetForm : Form
    {

        private int x = 0, y = 0, playerScore = 0;
        private double targetPositionX = 0, targetPositionY = 0, distance = 0;
        private Random generator = new Random();

        public TargetForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = false;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            targetPictureBox.Left = x;
            targetPictureBox.Top = y;
            Refresh();
        }
    }
}

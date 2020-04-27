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
    /// <summary>
    /// Task 3.11
    /// This class is similar to the Monkay bash form in that
    /// it uses a timer which moves the object, in this case 
    /// a target, around the screen, however using panels,
    /// this time theres only one target, which the closer
    /// you get to the center the more the users score
    /// increases by, also depending on where the user clicks
    /// on the target, a different result is displayed above
    /// the score in the results group box.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class TargetForm : Form
    {

        private int x = 0, y = 0, playerScore = 0;
        private double targetPositionX = 0, targetPositionY = 0, distance = 0;
        private Random generator = new Random();

        public TargetForm()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
        }
        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopGame(object sender, EventArgs e)
        {
            animationTimer.Enabled = false;
        }

        private void moveTarget(object sender, EventArgs e)
        {
            x = generator.Next(panelBoxTarget.Width - targetPictureBox.Width);
            y = generator.Next(panelBoxTarget.Height - targetPictureBox.Height);
            targetPictureBox.Left = x;
            targetPictureBox.Top = y;
            Refresh();
        }
        private void hitTargetDistance(object sender, MouseEventArgs e)
        {
            targetPositionX = e.X;
            targetPositionY = e.Y;
            distance = ((Math.Sqrt(targetPositionX - 50)) + (Math.Sqrt(targetPositionY - 50)));

            if (distance >= 1 && distance <= 2)
            {
                playerScore += 20;
                scoreMessageLbel.Text = "Bulls Eye!!!";
            }
            else if (distance >= 4 && distance <= 5)
            {
                playerScore += 15;
                scoreMessageLbel.Text = "First Ring!!";
            }
            else if (distance >= 7 && distance <= 8)
            {
                playerScore += 10;
                scoreMessageLbel.Text = "Second Ring!";
            }
            else if (distance >= 10 && distance <= 12)
            {
                playerScore += 5;
                scoreMessageLbel.Text = "Third Ring!";
            }
            else
            {
                playerScore += 1;
                scoreMessageLbel.Text = "White Rings";
            }

            MessageBox.Show(distance.ToString());
            scoreLabel.Text = playerScore.ToString();
        }
        private void clickTarget(object sender, EventArgs e)
        {
            
        }
    }
}

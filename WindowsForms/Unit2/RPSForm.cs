using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Unit2
{
    /// <summary>
    /// Task 2.1 - 2.8
    /// This class allows the user to play a rock paper scissors game against the computer which randomly picks between rock paper and scissors with the first to reach 20 points winning
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public enum Choices
    {
        Rock,Paper,Scissors
    }
    public partial class RPSForm : Form
    {
        private const int MAX_SCORE = 20;
        private int compChoice, userChoice;
        private int userScore = 0;
        private int compScore = 0;

        public RPSForm()
        {
            InitializeComponent();
        }

        private void selectRockRadio(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Rock.jpg");
            userChoice = 1;
        }

        private void selectPaperRadio(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Paper.jpg");
            userChoice = 2;
        }

        private void selectScissorsRadio(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Scissors.jpg");
            userChoice = 3;
        }

        private void playGame(object sender, EventArgs e)
        {
            Random randomChoice = new Random();
            compChoice = randomChoice.Next(3) + 1;

            if (compChoice == 1)
            {
                computerPictureBox.Image = Image.FromFile("Rock.jpg");
            }
            else if (compChoice == 2)
            {
                computerPictureBox.Image = Image.FromFile("Paper.jpg");
            }
            else if (compChoice == 3)
            {
                computerPictureBox.Image = Image.FromFile("Scissors.jpg");
            }

            checkResults();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadRPSForm(object sender, EventArgs e)
        {
            RPSSplashForm RPSSplashScreen = new RPSSplashForm();
            RPSSplashScreen.ShowDialog();
            
        }

        private void checkResults()
        {
            if (compChoice == userChoice)
            {
                resultLabel.Text = "It’s a DRAW!";
                resultLabel.BackColor = Color.LightCoral;
                resultLabel.ForeColor = Color.Black;
                userScore++;
                compScore++;
            }
            else if (userChoice == 1 && compChoice != 2)
            {
                resultLabel.Text = "You WIN!";
                resultLabel.BackColor = Color.Cyan;
                resultLabel.ForeColor = Color.Red;
                userScore += 2;
            }
            else if (userChoice == 2 && compChoice != 3)
            {
                resultLabel.Text = "You WIN!";
                resultLabel.BackColor = Color.Cyan;
                resultLabel.ForeColor = Color.Red;
                userScore += 2;
            }
            else if (userChoice == 3 && compChoice != 1)
            {
                resultLabel.Text = "You WIN!";
                resultLabel.BackColor = Color.Cyan;
                resultLabel.ForeColor = Color.Red;
                userScore += 2;
            }
            else
            {
                resultLabel.Text = "You LOSE!";
                resultLabel.BackColor = Color.LightCoral;
                resultLabel.ForeColor = Color.Black;
                compScore += 2;
            }

            userScoreLabel.Text = userScore.ToString();
            computerScoreLabel.Text = compScore.ToString();

            RPSWin RPSWinScreen = new RPSWin();
            RPSDraw RPSDrawScreen = new RPSDraw();
            RPSLose RPSLoseScreen = new RPSLose();

            if (compScore == MAX_SCORE && userScore == MAX_SCORE)
            {
                userScore = 0;
                compScore = 0;
                RPSDrawScreen.ShowDialog();
            }
            else if (compScore == MAX_SCORE || compScore > MAX_SCORE)
            {
                userScore = 0; 
                compScore = 0;
                RPSLoseScreen.ShowDialog();
            }
            else if (userScore == MAX_SCORE || userScore > MAX_SCORE)
            {
                userScore = 0;
                compScore = 0; 
                RPSWinScreen.ShowDialog();
            }
        }


    }
}

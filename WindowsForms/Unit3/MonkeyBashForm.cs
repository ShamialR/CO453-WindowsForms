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
    /// Task 3.5 - 3.6 & 3.12
    /// This class has 5 monkeys which move across the form to
    /// random places every second. Once a monkey has been clicked
    /// on, the users score  increments by 1, if the user misses 
    /// the monkeys, the misses label is incremented by one, while
    /// also displaying a popup message box telling you hit or miss.
    /// The monkeys can start moving by pressing the  start button
    /// and pressing the stop button to stop them from moving. 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class MonkeyBashForm : Form
    {

        private int x = 0, y = 0, playerScore = 0, monkeyScore = 0;
        private Random generator = new Random();


        public MonkeyBashForm()
        {
            InitializeComponent();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hitMonkey1(object sender, EventArgs e)
        {
            stopGame(sender, e);
            monkeyPictureBox1.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            startGame(sender, e);
            monkeyPictureBox1.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void hitMonkey2(object sender, EventArgs e)
        {
            stopGame(sender, e);
            monkeyPictureBox2.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            startGame(sender, e);
            monkeyPictureBox2.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void hitMnkey3(object sender, EventArgs e)
        {
            stopGame(sender, e);
            monkeyPictureBox3.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            startGame(sender, e);
            monkeyPictureBox3.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void hitMonkey4(object sender, EventArgs e)
        {
            stopGame(sender, e);
            monkeyPictureBox4.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            startGame(sender, e);
            monkeyPictureBox4.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void hitMonkey5(object sender, EventArgs e)
        {
            stopGame(sender, e);
            monkeyPictureBox5.Image = Image.FromFile("monkeySad1.jpg");
            MessageBox.Show("Ouch! You HIT Me!", "Monkey");
            startGame(sender, e);
            monkeyPictureBox5.Image = Image.FromFile("monkey.jpg");
            playerScore += 1;
            hitsLabel.Text = "Hits: " + playerScore.ToString();
        }

        private void missMonkey(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("The mouse X position is " + e.X);

            monkeyPictureBox1.Image = Image.FromFile("monkey.jpg");
            monkeyPictureBox2.Image = Image.FromFile("monkey.jpg");
            monkeyPictureBox3.Image = Image.FromFile("monkey.jpg");
            monkeyPictureBox4.Image = Image.FromFile("monkey.jpg");
            monkeyPictureBox5.Image = Image.FromFile("monkey.jpg");
            MessageBox.Show("HAHA, You missed me!", "Monkey");
            monkeyScore += 1;
            missesLabel.Text = "Misses: " + monkeyScore.ToString();
        }

        private void moveMonkey1(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox1.Left = x;
            monkeyPictureBox1.Top = y;
            Refresh();

        }

        private void moveMonkey2(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox2.Left = x;
            monkeyPictureBox2.Top = y;
            Refresh();
        }

        private void moveMonkey3(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox3.Left = x;
            monkeyPictureBox3.Top = y;
            Refresh();
        }

        private void moveMonkey4(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox4.Left = x;
            monkeyPictureBox4.Top = y;
            Refresh();
        }

        private void moveMonkey5(object sender, EventArgs e)
        {
            x = generator.Next(this.Width - 100);
            y = generator.Next(this.Height - 100);
            monkeyPictureBox5.Left = x;
            monkeyPictureBox5.Top = y;
            Refresh();
        }

        private void startGame(object sender, EventArgs e)
        {
            animationTimer1.Enabled = true;
            animationTimer2.Enabled = true;
            animationTimer3.Enabled = true;
            animationTimer4.Enabled = true;
            animationTimer5.Enabled = true;
        }

        private void stopGame(object sender, EventArgs e)
        {
            animationTimer1.Enabled = false;
            animationTimer2.Enabled = false;
            animationTimer3.Enabled = false;
            animationTimer4.Enabled = false;
            animationTimer5.Enabled = false;
        }

        private void loadMonkeyForm(object sender, EventArgs e)
        {

        }

    }
}

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
    public partial class ChoosePictureForm : Form
    {
        public ChoosePictureForm()
        {
            InitializeComponent();
        }

        private void choiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choiceComboBox.Text)
            {
                case "Dragon": choicePictureBox.Image = Image.FromFile("Dragon.gif"); break;
                case "Godzilla": choicePictureBox.Image = Image.FromFile("Godzilla.jpg"); break;
                case "Hydra": choicePictureBox.Image = Image.FromFile("Hydra.gif"); break;
                case "Kong": choicePictureBox.Image = Image.FromFile("kong.gif"); break;
                case "Nessie": choicePictureBox.Image = Image.FromFile("Nessie.jpg"); break;
                case "Shadow": choicePictureBox.Image = Image.FromFile("Shadow.jpg"); break;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

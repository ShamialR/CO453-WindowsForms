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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}

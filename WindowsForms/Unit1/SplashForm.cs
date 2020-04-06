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
    /// <summary>
    /// Tasks 1.6
    /// This class is the entry screen, it opens first when
    /// the calculator form is opened, once it's clicked this
    /// form closes and the calculator is displayed.
    /// Author: Shamial Rashid 21905385
    /// </summary>
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

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
    /// splash form will close displaying the actual calc form.
    /// </summary>
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void splashForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splashForm_Load(object sender, EventArgs e)
        {

        }
    }
}

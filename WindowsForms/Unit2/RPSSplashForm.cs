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
    /// Tasks 2.7
    /// This class is the entry screen, it opens first when
    /// the RPS form is opened, once it's clicked this
    /// form closes and the RPS form is displayed.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class RPSSplashForm : Form
    {
        public RPSSplashForm()
        {
            InitializeComponent();
        }

        private void closeSplashForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadSplashForm(object sender, EventArgs e)
        {

        }
    }
}

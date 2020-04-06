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
    /// Tasks 1.7
    /// This class is the quit screen, it opens when in the calculator
    /// the quit button is clicked. Once this form is clicked the
    /// application is closed.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class QuitForm : Form
    {
        public QuitForm()
        {
            InitializeComponent();
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

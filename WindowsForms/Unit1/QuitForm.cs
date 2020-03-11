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
    public partial class QuitForm : Form
    {
        public QuitForm()
        {
            InitializeComponent();
        }

        private void QuitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

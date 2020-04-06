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
    /// Tasks 2.8
    /// This class is the screen displayed when the RPS
    /// game has drawn. clicking it closes this form.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class RPSDraw : Form
    {
        public RPSDraw()
        {
            InitializeComponent();
        }

        private void RPSDraw_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

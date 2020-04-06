﻿using System;
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
    /// This class is the screen displayed when the
    /// player has lost the RPS game.
    /// Clicking it closes this form.
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public partial class RPSLose : Form
    {
        public RPSLose()
        {
            InitializeComponent();
        }

        private void RPSLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session6.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void frmloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session6.form.frmlogin n = new form.frmlogin();
            n.Show();
          
        }
    }
}

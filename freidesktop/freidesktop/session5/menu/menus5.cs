﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session5.menu
{
    public partial class menus5 : Form
    {
        public menus5()
        {
            InitializeComponent();
            picarea.BackColor = Color.Aqua;
            picclose.BackColor = Color.IndianRed;
        }
        public static void ThreadProc()
        {
            Application.Run(new form.login());
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            form.login m = new form.login();
            m.Show();
            this.Visible = false;


        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picarea_Click(object sender, EventArgs e)
        {
            form.area m = new form.area();
            m.Show();
            this.Visible = false;
        }
    }
    }


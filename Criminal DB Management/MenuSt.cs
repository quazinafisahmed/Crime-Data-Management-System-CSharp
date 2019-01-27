﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criminal_DB_Management
{
    public partial class MenuSt : Form
    {
        public MenuSt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Criminal_Registration()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Criminal_Information()).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }
    }
}

﻿using QuanLyNhaSach.connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dauSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dausach frm = new Dausach();
            frm.ShowDialog();
        }
    }
}

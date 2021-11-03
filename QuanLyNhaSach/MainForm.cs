using QuanLyNhaSach.connection;
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

        private void ngonNguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgonNgu frm = new NgonNgu();
            frm.Show();
        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia frm = new TacGia();
            frm.Show();
        }

        private void nhaXuatBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXB frm = new NXB();
            frm.Show();
        }

        private void theLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoai frm = new TheLoai();
            frm.Show();
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap frm = new NhaCungCap();
            frm.Show();
        }
    }
}

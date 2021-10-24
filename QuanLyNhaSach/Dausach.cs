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
    public partial class Dausach : Form
    {
        public Dausach()
        {
            InitializeComponent();
        }
        Sach dao = new Sach();
        private void Dausach_Load(object sender, EventArgs e)
        {
            ChiTietDauSach.ReadOnly = true;
            ChiTietDauSach.RowTemplate.Height = 80;
            DataTable table = dao.getViewBook();
            this.ChiTietDauSach.DataSource = table;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)ChiTietDauSach.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ChiTietDauSach.AllowUserToAddRows = false;

        }

        public void fillGrid(DataGridView dgv, SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.DataSource = dao.getTable(command);
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv.Columns["AnhBia"];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv.AllowUserToAddRows = false;
        }

        private void ChiTietDauSach_DoubleClick(object sender, EventArgs e)
        {
            string id;
            if (ChiTietDauSach.CurrentCell.Value != DBNull.Value)
            {
                id =ChiTietDauSach.CurrentRow.Cells[0].Value.ToString();
                ChiTietSach frm = new ChiTietSach(id);
                frm.ShowDialog();
            }
            else MessageBox.Show("Lựa chọn không hợp lệ", "Chi tiết đầu sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietSach frm = new ChiTietSach("");
            frm.ShowDialog();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            ChiTietDauSach.ReadOnly = true;
            ChiTietDauSach.RowTemplate.Height = 80;
            DataTable table = dao.getViewBook();
            this.ChiTietDauSach.DataSource = table;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)ChiTietDauSach.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            ChiTietDauSach.AllowUserToAddRows = false;
        }
    }
}

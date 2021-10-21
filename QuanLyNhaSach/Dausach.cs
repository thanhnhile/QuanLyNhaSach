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
            this.ChiTietDauSach.ReadOnly = true;
            ChiTietDauSach.RowTemplate.Height = 80;
            this.ChiTietDauSach.DataSource = dao.getViewBook();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)ChiTietDauSach.Columns["AnhBia"];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.ChiTietDauSach.AllowUserToAddRows = false;
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
    }
}

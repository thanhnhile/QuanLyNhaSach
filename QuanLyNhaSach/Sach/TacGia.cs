using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class TacGia : Form
    {
        public TacGia()
        {
            InitializeComponent();
        }
        Sach dao = new Sach();
        private void TacGia_Load(object sender, EventArgs e)
        {
            dgv.ReadOnly = true;
            dgv.DataSource = dao.getViewTacGia();
            dgv.AllowUserToAddRows = false;
        }
        private void refreshDGV()
        {
            dgv.ReadOnly = true;
            dgv.DataSource = dao.getViewTacGia();
            dgv.AllowUserToAddRows = false;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nameTxt.Text.Trim() != "")
                {
                    string name = nameTxt.Text;
                    if (dao.insertTacGia(name)){
                        MessageBox.Show("Thêm thành công", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshDGV();
                    }
                    
                }
                else MessageBox.Show("Trường rỗng", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nameTxt.Text.Trim() != "")
                {
                    string name = nameTxt.Text;
                    string id = idTxt.Text;
                    if (dao.updateTacGia(id,name))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshDGV();
                    }
                   
                }
                else MessageBox.Show("Trường rỗng", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Tác giả này ? ", "Thông tin Tác Giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (this.idTxt.Text.Trim() != "")
                    {
                        string id = this.idTxt.Text;
                        if (dao.deleteTacGia(id))
                        {
                            MessageBox.Show("Xóa thành công", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshDGV();
                        }
                        
                    }
                    else MessageBox.Show("Trường rỗng", "Thông tin Tác Giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            string id;
            if (dgv.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                id = dgv.CurrentRow.Cells[0].Value.ToString();
                DataTable tg = dao.getAuthorById(id);
                this.idTxt.Text = tg.Rows[0][0].ToString();
                this.nameTxt.Text = tg.Rows[0][1].ToString();
                dgv.DataSource = dao.getListBookByAuthor(tg.Rows[0][1].ToString());
            }
            else
            {
                MessageBox.Show("Lựa chọn không hợp lệ", "Thông tin Nhà Xuất Bản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class ChiTietSach : Form
    {
        Sach dao = new Sach();
        string book_id;
        public ChiTietSach(string id)
        {
            InitializeComponent();
            book_id = id;
        }

        private void ChiTietSach_Load(object sender, EventArgs e)
        {
            DataTable table = dao.getBookByid(book_id);
            if (table.Rows.Count > 0)
            {
                this.id.Text = table.Rows[0][0].ToString();
                this.tuatxt.Text = table.Rows[0][1].ToString();
                if (table.Rows[0][2] != DBNull.Value )
                {
                    var data = (byte[])table.Rows[0][2];
                    if (data.Length > 0)
                    {
                        var stream = new MemoryStream(data);
                        anhbia.Image = Image.FromStream(stream);
                    }
                }
                this.anhbia.SizeMode = PictureBoxSizeMode.StretchImage;
                this.namxbtxt.Text = table.Rows[0][3].ToString();
                this.tgtxt.Text = table.Rows[0][4].ToString();
                this.ngngutxt.Text = table.Rows[0][5].ToString();
                this.ncctxt.Text = table.Rows[0][6].ToString();
                this.nxbtxt.Text = table.Rows[0][7].ToString();
                this.tltxt.Text = table.Rows[0][8].ToString();
                this.giatxt.Text = table.Rows[0][9].ToString();
                this.motatxt.Text = table.Rows[0][10].ToString();
            }
        }
        //String tua,int namXB,String tg,string ngonngu,string ncc,string nxb,string tl,
        //int gia,string mota
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tuaSach = this.tuatxt.Text;
                int namXB = int.Parse(this.namxbtxt.Text);
                string tacgia = this.tgtxt.Text;
                string ngongu = this.ngngutxt.Text;
                string ncc = this.ncctxt.Text;
                string nxb = this.nxbtxt.Text;
                string theloai = this.tltxt.Text;
                int gia = int.Parse(this.giatxt.Text);
                string mota = this.motatxt.Text;
                if (dao.insertViewSach(tuaSach,namXB,tacgia,ngongu,ncc,nxb,theloai,gia,mota))
                {
                    MessageBox.Show("Thêm sách thành công", "Thêm sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

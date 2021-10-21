using QuanLyNhaSach.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    class Sach
    {
        myDB db = new myDB("sa", "12345", "DESKTOP-9COB58C", "QLNS");
        public DataTable getTable(SqlCommand command)
        {
            command.Connection = db.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void fillGrid(DataGridView dgv, SqlCommand command)
        {
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 80;
            dgv.DataSource = getTable(command);
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv.Columns["AnhBia"];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv.AllowUserToAddRows = false;
        }
        public DataTable getViewBook()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select * from ChiTietDauSach");
            table = getTable(command);
            return table;
        }
        public DataTable getBookByid(String id)
        {
            SqlCommand command = new SqlCommand("select * from ChiTietDauSach Where MaSach = @id");
            command.Parameters.Add("@id", SqlDbType.Char).Value=id;
            DataTable table = getTable(command);
            return table;
        }
        /*[TuaSach]
           ,[NamXB]
           ,[TenTacGia]
           ,[TenNgonNgu]
           ,[TenNCC]
           ,[TenNXB]
           ,[TenTL]
           ,[GiaBan]
           ,[MoTa])
           */
        public bool insertViewSach(String tua,int namXB,String tg,string ngonngu,string ncc,string nxb,string tl,
            int gia,string mota)
        {
            SqlCommand command = new SqlCommand("insert into ChiTietDauSach(TuaSach,NamXB,TenTacGia,TenNgonNgu,TenNCC,TenNXB,TenTL,GiaBan,MoTa)" +
                "Values(@tua,@nam,@tg,@ngngu,@ncc,@nxb,@tl,@gia,@mota)", db.GetConnection);
            command.Parameters.Add("@tua", SqlDbType.NVarChar).Value = tua;
            command.Parameters.Add("@nam", SqlDbType.Int).Value = namXB;
            command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = tg;
            command.Parameters.Add("@ngngu", SqlDbType.NVarChar).Value = ngonngu;
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;
            command.Parameters.Add("@nxb", SqlDbType.NVarChar).Value = nxb;
            command.Parameters.Add("@tl", SqlDbType.NVarChar).Value = tl;
            command.Parameters.Add("@gia", SqlDbType.NVarChar).Value = gia;
            command.Parameters.Add("@mota", SqlDbType.Text).Value = mota;
                 db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}

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
        public  string getIdNewBook()
        {
            string id;
            SqlCommand command = new SqlCommand("SELECT [dbo].[func_NewIdSach] ()", db.GetConnection);
            DataTable table = this.getTable(command);
            id = table.Rows[0][0].ToString();
            return id;

        }
        public bool updateAnhBia(string ma, System.IO.MemoryStream anh)
        {
            SqlCommand command = new SqlCommand("update DauSach set AnhBia=@anh where MaSach = @ma", db.GetConnection);
            command.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@ma", SqlDbType.Char).Value = ma;
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
        public bool insertViewSach(string tua,int namXB,string tg,string ngonngu,string ncc,string nxb,string tl,
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
        public bool updateDauSach(string ma,string tua,int namXB,int gia,string mota, System.IO.MemoryStream anh)
        {
            SqlCommand command = new SqlCommand("exec dbo.sp_UpdateDauSach @Ma,@TuaSach,@AnhBia,@NamXB,@Gia,@Mota", db.GetConnection);
            command.Parameters.Add("@Ma", SqlDbType.Char).Value = ma;
            command.Parameters.Add("@AnhBia", SqlDbType.Image).Value = anh.ToArray();
            command.Parameters.Add("@TuaSach", SqlDbType.NVarChar).Value = tua;
            command.Parameters.Add("@NamXB", SqlDbType.Int).Value = namXB;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@Mota", SqlDbType.Text).Value = mota;
            db.openConnection();
            if (command.ExecuteNonQuery()==1)
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
        public bool deleteViewSach(string ma)
        {
            SqlCommand command = new SqlCommand("delete from ChiTietDauSach where MaSach=@ma", db.GetConnection);
            command.Parameters.Add("@ma", SqlDbType.Char).Value = ma;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            return true;
        }
    }
}

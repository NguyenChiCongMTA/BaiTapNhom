using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace QuanLyNhanSu
{
    class connect
    {
        private static string connectionString = QuanLyNhanSu.Properties.Settings.Default.QuanLyNhanSu;
        private static SqlConnection con;
        
        public connect()
        {
            
        }
        public static bool isConnect()
        {
            connectionString = QuanLyNhanSu.Properties.Settings.Default.QuanLyNhanSu;
            con = new SqlConnection(connectionString);
            bool connect = false;
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    connect = true;
                }
               else
                {
                    throw new Exception("ko ket noi");
                }
            }
            catch (Exception ex)
            {
            }
            return connect;
        }
        public static DataTable LoadData()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select HoTen,NgaySinh,QueQuan,TenPhong,HeSoLuong,SoDT,SoCMND from NHANVIEN,PHONG where NHANVIEN.MaPhong=PHONG.MaPhong";
                com.CommandText = "select * from NHANVIEN";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static bool insert(classNV s)
        {
            bool isInsert = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Add_NV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@hoten", s.hoten);
                com.Parameters.AddWithValue("@ngaysinh", s.ns);
                com.Parameters.AddWithValue("@quequan", s.quequan);
                com.Parameters.AddWithValue("@hesoluong", s.hesoluong);
                com.Parameters.AddWithValue("@maphong", s.donvi);
                com.Parameters.AddWithValue("@sodt", s.sodienthoai);
                com.Parameters.AddWithValue("@socmnd", s.socmnd);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                isInsert = i > 0 ? true : false;
            }
            return isInsert;
        }

        public static bool CheckUser(string user,string pass)
        {
            DataTable table = new DataTable();
            if (connect.isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = string.Format("select * from [dbo].[Check_Pass]({0},{1})", user, pass);
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                adap.SelectCommand = com;
                adap.Fill(table);
                return true;
                if (table != null)
                    return true;
                else return false;
            }
            else MessageBox.Show("adsfdsa");
            return false;
        }
    }
}

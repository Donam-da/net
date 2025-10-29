using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe
{
    public class ConnectSQL
    {
        private static SqlConnection GetConnection()
        {
            // Sửa chuỗi kết nối để thay đổi máy chủ và cơ sở dữ liệu
            return new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyCafe;Integrated Security=True");
        }

        private static SqlConnection cnn;

        public static void OpenConnection()
        {
            cnn = GetConnection();
            cnn.Open();
        }

        public static void CloseConnection()
        {
            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        //Hàm chạy lệnh Sql lấy dữ liệu Data Query
        public static DataTable Load(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Hàm chạy lệnh Sql thêm, xóa, sửa Non Query
        public static string RunQuery(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            CloseConnection();
            return "Success";
        }
        //Phương thức kiểm tra sự tồn tại của dữ liệu
        public static bool ExcuteReader_bool(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }

        //Phương thức trả về 1 giá trị nào đó mà ta tìm
        public static string ExecuteScalar_string(string sql)
        {
            OpenConnection();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteScalar().ToString();
        }
    }
}

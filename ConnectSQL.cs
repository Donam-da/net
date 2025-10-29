﻿using System;
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
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Overload mới cho phương thức Load để chấp nhận tham số
        public static DataTable Load(string sql, List<SqlParameter> parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        //Hàm chạy lệnh Sql thêm, xóa, sửa Non Query
        public static string RunQuery(string sql)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            return "Success";
        }

        // Overload mới cho RunQuery để chấp nhận tham số
        public static string RunQuery(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            return "Success";
        }

        //Phương thức kiểm tra sự tồn tại của dữ liệu
        public static bool ExcuteReader_bool(string sql)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        return dr.Read();
                    }
                }
            }
        }

        // Overload mới cho ExcuteReader_bool để chấp nhận tham số
        public static bool ExcuteReader_bool(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        return dr.Read();
                    }
                }
            }
        }
        //Phương thức trả về 1 giá trị nào đó mà ta tìm
        public static string ExecuteScalar_string(string sql)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        // Overload mới cho ExecuteScalar_string để chấp nhận tham số
        public static string ExecuteScalar_string(string sql, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        // Phương thức chạy nhiều lệnh trong một transaction
        public static void RunTransaction(List<Tuple<string, List<SqlParameter>>> commands)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    foreach (var commandInfo in commands)
                    {
                        using (SqlCommand cmd = new SqlCommand(commandInfo.Item1, conn, transaction))
                        {
                            cmd.Parameters.AddRange(commandInfo.Item2.ToArray());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw; // Ném lại ngoại lệ để lớp gọi có thể xử lý
                }
            }
        }
    }
}

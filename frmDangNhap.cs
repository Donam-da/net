﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmDangNhap: Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static string MatKhau;
        public static string MaNV;
        public static string Quyen;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDangNhap.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mã đăng nhập");
                txtMaDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Chưa nhập thông tin mật khẩu");
                txtMaDangNhap.Focus();
                return;
            }
            string strSQL = "SELECT * FROM NhanVien WHERE MaNV = @MaNV AND MatKhau = @MatKhau";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaNV", txtMaDangNhap.Text),
                new SqlParameter("@MatKhau", txtMatKhau.Text)
            };

            DataTable dt = ConnectSQL.Load(strSQL, parameters);
            if (dt.Rows.Count > 0)
            {
                MaNV = txtMaDangNhap.Text;
                MatKhau = txtMatKhau.Text;
                Quyen = dt.Rows[0]["Quyen"].ToString();
                frmManHinhChinh frm = new frmManHinhChinh();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin mã đăng nhập hoặc mật khẩu");
                txtMaDangNhap.Focus();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmDoanhThuTheoNhanVien: Form
    {
        public frmDoanhThuTheoNhanVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            // Sử dụng câu lệnh tham số hóa để tránh lỗi SQL Injection
            string strSQl = $@"SELECT b.TenNV, SUM(a.TongTien) AS TongTien 
                                FROM HoaDon a INNER JOIN NhanVien b ON a.MaNV = b.MaNV 
                                WHERE a.TrangThai = 1 AND a.NgayLap BETWEEN @FromDate AND @ToDate
                                GROUP BY b.TenNV
                                ORDER BY TongTien DESC";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FromDate", dtDFrom.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@ToDate", dtDTo.Value.ToString("yyyy-MM-dd"))
            };

            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQl, parameters); // Gọi hàm Load đã được tham số hóa
            dtgvData.DataSource = dt;

            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Tên nhân viên";
            dtgvData.Columns[1].HeaderText = "Tổng tiền";
            dtgvData.Columns[1].DefaultCellStyle.Format = "N0";
            dtgvData.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            if (dtgvData.Rows.Count == 0)
            {
                lblTongTien.Text = "0 VNĐ";
            }
            else
            {
                // Sử dụng DataTable.Compute để tính tổng hiệu quả hơn
                object total = dt.Compute("SUM(TongTien)", string.Empty);
                lblTongTien.Text = Convert.ToDecimal(total).ToString("N0") + " VNĐ";
            }
        }
        private void frmDoanhThuTheoNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

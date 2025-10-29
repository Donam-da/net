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
    public partial class frmLichSuHoaDon: Form
    {
        public frmLichSuHoaDon()
        {
            InitializeComponent();
        }
        private void LoadDataHoaDon()
        {
            string strSQl = @"SELECT a.MaHD, a.NgayLap, b.TenNV, c.TenKH, a.MaBan, a.TongTien, 
                                     CASE WHEN a.TrangThai = 1 THEN N'Đã thanh toán' ELSE N'Chưa thanh toán' END AS TrangThai
                              FROM HoaDon a 
                              LEFT JOIN NhanVien b ON a.MaNV = b.MaNV
                              LEFT JOIN KhachHang c ON a.MaKH = c.MaKH
                              WHERE a.NgayLap BETWEEN @FromDate AND @ToDate";
            List<SqlParameter> parameters = new List<SqlParameter> {
                new SqlParameter("@FromDate", dtDFrom.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@ToDate", dtDTo.Value.ToString("yyyy-MM-dd"))
            };
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQl, parameters);
            dtgvHD.DataSource = dt;
            frmNhanVien.SetupDataGridView(dtgvHD);
            dtgvHD.Columns[0].HeaderText = "Mã hóa đơn";
            dtgvHD.Columns[1].HeaderText = "Ngày lập";
            dtgvHD.Columns[2].HeaderText = "Tên nhân viên";
            dtgvHD.Columns[3].HeaderText = "Tên khách hàng";
            dtgvHD.Columns[4].HeaderText = "Mã bàn";   
            dtgvHD.Columns[5].HeaderText = "Tổng tiền";
            dtgvHD.Columns[6].HeaderText = "Trạng thái";
            if (dtgvHD.Rows.Count == 0)
            {
                LoadDataChiTietHoaDon("");
            }
            else
            {
                LoadDataChiTietHoaDon(dtgvHD.CurrentRow.Cells[0].Value.ToString().Trim());
            }    
        }
        private void LoadDataChiTietHoaDon(string MaHD)
        {
            string strSQl = @"SELECT a.MaHD, b.TenDU, a.SoLuong, a.DonGia, a.ThanhTien 
                              FROM ChiTietHoaDon a 
                              INNER JOIN DoUong b ON a.MaDU = b.MaDU 
                              WHERE a.MaHD = @MaHD";
            List<SqlParameter> parameters = new List<SqlParameter> { new SqlParameter("@MaHD", MaHD) };
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQl, parameters);
            dtgvCTHD.DataSource = dt;
            frmNhanVien.SetupDataGridView(dtgvCTHD);
            dtgvCTHD.Columns[0].HeaderText = "Mã hóa đơn";
            dtgvCTHD.Columns[1].HeaderText = "Tên đồ uống";
            dtgvCTHD.Columns[2].HeaderText = "Số lượng";
            dtgvCTHD.Columns[3].HeaderText = "Đơn giá";
            dtgvCTHD.Columns[4].HeaderText = "Thành tiền";
        }
        private void frmLichSuHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadDataHoaDon();
        }

        private void dtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvHD.Rows[e.RowIndex];
                LoadDataChiTietHoaDon(row.Cells[0].Value.ToString());
            }
        }
    }
}

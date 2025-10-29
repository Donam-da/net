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
    public partial class frmDoanhThuTheoNgay: Form
    {
        public frmDoanhThuTheoNgay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string strSQl = @"SELECT NgayLap, SUM(TongTien) AS TongTien FROM HoaDon 
                                WHERE TrangThai = 1 AND NgayLap BETWEEN @FromDate AND @ToDate
                                GROUP BY NgayLap";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FromDate", dtDFrom.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("@ToDate", dtDTo.Value.ToString("yyyy-MM-dd"))
            };

            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQl, parameters);
            dtgvData.DataSource = dt;
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Ngày lập";
            dtgvData.Columns[1].HeaderText = "Tổng tiền";
            if (dtgvData.Rows.Count == 0)
            {
                lblTongTien.Text = "0 VNĐ";
            }
            else
            {
                object total = dt.Compute("SUM(TongTien)", string.Empty);
                lblTongTien.Text = Convert.ToDecimal(total).ToString("N0") + " VNĐ";
            }
        }
        private void frmDoanhThuTheoNgay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

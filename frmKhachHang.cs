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
    public partial class frmKhachHang: Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string strSQl = "SELECT * FROM KhachHang WHERE TenKH LIKE @TenKH";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TenKH", "%" + txtSearch.Text + "%")
            };

            dtgvData.DataSource = ConnectSQL.Load(strSQl, parameters);
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Mã KH";
            dtgvData.Columns[1].HeaderText = "Tên KH";
            dtgvData.Columns[2].HeaderText = "SĐT";
            dtgvData.Columns[3].HeaderText = "Địa chỉ";
            if (dtgvData.Rows.Count == 0)
            {
                txtMaKH.Text = "";
                txtTenKH.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
            }
            else
            {
                DataGridViewRow drow = dtgvData.Rows[0];
                txtMaKH.Text = drow.Cells[0].Value.ToString();
                txtTenKH.Text = drow.Cells[1].Value.ToString();
                txtSDT.Text = drow.Cells[2].Value.ToString();
                txtDiaChi.Text = drow.Cells[3].Value.ToString();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã kh");
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Chưa nhập tên kh");
                txtTenKH.Focus();
                return;
            }
            string strSQL = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
            List<SqlParameter> checkParams = new List<SqlParameter> { new SqlParameter("@MaKH", txtMaKH.Text) };
            if (ConnectSQL.ExcuteReader_bool(strSQL, checkParams))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại, vui lòng tạo mã khác");
                txtMaKH.Focus();
                return;
            }
            strSQL = @"INSERT INTO KhachHang(MaKH, TenKH, SDT, DiaChi)
                       VALUES (@MaKH, @TenKH, @SDT, @DiaChi)";
            List<SqlParameter> insertParams = new List<SqlParameter>
            {
                new SqlParameter("@MaKH", txtMaKH.Text),
                new SqlParameter("@TenKH", txtTenKH.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@DiaChi", txtDiaChi.Text)
            };
            ConnectSQL.RunQuery(strSQL, insertParams);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void menuSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã kh");
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Chưa nhập tên kh");
                txtTenKH.Focus();
                return;
            }
            string MaKHSua = dtgvData.CurrentRow.Cells[0].Value.ToString().Trim();
            if (txtMaKH.Text.Trim() != MaKHSua)
            {
                string strSQLCheck = "SELECT * FROM KhachHang WHERE MaKH = @MaKH";
                List<SqlParameter> checkParams = new List<SqlParameter> { new SqlParameter("@MaKH", txtMaKH.Text.Trim()) };
                if (ConnectSQL.ExcuteReader_bool(strSQLCheck, checkParams))
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại, vui lòng tạo mã khác");
                    txtMaKH.Focus();
                    return;
                }
            }
            string strSQL = @"UPDATE KhachHang SET MaKH = @MaKH, TenKh = @TenKH, SDT = @SDT, DiaChi = @DiaChi
                              WHERE MaKH = @MaKHSua";
            List<SqlParameter> updateParams = new List<SqlParameter> {
                new SqlParameter("@MaKH", txtMaKH.Text),
                new SqlParameter("@TenKH", txtTenKH.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@DiaChi", txtDiaChi.Text),
                new SqlParameter("@MaKHSua", MaKHSua)
            };
            ConnectSQL.RunQuery(strSQL, updateParams);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string strSQL = "DELETE KhachHang WHERE MaKH = @MaKH";
                List<SqlParameter> parameters = new List<SqlParameter> { new SqlParameter("@MaKH", dtgvData.CurrentRow.Cells[0].Value.ToString().Trim()) };
                ConnectSQL.RunQuery(strSQL, parameters);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvData.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}

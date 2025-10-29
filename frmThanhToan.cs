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
    public partial class frmThanhToan: Form
    {
        public frmThanhToan()
        {
            InitializeComponent();

        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string strSQl = @"SELECT * FROM KhachHang WHERE TenKH LIKE @TenKH AND SDT LIKE @SDT AND DiaChi LIKE @DiaChi";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@TenKH", "%" + txtTenKH.Text + "%"),
                new SqlParameter("@SDT", "%" + txtSDT.Text + "%"),
                new SqlParameter("@DiaChi", "%" + txtDiaChi.Text + "%")
            };

            dtgvData.DataSource = ConnectSQL.Load(strSQl, parameters);
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Mã KH";
            dtgvData.Columns[1].HeaderText = "Tên KH";
            dtgvData.Columns[2].HeaderText = "SĐT";
            dtgvData.Columns[3].HeaderText = "Địa chỉ";
        }

        private void menuTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Chưa nhập tên kh");
                txtTenKH.Focus();
                return;
            }
            string MaKH = DateTime.Now.ToString("mmsshhddMMyyyy");
            string strSQL = @"INSERT INTO KhachHang(MaKH, TenKH, SDT, DiaChi)
                              VALUES (@MaKH, @TenKH, @SDT, @DiaChi)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", txtTenKH.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@DiaChi", txtDiaChi.Text)
            };
            ConnectSQL.RunQuery(strSQL, parameters);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để thanh toán");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thanh toán hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                List<Tuple<string, List<SqlParameter>>> commands = new List<Tuple<string, List<SqlParameter>>>();

                string sqlHoaDon = @"UPDATE HoaDon SET TrangThai = 1, MaKH = @MaKH, TongTien = @TongTien
                                     WHERE MaHD = @MaHD";
                commands.Add(new Tuple<string, List<SqlParameter>>(sqlHoaDon, new List<SqlParameter> {
                    new SqlParameter("@MaKH", dtgvData.CurrentRow.Cells["MaKH"].Value.ToString().Trim()),
                    new SqlParameter("@TongTien", frmManHinhChinh.TongTienThanhToan),
                    new SqlParameter("@MaHD", frmManHinhChinh.MaHDThanhToan)
                }));

                string sqlBan = "UPDATE Ban SET TrangThai = 0 WHERE MaBan = @MaBan";
                commands.Add(new Tuple<string, List<SqlParameter>>(sqlBan, new List<SqlParameter> {
                    new SqlParameter("@MaBan", frmManHinhChinh.MaBanThanhToan)
                }));
                ConnectSQL.RunTransaction(commands);
                MessageBox.Show("Thanh toán thành công");
                frmInHoaDon frm = new frmInHoaDon();
                frm.ShowDialog();
            }
            this.Close();
        }
    }
}

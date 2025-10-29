using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmLoaiDoUong: Form
    {
        public frmLoaiDoUong()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string strSQl = $@"SELECT * FROM LoaiDoUong WHERE TenLoai LIKE N'%{txtSearch.Text}%'";
            dtgvData.DataSource = ConnectSQL.Load(strSQl);
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Mã loại";
            dtgvData.Columns[1].HeaderText = "Tên loại";
            if (dtgvData.Rows.Count == 0)
            {
                txtMaLoai.Text = "";
                txtTenLoai.Text = "";
            }
            else
            {
                DataGridViewRow drow = dtgvData.Rows[0];
                txtMaLoai.Text = drow.Cells[0].Value.ToString();
                txtTenLoai.Text = drow.Cells[1].Value.ToString();
            }
        }

        private void frmLoaiDoUong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại");
                txtMaLoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên loại");
                txtTenLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM LoaiDoUong WHERE MaLoai = '{txtMaLoai.Text}'";
            if (ConnectSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã loại đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txtMaLoai.Focus();
                return;
            }
            strSQL = $@"INSERT INTO LoaiDoUong(MaLoai,TenLoai)
                        VALUES ('{txtMaLoai.Text}',N'{txtTenLoai.Text}')";
            ConnectSQL.RunQuery(strSQL);
            MessageBox.Show("Thêm thành công");
            LoadData();
        }

        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }

        private void menuSua_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để sửa");
                return;
            }
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại");
                txtMaLoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên loại");
                txtTenLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM LoaiDoUong WHERE MaLoai = '{txtMaLoai.Text}'";
            string MaLoaiSua = dtgvData.CurrentRow.Cells[0].Value.ToString().Trim();
            if (ConnectSQL.ExcuteReader_bool(strSQL) && txtMaLoai.Text.Trim() != MaLoaiSua)
            {
                MessageBox.Show("Mã loại đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txtMaLoai.Focus();
                return;
            }
            strSQL = $@"UPDATE LoaiDoUong SET MaLoai = '{txtMaLoai.Text}'
                        ,TenLoai = N'{txtTenLoai.Text}'
                        WHERE MaLoai = '{MaLoaiSua}'";
            ConnectSQL.RunQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvData.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value.ToString();
            }
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }

            string strCheck = $@"SELECT * FROM DoUong WHERE MaLoai = '{dtgvData.CurrentRow.Cells["MaLoai"].Value.ToString().Trim()}'";
            if(ConnectSQL.ExcuteReader_bool(strCheck))
            {
                MessageBox.Show("Dữ liệu đã phát sinh khóa ngoại trong bảng DoUong, không xóa được");
                return;
            }    
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string strSQL = $@"DELETE LoaiDoUong WHERE MaLoai = '{dtgvData.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                ConnectSQL.RunQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void menuTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frmDoUong: Form
    {
        public frmDoUong()
        {
            InitializeComponent();
        }
        
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadData()
        {
            string strSQl = $@"SELECT MaDU,TenDU,MaLoai,DonGia FROM DoUong WHERE TenDU LIKE N'%{txtSearch.Text}%'";
            dtgvData.DataSource = ConnectSQL.Load(strSQl);
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Mã đồ uống";
            dtgvData.Columns[1].HeaderText = "Tên đồ uống";
            dtgvData.Columns[2].HeaderText = "Mã loại";
            dtgvData.Columns[3].HeaderText = "Đơn giá";
            if (dtgvData.Rows.Count == 0)
            {
                txtMaDU.Text = "";
                txtTenDU.Text = "";
                txtDonGia.Text = "";
                picHinhAnh.Image = null;
            }
            else
            {
                DataGridViewRow drow = dtgvData.Rows[0];
                txtMaDU.Text = drow.Cells[0].Value.ToString();
                txtTenDU.Text = drow.Cells[1].Value.ToString();
                cboMaLoai.SelectedValue = drow.Cells[2].Value.ToString();
                txtDonGia.Text = drow.Cells[3].Value.ToString();
                string strSQL = $@"SELECT HinhAnh FROM DoUong WHERE MaDU = '{txtMaDU.Text}'";
                string result = ConnectSQL.ExecuteScalar_string(strSQL);
                if (!string.IsNullOrEmpty(result))
                {
                    picHinhAnh.Image = Base64ToImage(result);
                }    
                else
                {
                    picHinhAnh.Image = null;
                }    
            }
        }
        private void frmDoUong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboboxLoaiDoUong();
        }
        private void LoadComboboxLoaiDoUong()
        {
            string strSQL = "SELECT * FROM LoaiDoUong";
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQL);
            cboMaLoai.DataSource = dt;
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDU.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txtMaDU.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenDU.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txtTenDU.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtDonGia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại đồ uống");
                cboMaLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM DoUong WHERE MaDU = '{txtMaDU.Text}'";
            if (ConnectSQL.ExcuteReader_bool(strSQL))
            {
                MessageBox.Show("Mã đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txtMaDU.Focus();
                return;
            }
            strSQL = $@"INSERT INTO DoUong(MaDU,TenDU,MaLoai,DonGia)
                        VALUES ('{txtMaDU.Text}',N'{txtTenDU.Text}','{cboMaLoai.SelectedValue}',{txtDonGia.Text})";
            ConnectSQL.RunQuery(strSQL);
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
            if (string.IsNullOrEmpty(txtMaDU.Text))
            {
                MessageBox.Show("Chưa nhập mã đồ uống");
                txtMaDU.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenDU.Text))
            {
                MessageBox.Show("Chưa nhập tên đồ uống");
                txtTenDU.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá");
                txtDonGia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboMaLoai.Text))
            {
                MessageBox.Show("Chưa nhập mã loại đồ uống");
                cboMaLoai.Focus();
                return;
            }
            string strSQL = $@"SELECT * FROM DoUong WHERE MaDU = '{txtMaDU.Text}'";
            string MaDUSua = dtgvData.CurrentRow.Cells[0].Value.ToString().Trim();
            if (ConnectSQL.ExcuteReader_bool(strSQL) && txtMaDU.Text.Trim() != MaDUSua)
            {
                MessageBox.Show("Mã đồ uống này đã tồn tại, vui lòng tạo mã khác");
                txtMaDU.Focus();
                return;
            }
            strSQL = $@"UPDATE DoUong SET MaDU = '{txtMaDU.Text}'
                        ,TenDU = N'{txtTenDU.Text}',MaLoai = '{cboMaLoai.SelectedValue}',DonGia = {txtDonGia.Text}
                        WHERE MaDU = '{MaDUSua}'";
            ConnectSQL.RunQuery(strSQL);
            MessageBox.Show("Sửa thành công");
            LoadData();
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvData.Rows[e.RowIndex];
                txtMaDU.Text = row.Cells["MaDU"].Value.ToString();
                txtTenDU.Text = row.Cells["TenDU"].Value.ToString();
                cboMaLoai.SelectedValue = row.Cells["MaLoai"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();

                string strSQL = $@"SELECT HinhAnh FROM DoUong WHERE MaDU = '{txtMaDU.Text}'";
                string result = ConnectSQL.ExecuteScalar_string(strSQL);
                if (!string.IsNullOrEmpty(result))
                {
                    picHinhAnh.Image = Base64ToImage(result);
                }
                else
                {
                    picHinhAnh.Image = null;
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            // Chuyển chuỗi base64 thành mảng byte
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Tạo stream từ byte
            using (var ms = new MemoryStream(imageBytes))
            {
                // Chuyển stream thành hình ảnh
                return Image.FromStream(ms);
            }
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
                string strSQL = $@"DELETE DoUong WHERE MaDU = '{dtgvData.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                ConnectSQL.RunQuery(strSQL);
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void menuXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaDU.Text = "";
            txtTenDU.Text = "";
            txtDonGia.Text = "";
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(picHinhAnh.Image == null && dtgvData.Rows.Count > 0) //Kiểm tra xem có dữ liệu để thêm hình chưa
            {
                //Mở hộp thoại lên để chọn hình
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Chọn ảnh";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Lấy tên của hình
                        string imagePath = openFileDialog.FileName;
                        //Hiển thị hinh lên picturebox
                        picHinhAnh.Image = Image.FromFile(imagePath);
                        //convert hình sang base64
                        string base64String = ConvertImageToBase64(picHinhAnh.Image);
                        //Tiến hình cập nhật vào SQL
                        string strSQL = $@"UPDATE DoUong SET HinhAnh = '{base64String}' 
                                            WHERE MaDU = '{dtgvData.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                        ConnectSQL.RunQuery(strSQL);
                        MessageBox.Show("Thêm hình thành công");
                        LoadData();
                    }
                }
            }   
            else
            {
                MessageBox.Show("Đồ uống đã có hình, nếu muốn sửa, hãy xóa hình và thêm lại hình khác");
                return;
            }    
        }
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void btnXoaHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dtgvData.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string strSQL = $@"UPDATE DoUong SET HinhAnh = NULL WHERE MaDU = '{dtgvData.CurrentRow.Cells[0].Value.ToString().Trim()}'";
                ConnectSQL.RunQuery(strSQL);
                picHinhAnh.Image = null;
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}

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
    public partial class frmDoiMatKhau: Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            //Kiểm tra mật khẩu cũ có trùng khớp không
            if(txtMatKhauCu.Text != frmDangNhap.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không trùng khớp");
                txtMatKhauCu.Focus();
                return;
            }    
            //Kiểm tra mật khẩu mới bắt buộc nhập
            if(string.IsNullOrEmpty(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Mật khẩu mới không được trống");
                txtMatKhauMoi.Focus();
                return;
            }    
            //Kiểm tra nhập lại mật khẩu có khớp không
            if(txtMatKhauMoi.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp");
                txtXacNhanMatKhau.Focus();
                return;
            }
            string strSQL = $@"UPDATE NhanVien SET MatKhau = '{txtMatKhauMoi.Text}' WHERE MaNV = '{frmDangNhap.MaNV}'";
            ConnectSQL.RunQuery(strSQL);
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmDoanhThuTheoNhanVien: Form
    {
        public frmDoanhThuTheoNhanVien()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string strSQl = $@"SELECT b.TenNV,SUM(TongTien) AS TongTien 
                                FROM HoaDon a INNER JOIN NhanVien b ON a.MaNV = b.MaNV 
                                WHERE NgayLap BETWEEN '{dtDFrom.Value.ToString("yyyyMMdd")}'
                                              AND '{dtDTo.Value.ToString("yyyyMMdd")}'
                                GROUP BY  b.TenNV";
            DataTable dt = new DataTable();
            dt = ConnectSQL.Load(strSQl);
            dtgvData.DataSource = dt;
            frmNhanVien.SetupDataGridView(dtgvData);
            dtgvData.Columns[0].HeaderText = "Tên nhân viên";
            dtgvData.Columns[1].HeaderText = "Tổng tiền";
            if (dtgvData.Rows.Count == 0)
            {
                lblTongTien.Text = "0 VNĐ";
            }
            else
            {
                decimal total = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += decimal.Parse(dt.Rows[i]["TongTien"].ToString());
                }
                lblTongTien.Text = total.ToString("N0");
            }
        }
        private void frmDoanhThuTheoNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

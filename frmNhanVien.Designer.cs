namespace QuanLyCafe
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuTimKiem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoaTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(161, 44);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(199, 24);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(161, 78);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(199, 24);
            this.txtTenNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người dùng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(620, 42);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(199, 24);
            this.txtMatKhau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(620, 75);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 24);
            this.txtSDT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(161, 111);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(657, 24);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(1, 177);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.Size = new System.Drawing.Size(848, 318);
            this.dtgvData.TabIndex = 10;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            this.dtgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvData_CellFormatting);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(472, 510);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 24);
            this.txtSearch.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 513);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm kiếm theo tên";
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("menuTimKiem.Image")));
            this.menuTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuTimKiem.Location = new System.Drawing.Point(680, 502);
            this.menuTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(140, 42);
            this.menuTimKiem.TabIndex = 13;
            this.menuTimKiem.Text = "Tìm kiếm";
            this.menuTimKiem.UseVisualStyleBackColor = true;
            this.menuTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThem,
            this.menuSua,
            this.menuXoa,
            this.menuXoaTrang,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuThem
            // 
            this.menuThem.Image = ((System.Drawing.Image)(resources.GetObject("menuThem.Image")));
            this.menuThem.Name = "menuThem";
            this.menuThem.Size = new System.Drawing.Size(87, 27);
            this.menuThem.Text = "Thêm";
            this.menuThem.Click += new System.EventHandler(this.menuThem_Click);
            // 
            // menuSua
            // 
            this.menuSua.Image = ((System.Drawing.Image)(resources.GetObject("menuSua.Image")));
            this.menuSua.Name = "menuSua";
            this.menuSua.Size = new System.Drawing.Size(72, 27);
            this.menuSua.Text = "Sửa";
            this.menuSua.Click += new System.EventHandler(this.menuSua_Click);
            // 
            // menuXoa
            // 
            this.menuXoa.Image = ((System.Drawing.Image)(resources.GetObject("menuXoa.Image")));
            this.menuXoa.Name = "menuXoa";
            this.menuXoa.Size = new System.Drawing.Size(73, 27);
            this.menuXoa.Text = "Xóa";
            this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
            // 
            // menuXoaTrang
            // 
            this.menuXoaTrang.Image = ((System.Drawing.Image)(resources.GetObject("menuXoaTrang.Image")));
            this.menuXoaTrang.Name = "menuXoaTrang";
            this.menuXoaTrang.Size = new System.Drawing.Size(119, 27);
            this.menuXoaTrang.Text = "Xóa trắng";
            this.menuXoaTrang.Click += new System.EventHandler(this.menuXoaTrang_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = ((System.Drawing.Image)(resources.GetObject("menuThoat.Image")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(88, 27);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Location = new System.Drawing.Point(161, 144);
            this.cboQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(199, 24);
            this.cboQuyen.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Quyền";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(849, 554);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách người dùng";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button menuTimKiem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuThem;
        private System.Windows.Forms.ToolStripMenuItem menuSua;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
        private System.Windows.Forms.ToolStripMenuItem menuXoaTrang;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label label7;
    }
}
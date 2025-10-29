namespace QuanLyCafe
{
    partial class frmDoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoUong));
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.txtTenDU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDU = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuXoaTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.btnThemHinh = new System.Windows.Forms.LinkLabel();
            this.btnXoaHinh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // menuThoat
            // 
            this.menuThoat.Image = ((System.Drawing.Image)(resources.GetObject("menuThoat.Image")));
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(69, 21);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuXoa
            // 
            this.menuXoa.Image = ((System.Drawing.Image)(resources.GetObject("menuXoa.Image")));
            this.menuXoa.Name = "menuXoa";
            this.menuXoa.Size = new System.Drawing.Size(59, 21);
            this.menuXoa.Text = "Xóa";
            this.menuXoa.Click += new System.EventHandler(this.menuXoa_Click);
            // 
            // menuSua
            // 
            this.menuSua.Image = ((System.Drawing.Image)(resources.GetObject("menuSua.Image")));
            this.menuSua.Name = "menuSua";
            this.menuSua.Size = new System.Drawing.Size(58, 21);
            this.menuSua.Text = "Sửa";
            this.menuSua.Click += new System.EventHandler(this.menuSua_Click);
            // 
            // menuThem
            // 
            this.menuThem.Image = ((System.Drawing.Image)(resources.GetObject("menuThem.Image")));
            this.menuThem.Name = "menuThem";
            this.menuThem.Size = new System.Drawing.Size(68, 21);
            this.menuThem.Text = "Thêm";
            this.menuThem.Click += new System.EventHandler(this.menuThem_Click);
            // 
            // menuTimKiem
            // 
            this.menuTimKiem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("menuTimKiem.Image")));
            this.menuTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuTimKiem.Location = new System.Drawing.Point(579, 464);
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(105, 34);
            this.menuTimKiem.TabIndex = 37;
            this.menuTimKiem.Text = "Tìm kiếm";
            this.menuTimKiem.UseVisualStyleBackColor = true;
            this.menuTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(423, 470);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 21);
            this.txtSearch.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tìm kiếm theo tên";
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(1, 189);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(686, 269);
            this.dtgvData.TabIndex = 34;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            // 
            // txtTenDU
            // 
            this.txtTenDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDU.Location = new System.Drawing.Point(143, 72);
            this.txtTenDU.Name = "txtTenDU";
            this.txtTenDU.Size = new System.Drawing.Size(150, 21);
            this.txtTenDU.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên đồ uống";
            // 
            // txtMaDU
            // 
            this.txtMaDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDU.Location = new System.Drawing.Point(143, 45);
            this.txtMaDU.Name = "txtMaDU";
            this.txtMaDU.Size = new System.Drawing.Size(150, 21);
            this.txtMaDU.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThem,
            this.menuSua,
            this.menuXoa,
            this.menuXoaTrang,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 25);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuXoaTrang
            // 
            this.menuXoaTrang.Image = ((System.Drawing.Image)(resources.GetObject("menuXoaTrang.Image")));
            this.menuXoaTrang.Name = "menuXoaTrang";
            this.menuXoaTrang.Size = new System.Drawing.Size(94, 21);
            this.menuXoaTrang.Text = "Xóa trắng";
            this.menuXoaTrang.Click += new System.EventHandler(this.menuXoaTrang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã đồ uống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã loại đồ uống";
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(143, 99);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(150, 21);
            this.cboMaLoai.TabIndex = 40;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(143, 124);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(150, 21);
            this.txtDonGia.TabIndex = 42;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Đơn giá";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picHinhAnh.Location = new System.Drawing.Point(370, 38);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(197, 134);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 43;
            this.picHinhAnh.TabStop = false;
            // 
            // btnThemHinh
            // 
            this.btnThemHinh.AutoSize = true;
            this.btnThemHinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHinh.Location = new System.Drawing.Point(573, 80);
            this.btnThemHinh.Name = "btnThemHinh";
            this.btnThemHinh.Size = new System.Drawing.Size(68, 16);
            this.btnThemHinh.TabIndex = 44;
            this.btnThemHinh.TabStop = true;
            this.btnThemHinh.Text = "Thêm hình";
            this.btnThemHinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnThemHinh_LinkClicked);
            // 
            // btnXoaHinh
            // 
            this.btnXoaHinh.AutoSize = true;
            this.btnXoaHinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHinh.LinkColor = System.Drawing.Color.Red;
            this.btnXoaHinh.Location = new System.Drawing.Point(573, 107);
            this.btnXoaHinh.Name = "btnXoaHinh";
            this.btnXoaHinh.Size = new System.Drawing.Size(57, 16);
            this.btnXoaHinh.TabIndex = 45;
            this.btnXoaHinh.TabStop = true;
            this.btnXoaHinh.Text = "Xóa hình";
            this.btnXoaHinh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnXoaHinh_LinkClicked);
            // 
            // frmDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(687, 505);
            this.Controls.Add(this.btnXoaHinh);
            this.Controls.Add(this.btnThemHinh);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.txtTenDU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDU);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frmDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đồ uống";
            this.Load += new System.EventHandler(this.frmDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
        private System.Windows.Forms.ToolStripMenuItem menuSua;
        private System.Windows.Forms.ToolStripMenuItem menuThem;
        private System.Windows.Forms.Button menuTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.TextBox txtTenDU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDU;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuXoaTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.LinkLabel btnThemHinh;
        private System.Windows.Forms.LinkLabel btnXoaHinh;
    }
}
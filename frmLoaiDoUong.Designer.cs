namespace QuanLyCafe
{
    partial class frmLoaiDoUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDoUong));
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiem = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuXoaTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.menuTimKiem.Location = new System.Drawing.Point(510, 412);
            this.menuTimKiem.Name = "menuTimKiem";
            this.menuTimKiem.Size = new System.Drawing.Size(105, 34);
            this.menuTimKiem.TabIndex = 28;
            this.menuTimKiem.Text = "Tìm kiếm";
            this.menuTimKiem.UseVisualStyleBackColor = true;
            this.menuTimKiem.Click += new System.EventHandler(this.menuTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(354, 418);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 21);
            this.txtSearch.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tìm kiếm theo tên";
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(1, 105);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(636, 301);
            this.dtgvData.TabIndex = 25;
            this.dtgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellClick);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(121, 67);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(150, 21);
            this.txtTenLoai.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(121, 40);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(150, 21);
            this.txtMaLoai.TabIndex = 16;
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
            this.menuStrip1.Size = new System.Drawing.Size(637, 25);
            this.menuStrip1.TabIndex = 29;
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
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã loại";
            // 
            // frmLoaiDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.menuTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại đồ uống";
            this.Load += new System.EventHandler(this.frmLoaiDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuXoaTrang;
        private System.Windows.Forms.Label label1;
    }
}
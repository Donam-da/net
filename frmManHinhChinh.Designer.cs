namespace QuanLyCafe
{
    partial class frmManHinhChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTenDoUong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBanDaChon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLDU = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoUong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoanhThuNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeDoanhThuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichSuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDX = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lstBan = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.dtgvDoUong = new System.Windows.Forms.DataGridView();
            this.menuHangBanChay = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoUong)).BeginInit();
            this.SuspendLayout();
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSoLuong.Location = new System.Drawing.Point(675, 57);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(81, 27);
            this.nmSoLuong.TabIndex = 570;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(511, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 569;
            this.label1.Text = "SỐ LƯỢNG :";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1096, 112);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(247, 37);
            this.btnXoa.TabIndex = 568;
            this.btnXoa.Text = "Xóa đồ uống";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(764, 53);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 37);
            this.btnThem.TabIndex = 567;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(912, 110);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(93, 37);
            this.btnTim.TabIndex = 575;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTenDoUong
            // 
            this.txtTenDoUong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTenDoUong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoUong.ForeColor = System.Drawing.Color.Black;
            this.txtTenDoUong.Location = new System.Drawing.Point(700, 114);
            this.txtTenDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDoUong.Name = "txtTenDoUong";
            this.txtTenDoUong.Size = new System.Drawing.Size(203, 26);
            this.txtTenDoUong.TabIndex = 574;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(519, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 21);
            this.label3.TabIndex = 573;
            this.label3.Text = "Tìm theo tên đồ uống";
            // 
            // btnBanDaChon
            // 
            this.btnBanDaChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBanDaChon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBanDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanDaChon.ForeColor = System.Drawing.Color.White;
            this.btnBanDaChon.Location = new System.Drawing.Point(231, 53);
            this.btnBanDaChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBanDaChon.Name = "btnBanDaChon";
            this.btnBanDaChon.Size = new System.Drawing.Size(195, 37);
            this.btnBanDaChon.TabIndex = 566;
            this.btnBanDaChon.Text = "Chưa chọn bàn";
            this.btnBanDaChon.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 565;
            this.label8.Text = "BÀN ĐANG CHỌN :";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(1184, 742);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 26);
            this.lblTongTien.TabIndex = 564;
            this.lblTongTien.Text = "O VNĐ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1091, 745);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 563;
            this.label2.Text = "TỔNG:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(1671, 736);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(195, 37);
            this.btnThanhToan.TabIndex = 562;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(1095, 154);
            this.dtgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.Size = new System.Drawing.Size(773, 575);
            this.dtgvHoaDon.TabIndex = 561;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1725, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 560;
            this.pictureBox1.TabStop = false;
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuThongTinCaNhan});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(261, 28);
            this.menuNhanVien.Text = "Nhân viên - Tài khoản";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // menuThongTinCaNhan
            // 
            this.menuThongTinCaNhan.Name = "menuThongTinCaNhan";
            this.menuThongTinCaNhan.Size = new System.Drawing.Size(261, 28);
            this.menuThongTinCaNhan.Text = "Thông tin cá nhân";
            this.menuThongTinCaNhan.Click += new System.EventHandler(this.menuThongTinCaNhan_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLDU,
            this.menuDoUong,
            this.menuBan});
            this.btnDanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMuc.Image")));
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(123, 27);
            this.btnDanhMuc.Text = "Danh mục";
            // 
            // menuLDU
            // 
            this.menuLDU.Name = "menuLDU";
            this.menuLDU.Size = new System.Drawing.Size(195, 28);
            this.menuLDU.Text = "Loại đồ uống";
            this.menuLDU.Click += new System.EventHandler(this.menuLDU_Click);
            // 
            // menuDoUong
            // 
            this.menuDoUong.Name = "menuDoUong";
            this.menuDoUong.Size = new System.Drawing.Size(195, 28);
            this.menuDoUong.Text = "Đồ uống";
            this.menuDoUong.Click += new System.EventHandler(this.menuDoUong_Click);
            // 
            // menuBan
            // 
            this.menuBan.Name = "menuBan";
            this.menuBan.Size = new System.Drawing.Size(195, 28);
            this.menuBan.Text = "Bàn";
            this.menuBan.Click += new System.EventHandler(this.menuBan_Click);
            // 
            // menuKH
            // 
            this.menuKH.Image = ((System.Drawing.Image)(resources.GetObject("menuKH.Image")));
            this.menuKH.Name = "menuKH";
            this.menuKH.Size = new System.Drawing.Size(197, 27);
            this.menuKH.Text = "Quản lý khách hàng";
            this.menuKH.Click += new System.EventHandler(this.menuKH_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoanhThuNgay,
            this.menuThongKeDoanhThuNV,
            this.menuLichSuHoaDon,
            this.menuHangBanChay});
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // menuDoanhThuNgay
            // 
            this.menuDoanhThuNgay.Name = "menuDoanhThuNgay";
            this.menuDoanhThuNgay.Size = new System.Drawing.Size(370, 28);
            this.menuDoanhThuNgay.Text = "Thống kê doanh thu theo ngày";
            this.menuDoanhThuNgay.Click += new System.EventHandler(this.menuDoanhThuNgay_Click);
            // 
            // menuThongKeDoanhThuNV
            // 
            this.menuThongKeDoanhThuNV.Name = "menuThongKeDoanhThuNV";
            this.menuThongKeDoanhThuNV.Size = new System.Drawing.Size(370, 28);
            this.menuThongKeDoanhThuNV.Text = "Thống kê doanh thu theo nhân viên";
            this.menuThongKeDoanhThuNV.Click += new System.EventHandler(this.menuThongKeDoanhThuNV_Click);
            // 
            // menuLichSuHoaDon
            // 
            this.menuLichSuHoaDon.Name = "menuLichSuHoaDon";
            this.menuLichSuHoaDon.Size = new System.Drawing.Size(370, 28);
            this.menuLichSuHoaDon.Text = "Xem lịch sử hóa đơn";
            this.menuLichSuHoaDon.Click += new System.EventHandler(this.menuLichSuHoaDon_Click);
            // 
            // btnDX
            // 
            this.btnDX.Image = ((System.Drawing.Image)(resources.GetObject("btnDX.Image")));
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(123, 27);
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.btnDanhMuc,
            this.menuKH,
            this.thốngKêToolStripMenuItem,
            this.btnDX});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1868, 31);
            this.menuStrip1.TabIndex = 558;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lstBan
            // 
            this.lstBan.HideSelection = false;
            this.lstBan.Location = new System.Drawing.Point(7, 154);
            this.lstBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBan.Name = "lstBan";
            this.lstBan.Size = new System.Drawing.Size(476, 628);
            this.lstBan.TabIndex = 577;
            this.lstBan.UseCompatibleStateImageBehavior = false;
            this.lstBan.SelectedIndexChanged += new System.EventHandler(this.lstBan_SelectedIndexChanged);
            this.lstBan.Click += new System.EventHandler(this.lstBan_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "banconguoi.png");
            this.imageList1.Images.SetKeyName(1, "bantrong.jpg");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNo);
            this.groupBox2.Controls.Add(this.rbYes);
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Location = new System.Drawing.Point(7, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(477, 49);
            this.groupBox2.TabIndex = 578;
            this.groupBox2.TabStop = false;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(272, 18);
            this.rbNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(93, 22);
            this.rbNo.TabIndex = 2;
            this.rbNo.Text = "Bàn trống";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(131, 17);
            this.rbYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(114, 22);
            this.rbYes.TabIndex = 1;
            this.rbYes.Text = "Bàn có người";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(9, 17);
            this.rbAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(101, 22);
            this.rbAll.TabIndex = 0;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất cả bàn";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // dtgvDoUong
            // 
            this.dtgvDoUong.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDoUong.Location = new System.Drawing.Point(492, 154);
            this.dtgvDoUong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDoUong.Name = "dtgvDoUong";
            this.dtgvDoUong.RowHeadersWidth = 51;
            this.dtgvDoUong.Size = new System.Drawing.Size(593, 629);
            this.dtgvDoUong.TabIndex = 579;
            // 
            // menuHangBanChay
            // 
            this.menuHangBanChay.Name = "menuHangBanChay";
            this.menuHangBanChay.Size = new System.Drawing.Size(370, 28);
            this.menuHangBanChay.Text = "Top hàng bán chạy";
            this.menuHangBanChay.Click += new System.EventHandler(this.menuHangBanChay_Click);
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1868, 784);
            this.Controls.Add(this.dtgvDoUong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstBan);
            this.Controls.Add(this.nmSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTenDoUong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBanDaChon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cafe";
            this.Load += new System.EventHandler(this.frmManHinhChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDoUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        internal System.Windows.Forms.TextBox txtTenDoUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBanDaChon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem btnDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuLDU;
        private System.Windows.Forms.ToolStripMenuItem menuDoUong;
        private System.Windows.Forms.ToolStripMenuItem menuBan;
        private System.Windows.Forms.ToolStripMenuItem menuKH;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDoanhThuNgay;
        private System.Windows.Forms.ToolStripMenuItem menuThongKeDoanhThuNV;
        private System.Windows.Forms.ToolStripMenuItem menuLichSuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem btnDX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lstBan;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.DataGridView dtgvDoUong;
        private System.Windows.Forms.ToolStripMenuItem menuHangBanChay;
    }
}
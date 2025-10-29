namespace QuanLyCafe
{
    partial class frmDoanhThuTheoNhanVien
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(452, 518);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(88, 26);
            this.lblTongTien.TabIndex = 585;
            this.lblTongTien.Text = "O VNĐ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(359, 521);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 584;
            this.label3.Text = "TỔNG:";
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(21, 53);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.Size = new System.Drawing.Size(960, 454);
            this.dtgvData.TabIndex = 583;
            this.dtgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellContentClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(787, 9);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(195, 37);
            this.btnThanhToan.TabIndex = 582;
            this.btnThanhToan.Text = "Lọc dữ liệu";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 581;
            this.label2.Text = "Đến ngày";
            // 
            // dtDTo
            // 
            this.dtDTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDTo.Location = new System.Drawing.Point(501, 12);
            this.dtDTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDTo.Name = "dtDTo";
            this.dtDTo.Size = new System.Drawing.Size(237, 27);
            this.dtDTo.TabIndex = 580;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 579;
            this.label1.Text = "Từ ngày";
            // 
            // dtDFrom
            // 
            this.dtDFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDFrom.Location = new System.Drawing.Point(101, 12);
            this.dtDFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDFrom.Name = "dtDFrom";
            this.dtDFrom.Size = new System.Drawing.Size(221, 27);
            this.dtDFrom.TabIndex = 578;
            // 
            // frmDoanhThuTheoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(999, 554);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDFrom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDoanhThuTheoNhanVien";
            this.Text = "Thống kê doanh thu theo nhân viên";
            this.Load += new System.EventHandler(this.frmDoanhThuTheoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDFrom;
    }
}
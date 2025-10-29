namespace QuanLyCafe
{
    partial class frmDoanhThuTheoNgay
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
            this.dtDFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDTo = new System.Windows.Forms.DateTimePicker();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDFrom
            // 
            this.dtDFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDFrom.Location = new System.Drawing.Point(75, 8);
            this.dtDFrom.Name = "dtDFrom";
            this.dtDFrom.Size = new System.Drawing.Size(167, 23);
            this.dtDFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // dtDTo
            // 
            this.dtDTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDTo.Location = new System.Drawing.Point(375, 8);
            this.dtDTo.Name = "dtDTo";
            this.dtDTo.Size = new System.Drawing.Size(179, 23);
            this.dtDTo.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(589, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(146, 30);
            this.btnThanhToan.TabIndex = 574;
            this.btnThanhToan.Text = "Lọc dữ liệu";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(15, 41);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(720, 369);
            this.dtgvData.TabIndex = 575;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(338, 419);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 22);
            this.lblTongTien.TabIndex = 577;
            this.lblTongTien.Text = "O VNĐ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(268, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 576;
            this.label3.Text = "TỔNG:";
            // 
            // frmDoanhThuTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDFrom);
            this.Name = "frmDoanhThuTheoNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu theo ngày";
            this.Load += new System.EventHandler(this.frmDoanhThuTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDTo;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
    }
}
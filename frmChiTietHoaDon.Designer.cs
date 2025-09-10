namespace quanlysanpham
{
    partial class frmChiTietHoaDon
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtGhiChu = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuong = new TextBox();
            txtMaCTHD = new TextBox();
            cbMaSP = new ComboBox();
            cbMaHD = new ComboBox();
            dgvChiTietHoaDon = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 40);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "MaCTHD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 114);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 1;
            label2.Text = "MaHD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 174);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 2;
            label3.Text = "MaSP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 259);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 3;
            label4.Text = "SoLuong";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 348);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 4;
            label5.Text = "GiaBan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 433);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 5;
            label6.Text = "GhiChu";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(694, 426);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(702, 326);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(200, 39);
            txtGiaBan.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(702, 256);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(200, 39);
            txtSoLuong.TabIndex = 8;
            // 
            // txtMaCTHD
            // 
            txtMaCTHD.Location = new Point(702, 33);
            txtMaCTHD.Name = "txtMaCTHD";
            txtMaCTHD.Size = new Size(200, 39);
            txtMaCTHD.TabIndex = 9;
            // 
            // cbMaSP
            // 
            cbMaSP.FormattingEnabled = true;
            cbMaSP.Location = new Point(702, 192);
            cbMaSP.Name = "cbMaSP";
            cbMaSP.Size = new Size(242, 40);
            cbMaSP.TabIndex = 10;
            // 
            // cbMaHD
            // 
            cbMaHD.FormattingEnabled = true;
            cbMaHD.Location = new Point(702, 114);
            cbMaHD.Name = "cbMaHD";
            cbMaHD.Size = new Size(242, 40);
            cbMaHD.TabIndex = 11;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Location = new Point(414, 512);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersWidth = 82;
            dgvChiTietHoaDon.Size = new Size(480, 300);
            dgvChiTietHoaDon.TabIndex = 12;
            dgvChiTietHoaDon.CellContentClick += dgvChiTietHoaDon_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(294, 968);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(672, 950);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1044, 950);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 1070);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvChiTietHoaDon);
            Controls.Add(cbMaHD);
            Controls.Add(cbMaSP);
            Controls.Add(txtMaCTHD);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGiaBan);
            Controls.Add(txtGhiChu);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmChiTietHoaDon";
            Text = "frmChiTietHoaDon";
            Load += frmChiTietHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtGhiChu;
        private TextBox txtGiaBan;
        private TextBox txtSoLuong;
        private TextBox txtMaCTHD;
        private ComboBox cbMaSP;
        private ComboBox cbMaHD;
        private DataGridView dgvChiTietHoaDon;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
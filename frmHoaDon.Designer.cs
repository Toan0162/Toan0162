namespace quanlysanpham
{
    partial class frmHoaDon
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
            label7 = new Label();
            txtMaHD = new TextBox();
            txtGhiChu = new TextBox();
            txtTongTien = new TextBox();
            cbPhuongThuc = new ComboBox();
            cbMaKH = new ComboBox();
            cbMaNV = new ComboBox();
            dgvHoaDon = new DataGridView();
            dtpNgayBan = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 73);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "MaHD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 152);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 1;
            label2.Text = "MaKH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 244);
            label3.Name = "label3";
            label3.Size = new Size(81, 32);
            label3.TabIndex = 2;
            label3.Text = "MaNV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 331);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 3;
            label4.Text = "NgayBan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 402);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 4;
            label5.Text = "TongTien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 468);
            label6.Name = "label6";
            label6.Size = new Size(267, 32);
            label6.TabIndex = 5;
            label6.Text = "PhuongThucThanhToan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(250, 545);
            label7.Name = "label7";
            label7.Size = new Size(96, 32);
            label7.TabIndex = 6;
            label7.Text = "GhiCHu";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(576, 66);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(200, 39);
            txtMaHD.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(576, 538);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 8;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(576, 395);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(200, 39);
            txtTongTien.TabIndex = 9;
            // 
            // cbPhuongThuc
            // 
            cbPhuongThuc.FormattingEnabled = true;
            cbPhuongThuc.Location = new Point(576, 460);
            cbPhuongThuc.Name = "cbPhuongThuc";
            cbPhuongThuc.Size = new Size(242, 40);
            cbPhuongThuc.TabIndex = 10;
            // 
            // cbMaKH
            // 
            cbMaKH.FormattingEnabled = true;
            cbMaKH.Location = new Point(576, 144);
            cbMaKH.Name = "cbMaKH";
            cbMaKH.Size = new Size(242, 40);
            cbMaKH.TabIndex = 11;
            // 
            // cbMaNV
            // 
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(576, 236);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(242, 40);
            cbMaNV.TabIndex = 12;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(408, 640);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 82;
            dgvHoaDon.Size = new Size(480, 300);
            dgvHoaDon.TabIndex = 13;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Location = new Point(576, 324);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(400, 39);
            dtpNgayBan.TabIndex = 14;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(250, 988);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(626, 988);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1000, 988);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 1086);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtpNgayBan);
            Controls.Add(dgvHoaDon);
            Controls.Add(cbMaNV);
            Controls.Add(cbMaKH);
            Controls.Add(cbPhuongThuc);
            Controls.Add(txtTongTien);
            Controls.Add(txtGhiChu);
            Controls.Add(txtMaHD);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            Load += frmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
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
        private Label label7;
        private TextBox txtMaHD;
        private TextBox txtGhiChu;
        private TextBox txtTongTien;
        private ComboBox cbPhuongThuc;
        private ComboBox cbMaKH;
        private ComboBox cbMaNV;
        private DataGridView dgvHoaDon;
        private DateTimePicker dtpNgayBan;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
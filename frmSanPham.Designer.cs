namespace quanlysanpham
{
    partial class frmSanPham
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
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtGhiChu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpHSD = new DateTimePicker();
            dtpNSX = new DateTimePicker();
            label6 = new Label();
            cboNhaCungCap = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvSanPham = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(528, 45);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(200, 39);
            txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(528, 122);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(200, 39);
            txtTenSP.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(528, 433);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 52);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 3;
            label1.Text = "MaSanPham";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 129);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 4;
            label2.Text = "TenSanPham";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 203);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 5;
            label3.Text = "HanSuDung";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 287);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 6;
            label4.Text = "NgaySanXuat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 436);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 7;
            label5.Text = "GhiChu";
            // 
            // dtpHSD
            // 
            dtpHSD.Location = new Point(528, 203);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(400, 39);
            dtpHSD.TabIndex = 8;
            // 
            // dtpNSX
            // 
            dtpNSX.Location = new Point(528, 287);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(400, 39);
            dtpNSX.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 353);
            label6.Name = "label6";
            label6.Size = new Size(156, 32);
            label6.TabIndex = 10;
            label6.Text = "NhaCungCap";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(528, 353);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(242, 40);
            cboNhaCungCap.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(263, 814);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 12;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(550, 814);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(828, 814);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(345, 490);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 82;
            dgvSanPham.Size = new Size(480, 300);
            dgvSanPham.TabIndex = 16;
            dgvSanPham.CellContentClick += dgvSanPham_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 490);
            label7.Name = "label7";
            label7.Size = new Size(220, 32);
            label7.TabIndex = 17;
            label7.Text = "DanhSachSanPham";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 916);
            Controls.Add(label7);
            Controls.Add(dgvSanPham);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboNhaCungCap);
            Controls.Add(label6);
            Controls.Add(dtpNSX);
            Controls.Add(dtpHSD);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Name = "frmSanPham";
            Text = "frmSanPham";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtGhiChu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpHSD;
        private DateTimePicker dtpNSX;
        private Label label6;
        private ComboBox cboNhaCungCap;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvSanPham;
        private Label label7;
    }
}
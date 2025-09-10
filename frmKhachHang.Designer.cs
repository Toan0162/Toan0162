namespace quanlysanpham
{
    partial class frmKhachHang
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
            txtMaKH = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtGhiChu = new TextBox();
            dgvKhachHang = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 0;
            label1.Text = "MaKH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 125);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 1;
            label2.Text = "Ho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 185);
            label3.Name = "label3";
            label3.Size = new Size(52, 32);
            label3.TabIndex = 2;
            label3.Text = "Ten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 260);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 3;
            label4.Text = "DiaChi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 326);
            label5.Name = "label5";
            label5.Size = new Size(56, 32);
            label5.TabIndex = 4;
            label5.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 402);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(210, 470);
            label7.Name = "label7";
            label7.Size = new Size(93, 32);
            label7.TabIndex = 6;
            label7.Text = "GhiChu";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(471, 42);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(200, 39);
            txtMaKH.TabIndex = 7;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(471, 118);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(200, 39);
            txtHo.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(471, 185);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 39);
            txtTen.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(471, 257);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 39);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(471, 326);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 39);
            txtSDT.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(471, 395);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 12;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(471, 463);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 13;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(210, 538);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 82;
            dgvKhachHang.Size = new Size(480, 300);
            dgvKhachHang.TabIndex = 14;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(154, 882);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(471, 882);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(803, 882);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 990);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKhachHang);
            Controls.Add(txtGhiChu);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMaKH);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHang";
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
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
        private TextBox txtMaKH;
        private TextBox txtHo;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtGhiChu;
        private DataGridView dgvKhachHang;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
namespace quanlysanpham
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaNV = new TextBox();
            txtHo = new TextBox();
            txtTen = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtGhiChu = new TextBox();
            dgvNhanVien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 40);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "MaNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 109);
            label2.Name = "label2";
            label2.Size = new Size(45, 32);
            label2.TabIndex = 1;
            label2.Text = "Ho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 185);
            label3.Name = "label3";
            label3.Size = new Size(52, 32);
            label3.TabIndex = 2;
            label3.Text = "Ten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(416, 251);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 3;
            label4.Text = "DiaChi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 339);
            label5.Name = "label5";
            label5.Size = new Size(56, 32);
            label5.TabIndex = 4;
            label5.Text = "SDT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 422);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 496);
            label7.Name = "label7";
            label7.Size = new Size(93, 32);
            label7.TabIndex = 6;
            label7.Text = "GhiChu";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(652, 33);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(200, 39);
            txtMaNV.TabIndex = 7;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(652, 102);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(200, 39);
            txtHo.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(652, 178);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 39);
            txtTen.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(652, 244);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 39);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(652, 332);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 39);
            txtSDT.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(652, 419);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 12;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(652, 496);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 13;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(394, 581);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 82;
            dgvNhanVien.Size = new Size(480, 300);
            dgvNhanVien.TabIndex = 14;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(364, 944);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(662, 944);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(956, 944);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 1058);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            Controls.Add(txtGhiChu);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(txtMaNV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
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
        private TextBox txtMaNV;
        private TextBox txtHo;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtGhiChu;
        private DataGridView dgvNhanVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
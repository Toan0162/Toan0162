namespace quanlysanpham
{
    partial class frmNhaCungCap
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
            txtMaNCC = new TextBox();
            txtTenNCC = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtGhiChu = new TextBox();
            dgvNhaCungCap = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 0;
            label1.Text = "MaNCC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "TenNCC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 160);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 2;
            label3.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 251);
            label4.Name = "label4";
            label4.Size = new Size(84, 32);
            label4.TabIndex = 3;
            label4.Text = "DiaChi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 333);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 411);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 5;
            label6.Text = "GhiChu";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(549, 19);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(200, 39);
            txtMaNCC.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(549, 86);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(200, 39);
            txtTenNCC.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(549, 153);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 39);
            txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(549, 244);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 39);
            txtDiaChi.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(549, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(549, 404);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 39);
            txtGhiChu.TabIndex = 11;
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Location = new Point(297, 474);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 82;
            dgvNhaCungCap.Size = new Size(480, 300);
            dgvNhaCungCap.TabIndex = 12;
            dgvNhaCungCap.CellContentClick += dgvNhaCungCap_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(181, 806);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 13;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(533, 806);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 46);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += brnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(888, 806);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 46);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 902);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(txtGhiChu);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhaCungCap";
            Text = "frmNhaCungCap";
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
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
        private TextBox txtMaNCC;
        private TextBox txtTenNCC;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtGhiChu;
        private DataGridView dgvNhaCungCap;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
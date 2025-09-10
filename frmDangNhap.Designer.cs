namespace quanlysanpham
{
    partial class frmDangNhap
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
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 101);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 0;
            label1.Text = "TaiKhoan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 181);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "MatKhau";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(375, 94);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(200, 39);
            txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(375, 181);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 39);
            txtMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(194, 293);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(150, 46);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "DangNhap";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(451, 293);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysanpham
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!");
                return;
            }

            string query = $"SELECT * FROM DangNhap WHERE TaiKhoan='{taiKhoan}' AND MatKhau='{matKhau}'";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Lấy phân quyền (nếu có cột PhanLoai trong bảng DangNhap)
                string role = dt.Rows[0]["PhanLoai"].ToString();

                // Mở form chính
                frmMain main = new frmMain(role, taiKhoan); // truyền role để phân quyền
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

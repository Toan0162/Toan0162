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
    public partial class frmMain : Form
    {
        private string _role;
        private string _user;
        public frmMain(string role, string user)
        {
            InitializeComponent();
            _role = role;
            _user = user;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào: {_user} - Quyền: {_role}";
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.MdiParent = this;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void chiTiếtHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon f = new frmChiTietHoaDon();
            f.MdiParent = this;
            f.Show();
        }
    }
}

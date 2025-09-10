using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysanpham
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            LoadChiTietHD();
            LoadHoaDon();
            LoadSanPham();
        }
        private void LoadChiTietHD()
        {
            string query = "SELECT * FROM ChiTietHoaDon";
            dgvChiTietHoaDon.DataSource = DatabaseHelper.ExecuteQuery(query);
        }
        private void LoadHoaDon()
        {
            cbMaHD.DataSource = DatabaseHelper.ExecuteQuery("SELECT MaHoaDon FROM HoaDon");
            cbMaHD.DisplayMember = "MaHoaDon";
            cbMaHD.ValueMember = "MaHoaDon";
        }
        private void LoadSanPham()
        {
            cbMaSP.DataSource = DatabaseHelper.ExecuteQuery("SELECT MaSanPham, TenSanPham FROM SanPham");
            cbMaSP.DisplayMember = "TenSanPham";
            cbMaSP.ValueMember = "MaSanPham";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO ChiTietHoaDon(MaChiTietHoaDon, MaHoaDon, MaSanPham, SoLuong, GiaBan, GhiChu)
                             VALUES(@macthd, @mahd, @masp, @sl, @gia, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@macthd", txtMaCTHD.Text.Trim()),
                new SqlParameter("@mahd", cbMaHD.SelectedValue),
                new SqlParameter("@masp", cbMaSP.SelectedValue),
                new SqlParameter("@sl", txtSoLuong.Text.Trim()),
                new SqlParameter("@gia", txtGiaBan.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
                LoadChiTietHD();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE ChiTietHoaDon
                             SET MaHoaDon=@mahd, MaSanPham=@masp, SoLuong=@sl, GiaBan=@gia, GhiChu=@gc
                             WHERE MaChiTietHoaDon=@macthd";

            SqlParameter[] prms = {
                new SqlParameter("@macthd", txtMaCTHD.Text.Trim()),
                new SqlParameter("@mahd", cbMaHD.SelectedValue),
                new SqlParameter("@masp", cbMaSP.SelectedValue),
                new SqlParameter("@sl", txtSoLuong.Text.Trim()),
                new SqlParameter("@gia", txtGiaBan.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật chi tiết hóa đơn thành công!");
                LoadChiTietHD();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE MaChiTietHoaDon=@macthd";

            SqlParameter[] prms = {
                new SqlParameter("@macthd", txtMaCTHD.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
                LoadChiTietHD();
            }
        }

        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChiTietHoaDon.Rows[e.RowIndex];
                txtMaCTHD.Text = row.Cells["MaChiTietHoaDon"].Value.ToString();
                cbMaHD.SelectedValue = row.Cells["MaHoaDon"].Value.ToString();
                cbMaSP.SelectedValue = row.Cells["MaSanPham"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

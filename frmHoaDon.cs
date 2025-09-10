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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadKhachHang();
            LoadNHanVien();
            LoadPhuongThucNHanTien();
        }
        private void LoadHoaDon()
        {
            string query = "SELECT * FROM HoaDon";
            dgvHoaDon.DataSource = DatabaseHelper.ExecuteQuery(query);
        }
        private void LoadKhachHang()
        {
            cbMaKH.DataSource = DatabaseHelper.ExecuteQuery("SELECT MaKhachHang, Ho + ' ' + Ten AS HoTen FROM KhachHang");
            cbMaKH.DisplayMember = "HoTen";
            cbMaKH.ValueMember = "MaKhachHang";
        }
        private void LoadNHanVien()
        {
            cbMaNV.DataSource = DatabaseHelper.ExecuteQuery("SELECT MaNhanVien, Ho + ' ' + Ten AS HoTen FROM NhanVien");
            cbMaNV.DisplayMember = "HoTen";
            cbMaNV.ValueMember = "MaNhanVien";
        }
        private void LoadPhuongThucNHanTien()
        {
            cbPhuongThuc.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Khác" });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO HoaDon(MaHoaDon, MaKhachHang, MaNhanVien, NgayBan, TongTien, PhuongThucNhanTien, GhiChu)
                             VALUES(@mahd, @makh, @manv, @ngay, @tongtien, @pt, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@mahd", txtMaHD.Text.Trim()),
                new SqlParameter("@makh", cbMaKH.SelectedValue),
                new SqlParameter("@manv", cbMaNV.SelectedValue),
                new SqlParameter("@ngay", dtpNgayBan.Value),
                new SqlParameter("@tongtien", txtTongTien.Text.Trim()),
                new SqlParameter("@pt", cbPhuongThuc.Text),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Thêm hóa đơn thành công!");
                LoadHoaDon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE HoaDon
                             SET MaKhachHang=@makh, MaNhanVien=@manv, NgayBan=@ngay, TongTien=@tongtien, 
                                 PhuongThucNhanTien=@pt, GhiChu=@gc
                             WHERE MaHoaDon=@mahd";

            SqlParameter[] prms = {
                new SqlParameter("@mahd", txtMaHD.Text.Trim()),
                new SqlParameter("@makh", cbMaKH.SelectedValue),
                new SqlParameter("@manv", cbMaNV.SelectedValue),
                new SqlParameter("@ngay", dtpNgayBan.Value),
                new SqlParameter("@tongtien", txtTongTien.Text.Trim()),
                new SqlParameter("@pt", cbPhuongThuc.Text),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công!");
                LoadHoaDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon=@mahd";

            SqlParameter[] prms = {
                new SqlParameter("@mahd", txtMaHD.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa hóa đơn thành công!");
                LoadHoaDon();
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells["MaHoaDon"].Value.ToString();
                cbMaKH.SelectedValue = row.Cells["MaKhachHang"].Value.ToString();
                cbMaNV.SelectedValue = row.Cells["MaNhanVien"].Value.ToString();
                dtpNgayBan.Value = Convert.ToDateTime(row.Cells["NgayBan"].Value);
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                cbPhuongThuc.Text = row.Cells["PhuongThucNhanTien"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

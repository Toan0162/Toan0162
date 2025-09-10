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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO KhachHang(MaKhachHang, Ho, Ten, DiaChi, SDT, Email, GhiChu)
                             VALUES(@ma, @ho, @ten, @dc, @sdt, @em, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaKH.Text.Trim()),
                new SqlParameter("@ho", txtHo.Text.Trim()),
                new SqlParameter("@ten", txtTen.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@em", txtEmail.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadKhachHang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE KhachHang 
                             SET Ho=@ho, Ten=@ten, DiaChi=@dc, SDT=@sdt, Email=@em, GhiChu=@gc
                             WHERE MaKhachHang=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaKH.Text.Trim()),
                new SqlParameter("@ho", txtHo.Text.Trim()),
                new SqlParameter("@ten", txtTen.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@em", txtEmail.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadKhachHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM KhachHang WHERE MaKhachHang=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaKH.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadKhachHang();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        private void LoadKhachHang()
        {
            string query = "SELECT * FROM KhachHang";
            dgvKhachHang.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtHo.Text = row.Cells["Ho"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

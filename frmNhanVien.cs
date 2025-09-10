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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void LoadNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            dgvNhanVien.DataSource = DatabaseHelper.ExecuteQuery(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO NhanVien(MaNhanVien, Ho, Ten, DiaChi, SDT, Email, GhiChu)
                             VALUES(@ma, @ho, @ten, @dc, @sdt, @em, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNV.Text.Trim()),
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
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE NhanVien
                             SET Ho=@ho, Ten=@ten, DiaChi=@dc, SDT=@sdt, Email=@em, GhiChu=@gc
                             WHERE MaNhanVien=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNV.Text.Trim()),
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
                MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadNhanVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNV.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                LoadNhanVien();
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
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

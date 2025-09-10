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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
        }
        private void LoadNhaCungCap()
        {
            string query = "SELECT * FROM NhaCungCap";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvNhaCungCap.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO NhaCungCap(MaNhaCungCap, TenNhaCungCap, SDT, DiaChi, Email, GhiChu)
                             VALUES(@ma, @ten, @sdt, @dc, @em, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNCC.Text.Trim()),
                new SqlParameter("@ten", txtTenNCC.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                new SqlParameter("@em", txtEmail.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Thêm nhà cung cấp thành công!");
                LoadNhaCungCap();
            }
        }

        private void brnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE NhaCungCap
                             SET TenNhaCungCap=@ten, SDT=@sdt, DiaChi=@dc, Email=@em, GhiChu=@gc
                             WHERE MaNhaCungCap=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNCC.Text.Trim()),
                new SqlParameter("@ten", txtTenNCC.Text.Trim()),
                new SqlParameter("@sdt", txtSDT.Text.Trim()),
                new SqlParameter("@dc", txtDiaChi.Text.Trim()),
                new SqlParameter("@em", txtEmail.Text.Trim()),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                LoadNhaCungCap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNhaCungCap=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaNCC.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa nhà cung cấp thành công!");
                LoadNhaCungCap();
            }
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNhaCungCap"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

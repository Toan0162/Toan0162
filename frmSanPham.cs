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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadNhaCungCap();
        }
        private void LoadNhaCungCap()
        {
            string query = "SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "MaNhaCungCap";
        }
        private void LoadSanPham()
        {
            string query = "SELECT * FROM SanPham";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvSanPham.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SanPham(MaSanPham, MaNhaCungCap, TenSanPham, HanSuDung, NgaySanXuat, GhiChu) " +
                           "VALUES(@ma, @ncc, @ten, @hsd, @nsx, @gc)";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaSP.Text),
                new SqlParameter("@ncc", cboNhaCungCap.SelectedValue),
                new SqlParameter("@ten", txtTenSP.Text),
                new SqlParameter("@hsd", dtpHSD.Value),
                new SqlParameter("@nsx", dtpNSX.Value),
                new SqlParameter("@gc", txtGhiChu.Text)
            };
            DataTable result = DatabaseHelper.ExecuteQuery(query, prms);

            if (result.Rows.Count > 0)
            {
                MessageBox.Show("Có dữ liệu trả về!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE SanPham 
                             SET MaNhaCungCap=@ncc, TenSanPham=@ten, HanSuDung=@hsd, NgaySanXuat=@nsx, GhiChu=@gc
                             WHERE MaSanPham=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaSP.Text.Trim()),
                new SqlParameter("@ncc", cboNhaCungCap.SelectedValue),
                new SqlParameter("@ten", txtTenSP.Text.Trim()),
                new SqlParameter("@hsd", dtpHSD.Value.Date),
                new SqlParameter("@nsx", dtpNSX.Value.Date),
                new SqlParameter("@gc", txtGhiChu.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadSanPham();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM SanPham WHERE MaSanPham=@ma";

            SqlParameter[] prms = {
                new SqlParameter("@ma", txtMaSP.Text.Trim())
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, prms);
            if (result > 0)
            {
                MessageBox.Show("Xóa sản phẩm thành công!");
                LoadSanPham();
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSanPham"].Value.ToString();
                cboNhaCungCap.SelectedValue = row.Cells["MaNhaCungCap"].Value;
                txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
                dtpHSD.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
                dtpNSX.Value = Convert.ToDateTime(row.Cells["NgaySanXuat"].Value);
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }
    }
}

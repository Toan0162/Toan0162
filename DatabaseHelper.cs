using System;
using System.Data;
using System.Data.SqlClient;

namespace quanlysanpham
{
    internal class DatabaseHelper
    {
        private static string connectionString =
            @"Data Source=DESKTOP-7VUFC2V\SQLEXPRESS;Initial Catalog=quanlysanpham;Integrated Security=True";

        // Hàm lấy dữ liệu (SELECT -> DataTable)
        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // INSERT, UPDATE, DELETE -> số dòng ảnh hưởng
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    result = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return result;
        }
    }
}

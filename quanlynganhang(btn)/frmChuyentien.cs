using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanlynganhang_btn_
{
    public partial class frmChuyentien : Form
    {
        string tentaikhoan, sotaikhoan;
        int sodu = 0;
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection connect;

        public frmChuyentien()
        {
            InitializeComponent();
        }
        void hienthi()
        {
            string sql = "SELECT * FROM dbo.qlnh";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmChuyentien_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();
                hienthi();
            }
            catch
            {
                MessageBox.Show("Loi ket noi den form Chuyển Khoản!");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan1.Text;
            sotaikhoan = txtsotaikhoan1.Text;

            string sql = "SELECT * FROM dbo.qlnh WHERE  SoTaiKhoan='" +
              sotaikhoan + "' and TenTaiKhoan = '" + tentaikhoan + "'";

            using (SqlCommand command = new SqlCommand(sql, connect))
            {
                // Thay thế @Username bằng tên tài khoản cần truy vấn
                //command.Parameters.AddWithValue("@Username", username);

                // Thực hiện truy vấn và đọc dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txttentaikhoan2.Text = reader["Tentaikhoan"].ToString();
                        txtsotaikhoan2.Text = reader["Sotaikhoan"].ToString();
                        txtemail.Text = reader["Diachiemail"].ToString();
                        txtCCCD.Text = reader["Socccd"].ToString();
                        txtsodu.Text = reader["Sodu"].ToString();
                        sodu = Convert.ToInt32(reader["Sodu"]);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin cho tên tài khoản này.");
                    }
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnchuyentien_Click(object sender, EventArgs e)
        {
            int sotienchuyen = (int)txtSoTienChuyen.Bottom;

            DialogResult result = MessageBox.Show("bạn có muốn chuyển: " + sotienchuyen + "VND", " Thông Báo ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sotaikhoan = txtsotaikhoan1.Text;
                string tentaikhoan = txttentaikhoan1.Text;

                txtSoTienChuyen.Text = sotaikhoan;
                int SoDu = sodu - sotienchuyen;

                string sql = "UPDATE dbo.qlnh set Sodu='" + SoDu + "' WHERE Tentaikhoan = '" + tentaikhoan + "' AND Sotaikhoan ='" + sotaikhoan + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, connect);
                adapter.UpdateCommand.ExecuteNonQuery();
                hienthi();
            }
        }


    }
}

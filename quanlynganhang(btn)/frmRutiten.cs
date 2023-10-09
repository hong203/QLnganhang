using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quanlynganhang_btn_
{
    public partial class frmRutiten : Form
    {
        string tentaikhoan, sotaikhoan;
        int sodu = 0;
        static string cnn = @"Data Source=LAPTOP-82GOTJUD\SQLEXPRESS;Initial Catalog=QuanLyHang;Integrated Security=True";
        SqlConnection connect;
        public frmRutiten()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void HienThi()
        {
            string sql = "SELECT TenTaiKhoan, SoTaiKhoan, SoDu, NgaySinh, GioiTinh FROM dbo.qlnh";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmRutiten_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi kêt nối đến from rút tiền!");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan1.Text;
            sotaikhoan = txtsotaikhoan1.Text;

            string sql = "SELECT TenTaiKhoan, SoTaiKhoan, SoDu, NgaySinh, GioiTinh FROM dbo.qlnh WHERE TenTaiKhoan = '" + tentaikhoan + "' AND SoTaiKhoan ='" + sotaikhoan + "'";


            using (SqlCommand command = new SqlCommand(sql, connect))
            {
                // Thay thế @Username bằng tên tài khoản cần truy vấn
                //command.Parameters.AddWithValue("@Username", username);

                // Thực hiện truy vấn và đọc dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txttentaikhoan2.Text = reader["TenTaiKhoan"].ToString();
                        txtsodu.Text = reader["SoDu"].ToString();
                        sodu = Convert.ToInt32(reader["SoDu"]);
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

        private void btnruttien_Click(object sender, EventArgs e)
        {
            int sotienrut = (int)textSoTienRut.Value;

            DialogResult result = MessageBox.Show("bạn có muốn rút: " + sotienrut + "VND", " Thông Báo ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sotaikhoan = txtsotaikhoan1.Text;
                string tentaikhoan = txttentaikhoan1.Text;

                txtSoTienDaRut.Value = sotienrut;
                int SoDu = sodu - sotienrut;

                string sql = "UPDATE dbo.qlnh set SoDu='" + SoDu + "' WHERE TenTaiKhoan = '" + tentaikhoan + "' AND SoTaiKhoan ='" + sotaikhoan + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, connect);
                adapter.UpdateCommand.ExecuteNonQuery();
                HienThi();
            }
            
        }
    }
}

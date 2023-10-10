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

namespace quanlynganhang_btn_
{

    public partial class frmkiemsoducs : Form
    {
        string tentaikhoan, sotaikhoan;
        int sodu = 0;
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KTSodu;Integrated Security=True";
        SqlConnection connect;
        public frmkiemsoducs()
        {
            InitializeComponent();
        }

        void HienThi()
        {
            string sql = "SELECT Tentaikhoan, Sotaikhoan, Diachiemail, Socccd, Sodu FROM dbo.qlnh";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void btnKTsodu_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan1.Text;
            sotaikhoan = txtsotaikhoan1.Text;


            string sql = "SELECT Tentaikhoan, Sotaikhoan, Diachiemail, Socccd, Sodu FROM dbo.qlnh WHERE Tentaikhoan = '" + tentaikhoan + "' AND Sotaikhoan ='" + sotaikhoan + "'";


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
                        txtEmail.Text = reader["Diachiemail"].ToString();
                        txtCCCD.Text = reader["Socccd"].ToString();
                        txtSoDuHienTai.Text = reader["Sodu"].ToString();
                        sodu = Convert.ToInt32(reader["Sodu"]);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin cho tên tài khoản này.");
                    }
                }
            }
        }

        private void frmkiemsoducs_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi kêt nối đến from kiểm tra số dư!");
            }
        }
    }
}

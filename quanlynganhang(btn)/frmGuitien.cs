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
    public partial class frmGuitien : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection connect;
        public frmGuitien()
        {
            InitializeComponent();
        }
        void hienthi()
        {

            string sql = "SELECT Tentaikhoan,Sotaikhoan,Socccd,Sodu FROM dbo.qlnh";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGuitien_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cnn);
            try
            {
                connect.Open();
                hienthi();

            }
            catch
            {
                MessageBox.Show("Loi ket noi CSDL toi Project");
            }
        }
        string tentaikhoan, sotaikhoan;
        int sodu = 0;
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan1.Text;
            sotaikhoan = txtsotaikhoan1.Text;

            string sql = "SELECT Tentaikhoan, Sotaikhoan, Sodu,Diachiemail,Socccd, Ngaysinh, Gioitinh FROM dbo.qlnh WHERE Tentaikhoan = '" + tentaikhoan + "' AND Sotaikhoan ='" + sotaikhoan + "'";


            using (SqlCommand command = new SqlCommand(sql, connect))
            {

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
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(sql, connect);
                adapter.SelectCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btnguitien_Click(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnguitien_Click_1(object sender, EventArgs e)
        {
            int sotiengui = (int)textsotiengui.Value;
            DialogResult result = MessageBox.Show("bạn có muốn gửi : " + sotiengui + "VND", " Thông Báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sotaikhoan = txtsotaikhoan1.Text;
                string tentaikhoan = txttentaikhoan1.Text;
                int SoDu = sodu + sotiengui;

                string sql = "UPDATE dbo.qlnh set Sodu='" + SoDu + "' WHERE Tentaikhoan = '" + tentaikhoan + "' AND Sotaikhoan ='" + sotaikhoan + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, connect);
                adapter.UpdateCommand.ExecuteNonQuery();
                hienthi();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txttentaikhoan1.Text = "";
            txtsotaikhoan1.Text = "";
        }

    }
}

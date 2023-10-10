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
    public partial class frmxoataikhoan : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection connect;
        public frmxoataikhoan()
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

        private void frmxoataikhoan_Load(object sender, EventArgs e)
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
        private void btnkiemtra_Click(object sender, EventArgs e)
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id_cx = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản có ID là: " + id_cx +
                    " không?", "Thông báo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM dbo.qlnh WHERE id='" + id_cx + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = new SqlCommand(sql, connect);
                    adapter.DeleteCommand.ExecuteNonQuery();
                    hienthi();
                }
            }

        }

        
    }
}
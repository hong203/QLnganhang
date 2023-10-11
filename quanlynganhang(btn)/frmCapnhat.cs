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
    public partial class frmCapnhat : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection connect;
        public frmCapnhat()
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
        private void frmCapnhat_Load(object sender, EventArgs e)
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
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan1.Text;
            sotaikhoan = txtsotaikhoan1.Text;

            string sql = "SELECT * FROM dbo.qlnh WHERE Tentaikhoan = '" + tentaikhoan + "' AND Sotaikhoan ='" + sotaikhoan + "'";


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
                        txtmatkhau.Text = reader["Matkhau"].ToString();
                        txtquoctich.Text = reader["Quoctich"].ToString();
                        txtsodienthoai.Text = reader["Sodienthoai"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            txttentaikhoan1.Text = "";
            txtsotaikhoan1.Text = "";
        }

        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("bạn có chắc chắn cập nhật thông tin khách hàng có id là : " + dataGridView1.SelectedRows[0].Cells[0].Value, " Thông Báo ", MessageBoxButtons.YesNo);
                string id_cn = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                bool gioitinh = cbnam.Checked;
                string tentaikhoan = txttentaikhoan2.Text;
                string sotaikhoan = txtsotaikhoan2.Text;
                string matkhau = txtmatkhau.Text;
                string email = txtemail.Text;
                string socccd = txtCCCD.Text;
                string sodienthoai = txtsodienthoai.Text;
                string quoctich = txtquoctich.Text;
                string sodu = txtsodu.Text;
                string ngaysinh = dtpngaysinh.Value.ToString("yyyy/MM/dd");
                if (cbnam.Checked == true)
                {
                    gioitinh = true;
                }
                else
                {
                    gioitinh = false;
                }

                string sql = "UPDATE dbo.qlnh set Tentaikhoan='" + tentaikhoan + "',Sotaikhoan='" + sotaikhoan + "',Matkhau='" + matkhau + "',Diachiemail='" + email + "',Ngaysinh='" + ngaysinh + "',gioitinh ='" + gioitinh + "',Socccd='" + socccd + "',Sodienthoai='" + sodienthoai + "',Quoctich='" + quoctich + "',Sodu='" + sodu + "' WHERE id='" + id_cn + "'";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand(sql, connect);
                adapter.UpdateCommand.ExecuteNonQuery();
                hienthi();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật", "thông báo");
            }

        }
    }
}

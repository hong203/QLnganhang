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
        int soduNguoiNhan = 0;
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

            string cmnd = txtcmnd.Text;

            string sql = "SELECT * FROM dbo.qlnh WHERE  Socccd='" +
              cmnd + "'";

            //using (SqlCommand command = new SqlCommand(sql, connect))
            //{
            //    // Thay thế @Username bằng tên tài khoản cần truy vấn
            //    //command.Parameters.AddWithValue("@Username", username);

            //    // Thực hiện truy vấn và đọc dữ liệu
            //    //using (SqlDataReader reader = command.ExecuteReader())
            //    //{
            //    //    if (reader.Read())
            //    //    {
            //    //        cbtentaikhoan2.Text = reader["Tentaikhoan"].ToString();
            //    //        txtsotaikhoan2.Text = reader["Sotaikhoan"].ToString();
            //    //        txtemail.Text = reader["Diachiemail"].ToString();
            //    //        txtCCCD.Text = reader["Socccd"].ToString();
            //    //        txtsodu.Text = reader["Sodu"].ToString();
            //    //        sodu = Convert.ToInt32(reader["Sodu"]);
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Không tìm thấy thông tin cho tên tài khoản này.");
            //    //    }
            //    //}
            //}

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;


        }

        private void btnchuyentien_Click(object sender, EventArgs e)
        {
            int sotienchuyen = (int)numsotienchuyen.Value;

            DialogResult result = MessageBox.Show("bạn có muốn chuyển: " + sotienchuyen + "VND", " Thông Báo ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sotaikhoan = txtsotaikhoan2.Text;
                string soCMND = txtCCCD.Text;


                int SoDu = int.Parse(txtSodu.Text) - sotienchuyen;
                if (SoDu >= 0)
                {
                    string sql = "UPDATE dbo.qlnh set Sodu='" + SoDu + "' WHERE Socccd = '" + soCMND + "' AND Sotaikhoan ='" + sotaikhoan + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sql, connect);
                    adapter.UpdateCommand.ExecuteNonQuery();


                    int sodunguoinhansauck = soduNguoiNhan + sotienchuyen;
                    string sql2 = "UPDATE dbo.qlnh set Sodu='" + sodunguoinhansauck + "' WHERE   Sotaikhoan ='" + txtdentaikhoan.Text + "'";
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    adapter.UpdateCommand = new SqlCommand(sql2, connect);
                    adapter.UpdateCommand.ExecuteNonQuery();

                    hienthi();
                }
                else
                {
                    MessageBox.Show("Số dư không đủ! ");
                }

            }
        }

        private void numsotienchuyen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridView1.CurrentCell.RowIndex;
            if (vitri > -1)
            {
                txttentaikhoan2.Text = dataGridView1.Rows[vitri].Cells[1].Value.ToString();
                txtsotaikhoan2.Text = dataGridView1.Rows[vitri].Cells[2].Value.ToString();
                txtemail.Text = dataGridView1.Rows[vitri].Cells[4].Value.ToString();
                txtCCCD.Text = dataGridView1.Rows[vitri].Cells[6].Value.ToString();
                txtSodu.Text = dataGridView1.Rows[vitri].Cells[10].Value.ToString();
            }
        }

        private void txtSodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdentaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "SELECT * FROM dbo.qlnh WHERE  Socccd='" +
             txtdentaikhoan.Text + "'";

                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    // Thay thế @Username bằng tên tài khoản cần truy vấn
                    //command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txttenTaiKhoanNhan.Text = reader["Tentaikhoan"].ToString();
                            soduNguoiNhan = int.Parse(reader["Sodu"].ToString());
                            //txtsotaikhoan2.Text = reader["Sotaikhoan"].ToString();
                            //txtemail.Text = reader["Diachiemail"].ToString();
                            //txtCCCD.Text = reader["Socccd"].ToString();
                            //txtsodu.Text = reader["Sodu"].ToString();
                            //sodu = Convert.ToInt32(reader["Sodu"]);
                        }
                        else
                        {
                            txttenTaiKhoanNhan.Text = "";
                            MessageBox.Show("Không tìm thấy thông tin cho tên tài khoản này.");

                        }
                    }
                }
            }
        }

        private void txtdentaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

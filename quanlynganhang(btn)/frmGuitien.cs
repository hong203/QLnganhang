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

            string sql = "SELECT Tentaikhoan,Sotaikhoan,Socccd,Sotienhientai `FROM dbo.qlnh";
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }
    }
}

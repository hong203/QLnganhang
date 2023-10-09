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

namespace QUANLYNGANHANG
{
    public partial class frmTaotk : Form
    {
        static string cnn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection connect;


        public frmTaotk()
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

        private void txttentaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTaotk_Load(object sender, EventArgs e)
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
        internal string tentaikhoan, sotaikhoan, matkhau, diachiemail, socccd, sodienthoai, ngaysinh, quoctich, sodu;
        internal bool gioitinh;
        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            tentaikhoan = txttentaikhoan.Text;
            sotaikhoan = txtsotaikhoan.Text;
            matkhau = txtmatkhau.Text;
            diachiemail = txtdiachieamil.Text;
            socccd = txtCCCD.Text;
            sodienthoai = txtsodienthoai.Text;
            ngaysinh = dtpngaysinh.Value.ToString("yyyy/MM/dd");
            quoctich = txtquoctich.Text;
            sodu = txtsodu.Text;

            if (cbnam.Checked == true)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            string sql = "insert into dbo.qlnh (Tentaikhoan, Sotaikhoan, Matkhau, Diachiemail,Gioitinh, Socccd, Sodienthoai, Ngaysinh, Quoctich,Sodu) VALUES  ('" +
            tentaikhoan + " ','" + sotaikhoan + "','" + matkhau + "','" + diachiemail + "','" + gioitinh.ToString() + "','" + socccd + "','" + sodienthoai + "','" + ngaysinh + "','" + quoctich + "','" + sodu + "')";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(sql, connect);
            adapter.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Đã Tạo thành công tài khoản có tên là " + txttentaikhoan.Text, "Thông báo");
            hienthi();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txttentaikhoan.Text = "";
            txtsotaikhoan.Text = "";
            txtmatkhau.Text = "";
            txtdiachieamil.Text = "";
            txtCCCD.Text = "";
            txtsodienthoai.Text = "";
            txtsodu.Text = "";
            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime("01/01/1900");
            dtpngaysinh.Value = dateTime;
            cbnam.Checked = false;
        }
    }
}

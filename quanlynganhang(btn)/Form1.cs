using QUANLYNGANHANG;

namespace quanlynganhang_btn_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmChuyentien_Click(object sender, EventArgs e)
        {
            frmChuyentien ct = new frmChuyentien();
            ct.ShowDialog();
        }

        private void btntaotaikhoan_Click(object sender, EventArgs e)
        {
            frmTaotk tk = new frmTaotk();
            tk.ShowDialog();
        }

        private void btnguitien_Click(object sender, EventArgs e)
        {
            frmGuitien gt = new frmGuitien();
            gt.ShowDialog();
        }

        private void btnruttien_Click(object sender, EventArgs e)
        {
            frmRutiten rt = new frmRutiten();
            rt.ShowDialog();
        }

        private void btnktsodu_Click(object sender, EventArgs e)
        {
            frmkiemsoducs ktsd = new frmkiemsoducs();
            ktsd.ShowDialog();
        }

        private void btnxoataikhoan_Click(object sender, EventArgs e)
        {
            frmxoataikhoan xtk= new frmxoataikhoan();   
            xtk.ShowDialog();
        }
    }
}
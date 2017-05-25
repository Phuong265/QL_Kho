using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class frmDanhSachPhieuNhap : Form
    {
        public frmDanhSachPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap pn = new PhieuNhap();
        void HienThi()
        {
            DataTable dt = pn.get_phieunhap();
            dgvPhieuNhap.DataSource = dt;
        }

        private void frmDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap();
            frm.ShowDialog();
        }
    }
}

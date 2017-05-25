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
    public partial class frmChiTietPhieuNhap : Form
    {
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        void loadCbo()
        {
            string sql = @"Select ma from phieunhap";
            DataTable dt = DBConnect.GetData(sql);
            cboMaPhieu.DataSource = dt;
            cboMaPhieu.ValueMember = "ma";
            cboMaPhieu.DisplayMember = "ma";
        }

        void HienThi()
        {
            DataTable dt = new DataTable();
            string sql = @"Select hanghoama as N'Mã hàng', soluong as N'Số lượng', donvitinh as N'Đơn vị tính', gianhap as N'Giá nhập', thanhtien as N'Thành tiền' from chitietphieunhap where phieunhapma='" + cboMaPhieu.Text + "' ";
            dt = DBConnect.GetData(sql);
            dgvChiTietPhieuNhap.DataSource = dt;
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            loadCbo();
        }
    }
}

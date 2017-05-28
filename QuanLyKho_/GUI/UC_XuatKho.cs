using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_XuatKho : UserControl
    {
        public UC_XuatKho()
        {
            InitializeComponent();
        }

        private void UC_XuatKho_Load(object sender, EventArgs e)
        {
            DataTable tb_hanghoa = DTO.HangHoa.Get_HH();
            tb_hanghoa.Columns.Remove("Nhà cung cấp");
            tb_hanghoa.Columns.Remove("Ghi chú");
            dgvHH.DataSource = tb_hanghoa;
        }

        private void tabCtrlPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlPhieuXuat.SelectedTab == tabDanhSach)
                dgvHH.Visible = false;
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if(txtMaHang.Text != "" && txtMaHang.Text.Trim() != "")
            {
                dgvHH.Visible = true;
            }
            else
            {
                dgvHH.Visible = false;
            }
        }

        private void txtMaHang_dgvHH_Leave(object sender, EventArgs e)
        {
            if (!dgvHH.Focused && !txtMaHang.Focused) dgvHH.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI
{
    public partial class UC_DSHangHoa : UserControl
    {
        public UC_DSHangHoa()
        {
            InitializeComponent();
        }

        private void UC_DSHangHoa_Load(object sender, EventArgs e)
        {
            dgvDSHangHoa.DataSource = DTO.HangHoa.Get_HH();
        }
        // tim kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dgvDSHangHoa.DataSource = DTO.HangHoa.Get_HH_TheoTen(txtTimKiem.Text.Trim());
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDSHangHoa.DataSource = DTO.HangHoa.Get_HH_TheoTen(txtTimKiem.Text.Trim());
        }
    }
}

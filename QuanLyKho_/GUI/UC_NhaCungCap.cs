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
    public partial class UC_NhaCungCap : UserControl
    {
        public UC_NhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCap ncc = new NhaCungCap();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            txtDiachi.Enabled = false;
            txtSDT.Enabled = false;
            tsbThem.Enabled = true;
            tsbSua.Enabled = true;
            tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            tsbThem.Enabled = false;
            tsbSua.Enabled = false;
            tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
        }

        void HienThi()
        {
            DataTable dt = ncc.get_nhacungcap();
            dgvNCC.DataSource = dt;
        }
        private void tsbThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNCC.Enabled = false;
            ThemMoi = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ncc.Ma = txtMaNCC.Text;
                ncc.xoa(ncc.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ!");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    int a;
                    ncc.Ma = txtMaNCC.Text;
                    ncc.Ten = txtTenNCC.Text;
                    ncc.Diachi = txtDiachi.Text;
                    int.TryParse(txtSDT.Text, out a);
                    ncc.Sdt = a;
                    ncc.them();
                    MessageBox.Show("Đã thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            else
            {
                try
                {
                    int a;
                    ncc.Ma = txtMaNCC.Text;
                    ncc.Ten = txtTenNCC.Text;
                    ncc.Diachi = txtDiachi.Text;
                    int.TryParse(txtSDT.Text, out a);
                    ncc.Sdt = a;
                    ncc.sua();
                    MessageBox.Show("Đã sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }

            }
            SetNull();
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMaNCC.Text = dgvNCC.Rows[Row_Index].Cells[1].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[Row_Index].Cells[2].Value.ToString();
                txtDiachi.Text = dgvNCC.Rows[Row_Index].Cells[5].Value.ToString();
                txtSDT.Text = dgvNCC.Rows[Row_Index].Cells[6].Value.ToString();

                //txtNCC.Text = dgvNhapKho.Rows[Row_Index].Cells[7].Value.ToString();
                //txtGhiChu.Text = dgvNhapKho.Rows[Row_Index].Cells[8].Value.ToString();
                for (int i = 0; i < dgvNCC.Rows.Count; i++)
                {
                    dgvNCC.Rows[i].Cells[0].Value = (i + 1).ToString();
                }

            }
            catch { }
        }

        private void UC_NhaCungCap_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }
    }
}

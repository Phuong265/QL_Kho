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
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

         NhanVien nv = new NhanVien();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiachi.Enabled = false;
            txtSDT.Enabled = false;
            cmbGioitinh.Enabled = false;
            tsbThem.Enabled = true;
            tsbSua.Enabled = true;
            tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiachi.Enabled = true;
            txtSDT.Enabled = true;
            cmbGioitinh.Enabled = true;
            tsbThem.Enabled = false;
            tsbSua.Enabled = false;
            tsbXoa.Enabled = false;
            tsbLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtSDT.Text = "";
            cmbGioitinh.Text = "";
        }

        void HienThi()
        {
            DataTable dt = nv.get_nhanvien();
            dgvNhanVien.DataSource = dt;
        }
        private void tsbThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
        
            //txtMa.Text = null;
            //DataTable dt = nv.get_nhanvien();
            //if (dt != null)

            //{
            //    List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
            //    if (list.Count > 0) txtMa.Text = string.Format("{0:d4}", int.Parse(list.Max()) + 1);
            //    else
            //        txtMa.Text = "0001";
            //}
            //else
            //    txtMa.Text = "0001";
            ThemMoi = true;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            ThemMoi = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            try
            {
                nv.Ma = txtMa.Text;
                nv.Xoa(nv.Ma);
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
            if (txtMa.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ!");
                return;
            }
            if (ThemMoi == true)
            {
                try
                {
                    int a;
                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    nv.Diachi = txtDiachi.Text;
                    int.TryParse(txtSDT.Text, out a);
                    nv.Sdt = a;
                    nv.Ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
                    if(cmbGioitinh.Text=="Nữ")
                    {
                        nv.Gioitinh = true;
                    }
                    else
                    {
                        nv.Gioitinh = false;
                    }
                    nv.Them();
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
                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    nv.Diachi = txtDiachi.Text;
                    int.TryParse(txtSDT.Text, out a);
                    nv.Sdt = a;
                    nv.Ngaysinh = Convert.ToDateTime(dtpNgaySinh.Text);
                    if (cmbGioitinh.Text == "Nam")
                    {
                        nv.Gioitinh = true;
                    }
                    else
                    {
                        nv.Gioitinh = false;
                    }
                    nv.Sua();
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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvNhanVien.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvNhanVien.Rows[Row_Index].Cells[1].Value.ToString();
                cmbGioitinh.SelectedValue = dgvNhanVien.Rows[Row_Index].Cells[3].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[Row_Index].Cells[2].Value.ToString();
                txtDiachi.Text = dgvNhanVien.Rows[Row_Index].Cells[4].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[Row_Index].Cells[5].Value.ToString();

                //txtNCC.Text = dgvNhapKho.Rows[Row_Index].Cells[7].Value.ToString();
                //txtGhiChu.Text = dgvNhapKho.Rows[Row_Index].Cells[8].Value.ToString();
                //for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                //{
                //    dgvNhanVien.Rows[i].Cells[0].Value = (i + 1).ToString();
                //}

            }
            catch { }
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

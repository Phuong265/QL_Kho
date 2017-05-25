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
    public partial class UC_NhapKho : UserControl
    {
        public UC_NhapKho()
        {
            InitializeComponent();
        }
        bool them = true;
        HangHoa hh = new HangHoa();
        PhieuNhap pn = new PhieuNhap();
        ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
        void SetNullHH()
        {
            cboMa.Text = "";
            txtTen.Text = "";
            cboNCC.Text = "";
            txtSL.Text = "";
            txtXuatXu.Text = "";
            txtGhichu.Text = "";
            cboDonViTinh.Text = "";
            txtGiaNhap.Text = "";
            txtThanhTien.Text = "";
        }
        void HienThi_cboMaHH()
        {
            DataTable dt = DBConnect.GetData(@"Select ma from hanghoa");
            cboMa.DataSource = dt;
            cboMa.DisplayMember = "ma";
            cboMa.ValueMember = "ma";
            cboMa.Text = null;
        }

        void HienThi_cboNCC()
        {
            DataTable dt = DBConnect.GetData(@"Select ma from nhacungcap");
            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "ma";
            cboNCC.ValueMember = "ma";
            cboNCC.Text = null;
        }
        void HienThi_cboMaNV()
        {
            DataTable dt = DBConnect.GetData(@"Select ma from nhanvien");
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "ma";
            cboMaNV.ValueMember = "ma";
            cboMaNV.Text = null;
        }

        private void UC_NhapKho_Load(object sender, EventArgs e)
        {
           
            btnCapNhat.Enabled = false;
            dtpNgayNhap.Enabled = false;
            txtMaPN.Enabled= false;
            cboMaNV.Enabled = false;
            txtTongTien.Text = "0";
            HienThi_cboMaHH();
            HienThi_cboMaNV();
            HienThi_cboNCC();
        }

        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ten,nhacungcapma,xuatxu,ghichu from hanghoa where ma= '" + cboMa.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                txtTen.Text = dt.Rows[0]["ten"].ToString();
                cboNCC.Text = dt.Rows[0]["nhacungcapma"].ToString();
                txtXuatXu.Text = dt.Rows[0]["xuatxu"].ToString();
                txtGhichu.Text = dt.Rows[0]["ghichu"].ToString();
            }
            else
            {
                txtTen.Text = "";
                cboNCC.Text = "";
                txtXuatXu.Text = "";
                txtGhichu.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

            if (them == true)
            {
                dgvChiTietPhieuNhap.Rows.Add();
                int indexRow = dgvChiTietPhieuNhap.Rows.Count - 1;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[0].Value = cboMa.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[1].Value = txtTen.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[2].Value = cboNCC.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[3].Value = txtSL.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[4].Value = txtXuatXu.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[5].Value = txtGhichu.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[6].Value = cboDonViTinh.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[7].Value = txtGiaNhap.Text;
                dgvChiTietPhieuNhap.Rows[indexRow].Cells[8].Value = txtThanhTien.Text;
                SetNullHH();
            }

            else
            {

                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[0].Value = cboMa.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[1].Value = txtTen.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[2].Value = cboNCC.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[3].Value = txtSL.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[4].Value = txtXuatXu.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[5].Value = txtGhichu.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[6].Value = cboDonViTinh.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[7].Value = txtGiaNhap.Text;
                dgvChiTietPhieuNhap.Rows[dgvChiTietPhieuNhap.CurrentRow.Index].Cells[8].Value = (decimal.Parse(txtSL.Text)*decimal.Parse(txtGiaNhap.Text)).ToString();
                SetNullHH();
            }
            them = true;
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            decimal a, b, Tich;
            decimal.TryParse(txtSL.Text, out a);
            decimal.TryParse(txtGiaNhap.Text, out b);
            Tich = a * b;
            txtThanhTien.Text = Tich.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            pn.Ma = txtMaPN.Text;
            pn.Nhanvienma = cboMaNV.Text;
            pn.Ngaynhap = Convert.ToDateTime(dtpNgayNhap.Text);
            decimal k;
            decimal.TryParse(txtTongTien.Text, out k);
            pn.Tongtien = k;
            pn.them();

            for (int i = 0; i < dgvChiTietPhieuNhap.Rows.Count; i++)
            {
                DataTable dt = DBConnect.GetData(@"Select ma, soluong from hanghoa where ma= '" + dgvChiTietPhieuNhap[0, i].Value.ToString() + "'");
                if (dt.Rows.Count==0)
                {
                    hh.Ma = dgvChiTietPhieuNhap[0, i].Value.ToString();
                    hh.Ten = dgvChiTietPhieuNhap[1, i].Value.ToString();
                    hh.Nhacungcapma = dgvChiTietPhieuNhap[2, i].Value.ToString();
                    int a;
                    int.TryParse(dgvChiTietPhieuNhap[3, i].Value.ToString(), out a);
                    hh.Soluong = a;
                    hh.Xuatxu = dgvChiTietPhieuNhap[4, i].Value.ToString();
                    hh.Ghichu = dgvChiTietPhieuNhap[5, i].Value.ToString();
                    hh.Them();
                }
                if(dt.Rows.Count >0)
                {
                    hh.Ma = dgvChiTietPhieuNhap[0, i].Value.ToString();
                    hh.Ten = dgvChiTietPhieuNhap[1, i].Value.ToString();
                    hh.Nhacungcapma = dgvChiTietPhieuNhap[2, i].Value.ToString();
                    int c, d;
                    int.TryParse(dt.Rows[0][1].ToString(), out d);
                    int.TryParse(dgvChiTietPhieuNhap[3, i].Value.ToString(), out c);
                    hh.Soluong = d + c;
                    hh.Xuatxu = dgvChiTietPhieuNhap[4, i].Value.ToString();
                    hh.Ghichu = dgvChiTietPhieuNhap[5, i].Value.ToString();
                    hh.Sua();
                }
           
            }
            for (int i = 0; i < dgvChiTietPhieuNhap.Rows.Count; i++)
            {
                ctpn.Hanghoama = dgvChiTietPhieuNhap[0, i].Value.ToString();
                ctpn.Soluong = int.Parse(dgvChiTietPhieuNhap[3, i].Value.ToString());
                ctpn.Donvitinh = dgvChiTietPhieuNhap[6, i].Value.ToString();
                ctpn.Gianhap = decimal.Parse(dgvChiTietPhieuNhap[7, i].Value.ToString());
                ctpn.Thanhtien = decimal.Parse(dgvChiTietPhieuNhap[8, i].Value.ToString());
                ctpn.Phieunhapma = txtMaPN.Text;
                ctpn.them();
            }
                MessageBox.Show("Thêm thành công!!!");
            dgvChiTietPhieuNhap.Rows.Clear();               
            txtMaPN.Text = "";
            cboMaNV.Text = "";
            txtTongTien.Text = "0";
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieuNhap frm = new frmDanhSachPhieuNhap();
            frm.ShowDialog();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            btnCapNhat.Enabled = true;
            dtpNgayNhap.Enabled = true;
            cboMaNV.Enabled = true;
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    txtMaPN.Text = null;
                    DataTable dt = pn.get_phieunhap();
                    if (dt != null)

                    {
                        List<string> list = ((DataTable)dt).AsEnumerable().Select(x => x.Field<string>(dt.Columns[0])).ToList();
                        if (list.Count > 0) txtMaPN.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtMaPN.Text = "0000000001";
                    }
                    else txtMaPN.Text = "0000000001";
                }
            }
        }



        private void dgvChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            them = false;
            int Row_Index = e.RowIndex;
            if (Row_Index >= 0)
            {
                cboMa.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[1].Value.ToString();
                cboNCC.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[2].Value.ToString();
                txtSL.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[3].Value.ToString();
                txtXuatXu.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[4].Value.ToString();
                txtGhichu.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[5].Value.ToString();
                cboDonViTinh.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[6].Value.ToString();
                txtGiaNhap.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[7].Value.ToString();
                txtThanhTien.Text = dgvChiTietPhieuNhap.Rows[Row_Index].Cells[8].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = dgvChiTietPhieuNhap.CurrentRow.Index;
            dgvChiTietPhieuNhap.Rows.RemoveAt(i);
            SetNullHH();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            dgvChiTietPhieuNhap.Rows.Clear();
        }

        private void dgvChiTietPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal thanhtien = 0;
                for (int i = 0; i <= dgvChiTietPhieuNhap.Rows.Count - 1; i++)
                {
                    thanhtien += decimal.Parse(dgvChiTietPhieuNhap[8, i].Value.ToString());
                }
                txtTongTien.Text = thanhtien.ToString();
            }
            catch
            {

            }
        }

       
    }
}

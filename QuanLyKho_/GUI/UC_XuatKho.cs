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
        DataTable tb_chitietcu;
        public UC_XuatKho()
        {
            InitializeComponent();
        }

        private void UC_XuatKho_Load(object sender, EventArgs e)
        {
            refresh_inputThemPX();

        }

        private void tabCtrlPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlPhieuXuat.SelectedTab == tabDanhSach)
            {
                dgvHH.Visible = false;
                Load_DanhSach(dtpTuNgay.Value, dtpDenNgay.Value);
            }
            else
            {
                refresh_inputThemPX();
                pnlThemKhachHang.Visible = false;
                pnlThemPhieu.Visible = true;
            }
        }

        #region Xem Danh Sach Phieu
        private void Load_DanhSach(DateTime tu_ngay, DateTime den_ngay)
        {
            DataTable tb_phieuxuat = DTO.PhieuXuat.Get_PhieuXuat(tu_ngay, den_ngay);
            tb_phieuxuat.Columns.Add("Sua", typeof(string));
            tb_phieuxuat.Columns.Add("Xoa", typeof(string));
            for (int i = 0; i < tb_phieuxuat.Rows.Count; i++)
            {
                tb_phieuxuat.Rows[i].SetField("Sua", "sửa");
                tb_phieuxuat.Rows[i].SetField("Xoa", "xóa");
            }
            dgvPhieuXuat.DataSource = tb_phieuxuat;

            dgvPhieuXuat.Columns["Sua"].HeaderText = "";
            dgvPhieuXuat.Columns["Sua"].DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, SelectionForeColor = Color.Orange, ForeColor = Color.Orange, SelectionBackColor = Color.White };
            dgvPhieuXuat.Columns["Sua"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPhieuXuat.Columns["Sua"].Width = 50;

            dgvPhieuXuat.Columns["Xoa"].HeaderText = "";
            dgvPhieuXuat.Columns["Xoa"].DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, SelectionForeColor = Color.Crimson, ForeColor = Color.Crimson, SelectionBackColor = Color.White };
            dgvPhieuXuat.Columns["Xoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPhieuXuat.Columns["Xoa"].Width = 50;

            TinhTongTienHoaDon();
        }

        private void dtpTuNgaydtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            Load_DanhSach(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void TinhTongTienHoaDon()
        {
            decimal tong = 0;
            for (int i = 0; i < dgvPhieuXuat.Rows.Count; i++)
            {
                tong += (decimal)dgvPhieuXuat.Rows[i].Cells[4].Value;
            }
            labTongTienHD.Text = "Tổng tiền hóa đơn: " + tong + " VND";
        }

        private void dgvPhieuXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Xác nhận sửa.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;

                    tabCtrlPhieuXuat.SelectedTab = tabThemPhieu;

                    btnSave.Text = "Sửa phiếu";
                    txtMaKH.Enabled = false;
                    btnHuy.Visible = true;

                    tb_chitietcu = tb_chitietcu = DTO.ChiTietPhieuXuat.Get_ChiTietPhieuXuat(dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString());

                    load_ChiTietPhieuCu();
                }
                else if (e.ColumnIndex == 8)
                {
                    if (MessageBox.Show("Xác nhận xóa.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
                    string ma_phieuxuat = dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString();
                    tb_chitietcu = DTO.ChiTietPhieuXuat.Get_ChiTietPhieuXuat(ma_phieuxuat);
                    DTO.ChiTietPhieuXuat.Xoa(ma_phieuxuat);
                    DTO.PhieuXuat.Xoa(ma_phieuxuat);
                    for (int i = 0; i < tb_chitietcu.Rows.Count; i++)
                        DTO.HangHoa.Update_SoLuongHang(tb_chitietcu.Rows[i].ItemArray[0].ToString());

                    Load_DanhSach(dtpTuNgay.Value, dtpDenNgay.Value);
                }
            }
        }

        private void txtSeachPX_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgvPhieuXuat.DataSource).DefaultView.RowFilter = string.Format("[{1}] Like '%{0}' OR [{2}] Like '%{0}%'", txtSeachPX.Text, dgvPhieuXuat.Columns[0].Name, dgvPhieuXuat.Columns[2].Name);
            if (txtSeachPX.Text.Trim() == "") TinhTongTienHoaDon();
            else labTongTienHD.Text = "Tổng tiền hóa đơn: ";
        }
        #endregion

        #region Them Sua Phieu Xuat
        private void refresh_inputThemPX()
        {
            DataTable tb_hanghoa = DTO.HangHoa.Get_HH();
            tb_hanghoa.Columns.Remove("Nhà cung cấp");
            tb_hanghoa.Columns.Remove("Ghi chú");
            dgvHH.DataSource = tb_hanghoa;
            ((DataTable)dgvHH.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", dgvHH.Columns[0].DataPropertyName, "!@#", dgvHH.Columns[1].DataPropertyName);

            txtMaNV.DataSource = DTO.NhanVien.get_nhanvien();
            txtMaNV.ValueMember = "Mã Nhân Viên";
            txtMaNV.DisplayMember = "Tên Nhân Viên";

            txtMaPhieu.Text = DTO.PhieuXuat.Get_MaPhieuXuat();
            txtTongTien.Text = "0 VND";
            txtMaKH.Text = "";
            txtMaHang.Text = "";

            btnSave.Text = "Thêm Phiếu";
            btnHuy.Visible = false;
            txtMaKH.Enabled = true;

            dgvCTXK.Rows.Clear();
        }

        private void txtMaHang_dgvHH_Leave(object sender, EventArgs e)
        {
            if (!dgvHH.Focused && !txtMaHang.Focused)
            {
                if (dgvHH.CurrentRow != null)
                    txtMaHang.Text = dgvHH.CurrentRow.Cells[0].Value.ToString();
                dgvHH.Visible = false;
            }
        }

        private void txtMaHang_Enter(object sender, EventArgs e)
        {
            if (txtMaHang.Text != "" && txtMaHang.Text.Trim() != "" && txtMaHang.TextLength > 3)
            {
                dgvHH.Visible = true;
                txtMaHang.SelectAll();
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength == 10)
            {
                DataTable tb_khachhang = DTO.KhachHang.get_khachhang(txtMaKH.Text);
                if (tb_khachhang.Rows.Count > 0)
                {
                    txtTenKh.Text = tb_khachhang.Rows[0].ItemArray[1].ToString();
                    txtDiaChi.Text = tb_khachhang.Rows[0].ItemArray[2].ToString();
                    txtSDT.Text = tb_khachhang.Rows[0].ItemArray[3].ToString();
                }
            }
            else
            {
                txtTenKh.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
            }
        }

        private void update_txtSoLuong_txtGia()
        {
            if (dgvHH.Rows.Count > 0)
            {
                txtGia.Text = DTO.HangHoa.Get_GiaHangHoa(dgvHH.CurrentRow.Cells[0].Value.ToString()).ToString();
                txtSoLuong.Text = (dgvHH.CurrentRow.Cells["_soluong"].Value != DBNull.Value && (int)dgvHH.CurrentRow.Cells["_soluong"].Value > 0) ? "1" : "0";
            }
            else
            {
                txtGia.Text = "0";
                txtSoLuong.Text = "0";
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHang.Text != "" && txtMaHang.Text.Trim() != "" && txtMaHang.TextLength > 2)
            {
                dgvHH.Visible = true;
                ((DataTable)dgvHH.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", dgvHH.Columns[0].DataPropertyName, txtMaHang.Text, dgvHH.Columns[1].DataPropertyName);
            }
            else
            {
                ((DataTable)dgvHH.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", dgvHH.Columns[0].DataPropertyName, "!@#", dgvHH.Columns[1].DataPropertyName);
                dgvHH.Visible = false;
            }
            update_txtSoLuong_txtGia();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (dgvHH.Rows.Count == 0) txtGia.Text = "0";
            if (txtGia.Text == "") txtGia.Text = "0";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && dgvHH.Rows.Count > 0 && dgvHH.CurrentRow.Cells["_soluong"].Value != DBNull.Value)
            {
                if (int.Parse(txtSoLuong.Text) > int.Parse(dgvHH.CurrentRow.Cells["_soluong"].Value.ToString()))
                {
                    txtSoLuong.Text = dgvHH.CurrentRow.Cells["_soluong"].Value.ToString();
                    txtSoLuong.SelectAll();
                }
            }
            else
            {
                txtSoLuong.Text = "0";
                txtSoLuong.SelectAll();
            }
        }

        private void dgvHH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            update_txtSoLuong_txtGia();
            txtMaHang.Text = dgvHH.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Focus();
        }

        private void txtMaHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && dgvHH.Rows.Count > 0)
            {
                e.Handled = true;
                txtMaHang.Text = dgvHH.CurrentRow.Cells[0].Value.ToString();
                txtSoLuong.Focus();
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && dgvHH.Rows.Count > 0)
            {
                e.Handled = true;
                txtSoLuong.Focus();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    e.Handled = true;
                    ThemChiTietPhieuXuat();
                }
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            for (int i = 0; i < dgvCTXK.Rows.Count; i++)
            {
                tong += (decimal)dgvCTXK.Rows[i].Cells["thanhtien"].Value;
            }
            txtTongTien.Text = tong + " VND";
        }

        private void change_SoLuongHangHoaDgv(string ma_hanghoa, int soluongbot)
        {
            DataTable tb_hanghoa = (DataTable)dgvHH.DataSource;
            for (int i = 0; i < tb_hanghoa.Rows.Count; i++)
                if (tb_hanghoa.Rows[i].ItemArray[0].ToString() == ma_hanghoa)
                {
                    tb_hanghoa.Rows[i].SetField("Số lượng", (int)tb_hanghoa.Rows[i].ItemArray[2] - soluongbot);
                    dgvHH.DataSource = tb_hanghoa;
                    for (int j = 0; j < dgvHH.Rows.Count; j++)
                        if (dgvHH.Rows[j].Cells[0].Value.ToString() == ma_hanghoa)
                        {
                            dgvHH.UpdateCellValue(2, j);
                            break;
                        }
                    break;
                }

        }

        private void dgvCTXK_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCTXK.Columns[e.ColumnIndex].Name == "x")
            {
                change_SoLuongHangHoaDgv(dgvCTXK.Rows[e.RowIndex].Cells[0].Value.ToString(), -(int)dgvCTXK.Rows[e.RowIndex].Cells[4].Value);
                dgvCTXK.Rows.Remove(dgvCTXK.Rows[e.RowIndex]);

                TinhTongTien();
            }
        }

        private void ThemChiTietPhieuXuat()
        {
            int soluong = int.Parse(txtSoLuong.Text);
            if (soluong == 0) return;
            decimal gia = decimal.Parse(txtGia.Text);
            decimal thanhtien = gia * soluong;

            bool them = true;
            for (int i = 0; i < dgvCTXK.Rows.Count; i++)
            {
                if (dgvCTXK.Rows[i].Cells[0].Value.ToString() == txtMaHang.Text && (decimal)dgvCTXK.Rows[i].Cells[3].Value == gia)
                {
                    dgvCTXK.Rows[i].Cells[4].Value = (int)dgvCTXK.Rows[i].Cells[4].Value + soluong;
                    dgvCTXK.Rows[i].Cells[5].Value = (decimal)dgvCTXK.Rows[i].Cells[5].Value + thanhtien;
                    them = false;
                    break;
                }
            }

            if (them)
                dgvCTXK.Rows.Add(txtMaHang.Text, dgvHH.CurrentRow.Cells[1].Value, dgvHH.CurrentRow.Cells[3].Value, gia, soluong, thanhtien, "x");

            change_SoLuongHangHoaDgv(txtMaHang.Text, soluong);

            txtMaHang.Text = "";
            txtMaHang.Focus();

            TinhTongTien();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((txtTenKh.Text == "" && txtSDT.Text == "") || dgvCTXK.Rows.Count == 0)
                {
                    System.Media.SystemSounds.Beep.Play();
                    return;
                }

                DTO.PhieuXuat _phieuxuat = new DTO.PhieuXuat()
                {
                    Ma = txtMaPhieu.Text,
                    Nhanvienma = txtMaNV.SelectedValue.ToString(),
                    Khachhangma = txtMaKH.Text,
                    Ngayxuat = dtpNgayXuat.Value,
                    Tongtien = decimal.Parse(txtTongTien.Text.Split(' ')[0])
                };

                if (btnSave.Text == "Thêm Phiếu")
                {
                    _phieuxuat.Them();
                }
                else
                {
                    _phieuxuat.Sua();

                    DTO.ChiTietPhieuXuat.Xoa(_phieuxuat.Ma);
                    for (int i = 0; i < tb_chitietcu.Rows.Count; i++)
                        DTO.HangHoa.Update_SoLuongHang(tb_chitietcu.Rows[i].ItemArray[0].ToString());
                }

                for (int i = 0; i < dgvCTXK.Rows.Count; i++)
                {
                    DTO.ChiTietPhieuXuat chitiet_phieuxuat = new DTO.ChiTietPhieuXuat()
                    {
                        Phieuxuatma = _phieuxuat.Ma,
                        Hanghoama = dgvCTXK.Rows[i].Cells[0].Value.ToString(),
                        Donvitinh = "chiếc",
                        Giaxuat = (decimal)dgvCTXK.Rows[i].Cells[3].Value,
                        Soluong = (int)dgvCTXK.Rows[i].Cells[4].Value,
                        Thanhtien = (decimal)dgvCTXK.Rows[i].Cells[5].Value
                    };

                    chitiet_phieuxuat.Them();

                    DTO.HangHoa.Update_SoLuongHang(chitiet_phieuxuat.Hanghoama);
                }

                if (btnSave.Text == "Thêm Phiếu")
                    refresh_inputThemPX();
                else
                    tabCtrlPhieuXuat.SelectedTab = tabDanhSach;

                MessageBox.Show("Đã " + btnSave.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void load_ChiTietPhieuCu()
        {
            dgvCTXK.Rows.Clear();

            txtMaPhieu.Text = dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            txtMaKH.Text = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
            dtpNgayXuat.Value = (DateTime)dgvPhieuXuat.CurrentRow.Cells[3].Value;
            txtTongTien.Text = (decimal)dgvPhieuXuat.CurrentRow.Cells[4].Value + " VND";
            txtMaNV.SelectedValue = dgvPhieuXuat.CurrentRow.Cells[5].Value.ToString();

            for (int i = 0; i < tb_chitietcu.Rows.Count; i++)
            {
                dgvCTXK.Rows.Add(tb_chitietcu.Rows[i].ItemArray[0], tb_chitietcu.Rows[i].ItemArray[1], tb_chitietcu.Rows[i].ItemArray[2], tb_chitietcu.Rows[i].ItemArray[3], tb_chitietcu.Rows[i].ItemArray[4], tb_chitietcu.Rows[i].ItemArray[5], "x");
            }
        }

        private void btnRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (btnSave.Text == "Thêm Phiếu")
                    refresh_inputThemPX();
                else
                {
                    DataTable tb_hanghoa = DTO.HangHoa.Get_HH();
                    tb_hanghoa.Columns.Remove("Nhà cung cấp");
                    tb_hanghoa.Columns.Remove("Ghi chú");
                    dgvHH.DataSource = tb_hanghoa;
                    ((DataTable)dgvHH.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' OR [{2}] LIKE '%{1}%'", dgvHH.Columns[0].DataPropertyName, "!@#", dgvHH.Columns[1].DataPropertyName);

                    load_ChiTietPhieuCu();
                }
            }
        }

        private void btnHuy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MessageBox.Show("Xác nhận hủy.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
                tabCtrlPhieuXuat.SelectedTab = tabDanhSach;
            }
        }
        #endregion

        #region Them Khach Hang
        private void btnThoat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlThemKhachHang.Visible = false;
                pnlThemPhieu.Visible = true;
            }
        }

        private void btnKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && txtMaKH.Enabled)
            {
                pnlThemPhieu.Visible = false;
                pnlThemKhachHang.Visible = true;
            }
        }

        private void pnlThemKhachHang_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlThemKhachHang.Visible)
            {
                _txtMaKH.Text = DTO.KhachHang.Get_MaKhachHang();
                _txtTenKH.Text = "";
                _txtSDTKH.Text = "";
                _txtDCKH.Text = "";
            }
        }

        private void btnThemKH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DTO.KhachHang kh = new DTO.KhachHang()
                {
                    Ma = _txtMaKH.Text,
                    Ten = _txtTenKH.Text,
                    Sdt = _txtSDTKH.Text,
                    Diachi = _txtDCKH.Text
                };

                kh.them();
                txtMaKH.Text = kh.Ma;

                pnlThemKhachHang.Visible = false;
                pnlThemPhieu.Visible = true;
            }
        }

        private void _txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
    }
}

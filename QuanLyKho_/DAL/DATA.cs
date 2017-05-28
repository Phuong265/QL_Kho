using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DATA
    {
        #region NCC
        public static DataTable get_nhacungcap()
        {
            return DBConnect.GetData("get_nhacungcap");
        }
        public static int them_nhacungcap(string ma, string ten, string diachi, int sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_nhacungcap", para);
        }
        public static int sua_nhacungcap(string ma, string ten, string diachi, int sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_nhacungcap", para);
        }
        public static int xoa_nhacungcap(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_nhacungcap", para);
        }

        #endregion

        #region  Khach Hang
        public static DataTable get_makhachhang()
        {
            return DBConnect.GetData("select max(ma) from khachhang");
        }
        public static DataTable get_khachhang(string makh)
        {
            return DBConnect.GetData("select ma, ten, diachi, sdt from khachhang where ma = '" + makh + "'");
        }
        public static DataTable get_khachhang()
        {
            return DBConnect.GetData("get_khachhang");
        }
        public static int them_khachhang(string ma, string ten, string sdt, string diachi)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sdt",(sdt != "")?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_khachhang", para);
        }
        public static int sua_khachhang(string ma, string ten, string sdt, string diachi)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sdt",(sdt != "")?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_khachhang", para);
        }
        public static int xoa_khachhang(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_khachhang", para);
        }

        #endregion

        #region  phieu nhap
        public static DataTable get_phieunhap()
        {
            return DBConnect.GetData("get_phieunhap");
        }
        public static int them_phieunhap(string ma, string nvma, DateTime ngaynhap, decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@nvma",(nvma!=null && nvma.Trim()!="")?(object)nvma:DBNull.Value),
                new SqlParameter("@day",ngaynhap),
                new SqlParameter("@money",(tongtien >0)?(object)tongtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_phieunhap", para);
        }
        public static int sua_phieunhap(string ma, string nvma, DateTime ngaynhap, decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@nhanvienma",(nvma!=null && nvma.Trim()!="")?(object)nvma:DBNull.Value),
                new SqlParameter("@ngaynhap",ngaynhap),
                new SqlParameter("@tongtien",(tongtien >0)?(object)tongtien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_phieunhap", para);
        }
        public static int xoa_phieunhap(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_phieunhap", para);
        }

        #endregion

        #region  Chi Tiet Phieu Nhap
        public static DataTable get_chitietphieunhap()
        {
            return DBConnect.GetData("get_chitietphieunhap");
        }
        public static int them_chitietphieunhap(string phieunhapma, string hanghoama, int soluong, string donvitinh, decimal gianhap, decimal thanhtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mapn",phieunhapma),
                new SqlParameter("@mahh",hanghoama),
                new SqlParameter("@sl",(soluong >0)?(object)soluong:DBNull.Value),
                 new SqlParameter("@dvt",(donvitinh!=null && donvitinh.Trim()!="")?(object)donvitinh:DBNull.Value),
                  new SqlParameter("@gn",(gianhap >0)?(object)gianhap:DBNull.Value),
                   new SqlParameter("@tt",(thanhtien >0)?(object)thanhtien:DBNull.Value)
           };
            return DBConnect.ExecuteNonQuery("them_chitietphieunhap", para);
        }
        //public static int sua_chitietphieunhap(string pnma, string hhma, int sl, string dvt, decimal gianhap, decimal thanhtien)
        //{
        //    SqlParameter[] para = new SqlParameter[]
        //    {
        //        new SqlParameter("@phieunhapma",pnma),
        //        new SqlParameter("@hanghoama",hhma),
        //        new SqlParameter("@soluong",(sl >0)?(object)sl:DBNull.Value),
        //        new SqlParameter("@donvitinh",dvt),
        //        new SqlParameter("@gianhap",(gianhap >0)?(object)gianhap:DBNull.Value),
        //        new SqlParameter("@thanhtien",(thanhtien >0)?(object)thanhtien:DBNull.Value)
        //    };
        //    return DBConnect.ExecuteNonQuery("sua_chitietphieunhap", para);
        //}
        //public static int xoa_chitietphieunhap(string pnma, string hhma)
        //{
        //    SqlParameter[] para = new SqlParameter[]
        //   {
        //         new SqlParameter("@phieunhapma",pnma),
        //         new SqlParameter("@hanghoama",hhma)
        //   };
        //    return DBConnect.ExecuteNonQuery("xoa_chitietphieunhap", para);
        //}

        #endregion

        #region NhanVien
        public static DataTable get_nhanvien()
        {
            return DBConnect.GetData("get_nhanvien");
        }
        public static int them_nhanvien(string ma, string ten, DateTime? ngaysinh, bool gioitinh, string diachi, int? sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh != null)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_nhanvien", para);
        }
        public static int sua_nhanvien(string ma, string ten, DateTime? ngaysinh, bool gioitinh, string diachi, int? sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh != null)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_nhanvien", para);
        }
        public static int xoa_nhanvien(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_nhanvien", para);
        }

        #endregion

        #region HangHoa
        public static void update_soluonghanghoa(string ma_hanghoa)
        {
            DBConnect.GetData(string.Format("declare @soluong int select @soluong = SUM(soluong) from chitietphieunhap where hanghoama = '{0}' if exists (select * from chitietphieuxuat where hanghoama = '{0}') select @soluong = @soluong - SUM(soluong) from chitietphieuxuat where hanghoama = '{0}' update hanghoa set soluong = @soluong where ma = '{0}'", ma_hanghoa));
        }
        public static DataTable get_giahanghoa(string ma_hanghoa)
        {
            return DBConnect.GetData("select max(gianhap) from chitietphieunhap where hanghoama = '" + ma_hanghoa + "'");
        }
        public static DataTable get_hanghoa()
        {
            return DBConnect.GetData("get_hanghoa");
        }
        // tim kiem
        public static DataTable get_hanghoa_theoten(string ten)
        {
            return DBConnect.GetData("get_hanghoa_theoten N'" + ten + "'");
        }
        public static int them_hanghoa(string ma, string ten, string nhacungcapma, int soluong, string xuatxu, string ghichu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@nhacungcapma",nhacungcapma),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@xuatxu",(xuatxu!=null && xuatxu.Trim()!="")?(object)xuatxu:DBNull.Value),
                new SqlParameter("@ghichu",(ghichu!=null && ghichu.Trim()!="")?(object)ghichu:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_hanghoa", para);
        }
        public static int sua_hanghoa(string ma, string ten, string nhacungcapma, int soluong, string xuatxu, string ghichu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@nhacungcapma",nhacungcapma),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@xuatxu",(xuatxu!=null && xuatxu.Trim()!="")?(object)xuatxu:DBNull.Value),
                new SqlParameter("@ghichu",(ghichu!=null && ghichu.Trim()!="")?(object)ghichu:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_hanghoa", para);
        }
        public static int xoa_hanghoa(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_hanghoa", para);
        }

        #endregion

        #region Phieu Xuat
        public static DataTable get_maphieuxuat()
        {
            return DBConnect.GetData("select max(ma) from phieuxuat");
        }
        public static DataTable get_phieuxuat(DateTime tu_ngay, DateTime den_ngay)
        {
            return DBConnect.GetData("select phieuxuat.ma as [Mã phiếu xuất], khachhang.ma as [Mã khách hàng], khachhang.ten as [Tên khách hàng], ngayxuat as [Ngày xuất], tongtien as [Tổng tiền], nhanvien.ma as [Mã nhân viên], nhanvien.ten as [Tên nhân viên] from phieuxuat join khachhang on phieuxuat.khachhangma = khachhang.ma join nhanvien on phieuxuat.nhanvienma = nhanvien.ma where ngayxuat >= " + string.Format("'{0}-{1}-{2}'", tu_ngay.Year, tu_ngay.Month, tu_ngay.Day) + " and ngayxuat <= " + string.Format("'{0}-{1}-{2}'", den_ngay.Year, den_ngay.Month, den_ngay.Day));
        }
        public static int them_phieuxuat(
            string ma, 
            string nhanvienma,
            string khachhangma, 
            DateTime ngayxuat, 
            decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@nhanvienma", nhanvienma),
                new SqlParameter("@khachhangma", khachhangma),
                new SqlParameter("@ngayxuat", ngayxuat),
                new SqlParameter("@tongtien", tongtien),
            };
            return DBConnect.ExecuteNonQuery("them_phieuxuat", para);
        }
        public static int sua_phieuxuat(
            string ma,
            string nhanvienma,
            string khachhangma,
            DateTime ngayxuat,
            decimal tongtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@nhanvienma", nhanvienma),
                new SqlParameter("@khachhangma", khachhangma),
                new SqlParameter("@ngayxuat", ngayxuat),
                new SqlParameter("@tongtien", tongtien),
            };
            return DBConnect.ExecuteNonQuery("sua_phieuxuat", para);
        }
        public static int xoa_phieuxuat(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_phieuxuat", para);
        }
        #endregion

        #region Chi Tiet Phieu Xuat
        public static DataTable get_chitietphieuxuat(string ma_phieuxuat)
        {
            return DBConnect.GetData("select chitietphieuxuat.hanghoama, hanghoa.ten, hanghoa.xuatxu, chitietphieuxuat.giaxuat, chitietphieuxuat.soluong, chitietphieuxuat.thanhtien from chitietphieuxuat join hanghoa on chitietphieuxuat.hanghoama = hanghoa.ma where chitietphieuxuat.phieuxuatma = '" + ma_phieuxuat + "'");
        }
        public static int them_chitietphieuxuat(
            string phieuxuatma, 
            string hanghoama, 
            int soluong, 
            string donvitinh, 
            decimal giaxuat, 
            decimal thanhtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@phieuxuatma", phieuxuatma),
                new SqlParameter("@hanghoama", hanghoama),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@donvitinh", donvitinh),
                new SqlParameter("@giaxuat", giaxuat),
                new SqlParameter("@thanhtien", thanhtien)
            };
            return DBConnect.ExecuteNonQuery("them_chitietphieuxuat", para);
        }
        public static int sua_chitietphieuxuat(
            string phieuxuatma,
            string hanghoama,
            int soluong,
            string donvitinh,
            decimal giaxuat,
            decimal thanhtien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@phieuxuatma", phieuxuatma),
                new SqlParameter("@hanghoama", hanghoama),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@donvitinh", donvitinh),
                new SqlParameter("@giaxuat", giaxuat),
                new SqlParameter("@thanhtien", thanhtien)
            };
            return DBConnect.ExecuteNonQuery("sua_chitietphieuxuat", para);
        }
        public static int xoa_chitietphieuxuat(string phieuxuatma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@phieuxuatma", phieuxuatma)
            };
            return DBConnect.ExecuteNonQuery("xoa_chitietphieuxuat", para);
        }
        #endregion
    }
}

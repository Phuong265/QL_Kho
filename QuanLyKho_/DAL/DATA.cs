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
        public static DataTable get_khachhang()
        {
            return DBConnect.GetData("get_khachhang");
        }
        public static int them_khachhang(string ma, string ten, int sdt, string diachi)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_khachhang", para);
        }
        public static int sua_khachhang(string ma, string ten, int sdt, string diachi)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sdt",(sdt >0)?(object)sdt:DBNull.Value),
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
    }
}

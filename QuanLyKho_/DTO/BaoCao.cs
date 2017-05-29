using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCao
    {
        private string donvi;
        private DateTime ngaythang;
        private int soluongnhap;
        private int soluongban;
        private string Donvi
        {
            get
            {
                return donvi;
            }
            set
            {
                donvi = value;
            }
        }
        private DateTime NgayThang
        {
            get
            {
                return ngaythang;
            }
            set
            {
                ngaythang = value;
            }
        }
        private int SLnhap
        {
            get
            {
                return soluongnhap;
            }
            set
            {
                soluongnhap = value;
            }
        }
        private int SLban
        {
            get
            {
                return soluongban;
            }
            set
            {
                soluongban = value;
            }
        }
        public static DataTable get_nam()
        {
            return DBConnect.GetData("select distinct year(ngaynhap) as 'nam' from phieunhap");
        }
        public static DataTable get_soluongnhapthang(string nam, string thang)
        {
            string sql = "select sum(ctpn.soluong)as 'slnhap'  from chitietphieunhap ctpn join phieunhap pn on ctpn.phieunhapma= pn.ma  where year(pn.ngaynhap)="+nam+" and (month(pn.ngaynhap)="+thang+" )";
            return DBConnect.GetData(sql);
        }
        public static DataTable get_soluongxuatthang(string nam, string thang)
        {
            string sql = "select sum(ctpx.soluong)as'slxuat' from  phieuxuat px join chitietphieuxuat ctpx on px.ma= ctpx.phieuxuatma where year(px.ngayxuat)="+nam+" and MONTH(px.ngayxuat)="+thang;
            return DBConnect.GetData(sql);
        }
        public static DataTable get_soluongnhapngay(DateTime dt)
        {
            string sql = "	select  distinct sum(ctpn.soluong)as'slnhap' from chitietphieunhap ctpn join phieunhap pn on ctpn.phieunhapma= pn.ma" +
                " where year(pn.ngaynhap)=" + dt.Year + "and (month(pn.ngaynhap)=" + dt.Month + " )and day(pn.ngaynhap)= "+dt.Day;
            return DBConnect.GetData(sql);
        }
        public static DataTable get_soluongxuatngay(DateTime dt)
        {
            string sql = "select sum(ctpx.soluong)as 'slxuat'  from  phieuxuat px join" +
                " chitietphieuxuat ctpx on px.ma= ctpx.phieuxuatma  where year(px.ngayxuat)=" + dt.Year + " and month(px.ngayxuat)=" + dt.Month+ " and day(px.ngayxuat)="+dt.Day ;
            return DBConnect.GetData(sql);
        }
        public static DataTable get_thang(string nam)
        {
            string sql = "select distinct month(ngaynhap) as thang from phieunhap where YEAR(phieunhap.ngaynhap)=" + nam +
"                       union select distinct month(ngayxuat)  from phieuxuat where YEAR(phieuxuat.ngayxuat)= " + nam;
            return DBConnect.GetData(sql);
        }
        public static DataTable get_ngay(string nam, string thang)
        {
            string sql = "select distinct ngaynhap as ngay from phieunhap where MONTH(phieunhap.ngaynhap)=" + thang + " and YEAR(phieunhap.ngaynhap)=" + nam +
                "union select distinct ngayxuat  from phieuxuat where MONTH(phieuxuat.ngayxuat) = " + thang + " and YEAR(phieuxuat.ngayxuat)=" + nam ;
            return DBConnect.GetData(sql);
        }
        public static DataTable SLnhapdaymonth(string nam, string thang)
        {
            string sql = " select SUM(soluong) as 'SL',day(ngaynhap) as 'DAY' from chitietphieunhap join phieunhap pn on " +
                "pn.ma= chitietphieunhap.phieunhapma where year(pn.ngaynhap)= "+nam+" and (month(pn.ngaynhap)="+thang+"  ) group by ngaynhap";
            return DBConnect.GetData(sql);
        }
        public static DataTable SLxuatdaymonth(string nam, string thang)
        {
            string sql = "				 select SUM(soluong) as'SL',day(ngayxuat) as 'DAY' from chitietphieuxuat ct join phieuxuat pn on " +
                "pn.ma= ct.phieuxuatma where year(pn.ngayxuat)= " + nam + " and (month(pn.ngayxuat)=" + thang + "  ) group by ngayxuat";
            return DBConnect.GetData(sql);
        }
        public static DataTable mathangnhapinday(DateTime time)
        {
            return DBConnect.GetData("select hh.*,ct.soluong,ct.gianhap,ct.soluong,ct.donvitinh,pn.nhanvienma from hanghoa hh join chitietphieunhap ct on " +
                "hh.ma = ct.hanghoama join phieunhap pn on pn.ma = phieunhapma where pn.ngaynhap ='"+time.ToShortDateString()+"'");
        }
        public static DataTable mathangxuatinday(DateTime time)
        {
            return DBConnect.GetData("select hh.*,ct.soluong,ct.donvitinh,ct.giaxuat,pn.ngayxuat,pn.khachhangma,pn.nhanvienma from hanghoa hh join chitietphieuxuat ct on" +
                " hh.ma = ct.hanghoama join phieuxuat pn on pn.ma = phieuxuatma where pn.ngayxuat ='" + time.ToShortDateString()+"'");
        }
        public static DataTable mathangnhapinmonth(string nam, string thang)
        {
            return DBConnect.GetData("select hh.*,ct.soluong,ct.gianhap,ct.soluong,ct.donvitinh,pn.nhanvienma from hanghoa hh join chitietphieunhap ct on " +
                "hh.ma = ct.hanghoama join phieunhap pn on pn.ma = phieunhapma where month(pn.ngaynhap) =" + thang+" and year(pn.ngaynhap)="+nam);
        }
        public static DataTable mathangxuatinmonth(string nam, string thang)
        {
            return DBConnect.GetData("select hh.*,ct.soluong,ct.donvitinh,ct.giaxuat,pn.ngayxuat,pn.khachhangma,pn.nhanvienma from hanghoa hh join chitietphieuxuat ct on" +
                " hh.ma = ct.hanghoama join phieuxuat pn on pn.ma = phieuxuatma where month(pn.ngayxuat) =" + thang + " and year(pn.ngayxuat)=" + nam);
        }
    }
}

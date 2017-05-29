using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
    public class KhachHang
    {
        private string ma;
        private string ten;
        private string diachi;
        private string sdt;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
        public DataTable get_khachhang()
        {
            return DATA.get_khachhang();
        }
        public int them()
        {
            return DATA.them_khachhang(ma, ten, sdt, diachi);
        }
        public int sua()
        {
            return DATA.sua_khachhang(ma, ten, sdt, diachi);
        }
        public int xoa(string ma)
        {
            return DATA.xoa_khachhang(ma);
        }
        public static DataTable get_khachhang(string makh)
        {
            return DATA.get_khachhang(makh);
        }
        public static string Get_MaKhachHang()
        {
            string ma = "0000000001";
            DataTable tb = DAL.DATA.get_makhachhang();
            if (tb.Rows.Count > 0 && tb.Rows[0].ItemArray[0] != DBNull.Value && tb.Rows[0].ItemArray[0].ToString() != "")
            {
                ma = string.Format("{0:d10}", int.Parse(tb.Rows[0].ItemArray[0].ToString()) + 1);
            }
            return ma;
        }
    }
}

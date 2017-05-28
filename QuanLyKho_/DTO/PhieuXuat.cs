using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat
    {
        string ma;
        string nhanvienma;
        string khachhangma;
        DateTime ngayxuat;
        decimal tongtien;

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

        public string Nhanvienma
        {
            get
            {
                return nhanvienma;
            }

            set
            {
                nhanvienma = value;
            }
        }

        public string Khachhangma
        {
            get
            {
                return khachhangma;
            }

            set
            {
                khachhangma = value;
            }
        }

        public DateTime Ngayxuat
        {
            get
            {
                return ngayxuat;
            }

            set
            {
                ngayxuat = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public int Them()
        {
            return DAL.DATA.them_phieuxuat(ma, nhanvienma, khachhangma, ngayxuat, tongtien);
        }
        public int Sua()
        {
            return DAL.DATA.sua_phieuxuat(ma, nhanvienma, khachhangma, ngayxuat, tongtien);
        }
        public static int Xoa(string maPX)
        {
            return DAL.DATA.xoa_phieuxuat(maPX);
        }
        public static DataTable Get_PhieuXuat(DateTime tu_ngay, DateTime den_ngay)
        {
            return DAL.DATA.get_phieuxuat(tu_ngay, den_ngay);
        }
        public static string Get_MaPhieuXuat()
        {
            string ma = "0000000001";
            DataTable tb = DAL.DATA.get_maphieuxuat();
            if(tb.Rows.Count >0 && tb.Rows[0].ItemArray[0] != DBNull.Value && tb.Rows[0].ItemArray[0].ToString() != "")
            {
                ma = string.Format("{0:d10}", int.Parse(tb.Rows[0].ItemArray[0].ToString()) + 1);
            }
            return ma;
        }
    }
}

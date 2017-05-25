using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class PhieuNhap
    {
        private string ma;
        private string nhanvienma;
        private DateTime ngaynhap;
        private decimal tongtien;

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

        public DateTime Ngaynhap
        {
            get
            {
                return ngaynhap;
            }

            set
            {
                ngaynhap = value;
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
        public int them()
        {
            return DATA.them_phieunhap(ma, nhanvienma, ngaynhap, tongtien);
        }
        public DataTable get_phieunhap()
        {
            return DATA.get_phieunhap();
        }
    }
}

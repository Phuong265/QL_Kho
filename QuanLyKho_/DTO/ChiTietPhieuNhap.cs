using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private string phieunhapma;
        private string hanghoama;
        private int soluong;
        private string donvitinh;
        private decimal gianhap;
        private decimal thanhtien;

        public string Phieunhapma
        {
            get
            {
                return phieunhapma;
            }

            set
            {
                phieunhapma = value;
            }
        }

        public string Hanghoama
        {
            get
            {
                return hanghoama;
            }

            set
            {
                hanghoama = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Donvitinh
        {
            get
            {
                return donvitinh;
            }

            set
            {
                donvitinh = value;
            }
        }

        public decimal Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

        public decimal Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
        public int them()
        {
            return DATA.them_chitietphieunhap(phieunhapma, hanghoama, soluong, donvitinh, gianhap, thanhtien);
        }
        public DataTable get_chitietphieunhap()
        {
            return DATA.get_chitietphieunhap();
        }
    }
}

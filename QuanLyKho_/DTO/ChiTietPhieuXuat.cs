using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuXuat
    {
        string phieuxuatma;
        string hanghoama;
        int soluong;
        string donvitinh;
        decimal giaxuat;
        decimal thanhtien;

        public string Phieuxuatma
        {
            get
            {
                return phieuxuatma;
            }

            set
            {
                phieuxuatma = value;
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

        public decimal Giaxuat
        {
            get
            {
                return giaxuat;
            }

            set
            {
                giaxuat = value;
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

        public int Them()
        {
            return DAL.DATA.them_chitietphieuxuat(phieuxuatma, hanghoama, soluong, donvitinh, giaxuat, thanhtien);
        }
        public int Sua()
        {
            return DAL.DATA.sua_chitietphieuxuat(phieuxuatma, hanghoama, soluong, donvitinh, giaxuat, thanhtien);
        }
        public static int Xoa(string maPX)
        {
            return DAL.DATA.xoa_chitietphieuxuat(maPX);
        }
        public static DataTable Get_ChiTietPhieuXuat(string ma_phieuxuat)
        {
            return DAL.DATA.get_chitietphieuxuat(ma_phieuxuat);
        }
    }
}

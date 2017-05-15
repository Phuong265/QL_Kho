using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace DTO
{
    public class NhanVien
    {
        private string ma;
        private string ten;
        private bool gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private int sdt;

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

        public bool Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
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

        public int Sdt
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

        public  DataTable get_nhanvien()
        {
            return DATA.get_nhanvien();
        }

        public int Them()
        {
            return DATA.them_nhanvien(ma, ten, ngaysinh, sdt, diachi);
        }
        public int Sua()
        {
            return DATA.sua_nhanvien(ma, ten, ngaysinh, sdt, diachi);
        }
        public int Xoa(string ma)
        {
            return DATA.xoa_nhanvien(ma);
        }
    }
}

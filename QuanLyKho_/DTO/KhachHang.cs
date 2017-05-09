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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DTO
{
    public class NhaCungCap
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
        public DataTable get_nhacungcap()
        {
            return DATA.get_nhacungcap();
        }
        public int them()
        {
            return DATA.them_nhacungcap(ma, ten, diachi, sdt);
        }
        public int sua()
        {
            return DATA.sua_nhacungcap(ma, ten, diachi, sdt);
        }
        public int xoa(string ma)
        {
            return DATA.xoa_nhacungcap(ma);
        }
    }
}

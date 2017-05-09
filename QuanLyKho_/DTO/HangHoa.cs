using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
    public class HangHoa
    {
        private string ma;
        private string ten;
        private string nhacungcapma;
        private int soluong;
        private string xuatxu;
        private string ghichu;

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

        public string Nhacungcapma
        {
            get
            {
                return nhacungcapma;
            }

            set
            {
                nhacungcapma = value;
            }
        }

        public string Xuatxu
        {
            get
            {
                return xuatxu;
            }

            set
            {
                xuatxu = value;
            }
        }

        public string Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
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

        //public static DataTable Get_HH()
        //{
        //    return DATA.get_hanghoa();
        //}
        public int Them()
        {
            return DATA.them_hanghoa(ma, ten, nhacungcapma,soluong, xuatxu, ghichu);
        }
        public int Sua()
        {
            return DATA.sua_hanghoa(ma, ten, nhacungcapma,soluong, xuatxu, ghichu);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_hanghoa(ma);
        }
    }
}

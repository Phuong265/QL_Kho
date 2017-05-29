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

        public static DataTable Get_HH()
        {
            return DATA.get_hanghoa();
        }

        public static DataTable Get_HH_TheoTen(string ten)
        {
            return DATA.get_hanghoa_theoten(ten);
        }
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
        public static decimal Get_GiaHangHoa(string ma_hanghoa)
        {
            decimal gia = 100000;
            DataTable tb = DATA.get_giahanghoa(ma_hanghoa);
            if(tb.Rows.Count > 0 && tb.Rows[0].ItemArray[0] != DBNull.Value)
            {
                gia = (decimal)tb.Rows[0].ItemArray[0];
            }
            return gia;
        }
        public static void Update_SoLuongHang(string ma_hanghoa)
        {
            DATA.update_soluonghanghoa(ma_hanghoa);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class KhachHang
    {
        struct Struct_datphong
        {
            int id;
            DateTime tg_thue;
            DateTime tg_tra;
            public Struct_datphong(int _id , DateTime _tg_thue, DateTime _tg_tra)
            {
                id = _id;
                tg_thue = _tg_thue;
                tg_tra = _tg_tra;
            }
        }
        public string TenKH { get; set; }
        public string CMND { get; set; }
        public string sdt { get; set; }
        
        public bool TrangThai { get; set; }
        List<Struct_datphong> DsPhong;
        
        public KhachHang(string _TenKH, string _CMND)
        {
            TenKH = _TenKH;
            CMND = _CMND;
        }
        public bool DatPhong(List<int> idPhong, DateTime tgbd, DateTime tgKT)
        {
            DsPhong = new List<Struct_datphong>();
            bool res = true;
            //truy van co so du lieu, cap nhat dat phong neu dat phong thanh cong return 1, ko return 0
            foreach (int i in idPhong)
            {
                DsPhong.Add( new Struct_datphong(i, tgbd, tgKT));
            }
            return res;
        }

    }
}

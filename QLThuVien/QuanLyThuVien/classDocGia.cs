using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class classDocGia
    {
        public string ten;
        public string id;
        public DateTime tgbd;
        public DateTime tgkt;
        public string donvi;
        public classDocGia(string _ten, DateTime _tgbd, DateTime _tgkt, string _donvi)
        {
            ten = _ten;
            tgbd = _tgbd;
            tgkt = _tgkt;
            donvi = _donvi;
            
        }
    }
}

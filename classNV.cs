using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class classNV
    {
        public string hoten;
        public string quequan;
        public DateTime ns;
        public string donvi;
        public string chucvu;
        public int bacluong;
        public classNV(string _hoten, string _qq, DateTime _ns, string _donvi, string _chucvu, int _bacluong)
        {
            hoten = _hoten; quequan = _qq; ns = _ns; donvi = _donvi; chucvu = _chucvu; bacluong = _bacluong;
        }
        public classNV()
        {
        }
    }
}

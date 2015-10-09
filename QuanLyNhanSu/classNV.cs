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
        public string sodienthoai;
        public string socmnd;
        public int hesoluong;
        public classNV(string _hoten, string _qq, DateTime _ns, string _donvi, string _sodt,string _socmnd, int _bacluong)
        {
            hoten = _hoten; 
            quequan = _qq; 
            ns = _ns; 
            donvi = _donvi; 
            sodienthoai = _sodt; 
            hesoluong = _bacluong;
            socmnd = _socmnd;
        }
        public classNV()
        {
        }
    }
}

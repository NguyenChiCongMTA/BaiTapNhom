using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class classSach
    {
        public string Ten;
        public string TacGia;
        public int sl;
        private string ID;
        public classSach()
        {
        }
        public classSach(string _ten, string _TacGia, int _sl)
        {
            Ten = _ten;
            TacGia = _TacGia;
            sl = _sl; 
        }

             
    }
}

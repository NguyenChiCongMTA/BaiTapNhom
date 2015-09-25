using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class classThem
    {
        public static classNV newNV;
        public classThem(string hoten, string que, DateTime ns, string donvi, string chucvu, string bacluong)
        {
            int bl = 0;
            if (int.TryParse(bacluong, out bl))
              newNV = new classNV(hoten, que, ns, donvi, chucvu, bl);
        }
        public static int them(string hoten, string que, DateTime ns, string donvi, string chucvu, string bacluong)
        {
            int bl = 0;
            if (int.TryParse(bacluong, out bl))
                newNV = new classNV(hoten, que, ns, donvi, chucvu, bl);
            else return -1; 
            if (classThem.newNV == null) return -1 ;
            //them thanh cong tra ra 0, ko thanh con tra ra -1, hien message thong bao
            return 0;
        }
    }
}

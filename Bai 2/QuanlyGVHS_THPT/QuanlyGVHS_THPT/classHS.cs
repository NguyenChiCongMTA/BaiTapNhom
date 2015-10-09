using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyGVHS_THPT
{
    class classHS
    {
        public  string name;
        public DateTime ns;
        public string dc;
        public string sdt;
        public string lop;
        public string ID;
        KQ kq;
        public classHS(string _name, DateTime _ns, string _dc, string _sdt, string _lop,KQ _kq)
        {
            name = _name; ns = _ns; dc = _dc; sdt = _sdt; lop = _lop; kq = _kq;
        }
        public classHS(string _name, DateTime _ns, string _dc, string _sdt, string _lop)
        {
            name = _name; ns = _ns; dc = _dc; sdt = _sdt; lop = _lop; 
        }
        public classHS()
        {
        }
    }
}

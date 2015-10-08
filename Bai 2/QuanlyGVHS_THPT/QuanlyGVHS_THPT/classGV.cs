using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyGVHS_THPT
{
    class classGV
    {
        public string name;
        public DateTime ns;
        public string dc;
        public string sdt;
        public string ch_mon;
        public classGV()
        {
        }
        public classGV(string _name, DateTime _ns, string _dc, string _sdt, string _ch_mon)
        {
            name = _name; ns = _ns; dc = _dc; sdt = _sdt; ch_mon = _ch_mon;
        }
    }
}

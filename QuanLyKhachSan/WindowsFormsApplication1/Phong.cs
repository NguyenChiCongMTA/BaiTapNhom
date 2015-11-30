using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Phong
    {
        public int ID { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime NgayTra { get; set; }
        public bool TrangThai { get; set; }
        List< KeyValuePair<string,int> > ThietBi ;
        public Phong(bool _trangthai,List< KeyValuePair< string,int > > thietbi)
        {
            TrangThai = _trangthai;
            ThietBi = thietbi;
        }
        public Phong(DateTime _ngaythue, DateTime _ngaytra)
        {
            NgayThue = _ngaythue;
            NgayTra = _ngaytra;
            if (TrangThai == true)
            {
                if (DateTime.Today <= _ngaytra && DateTime.Today >= NgayThue)
                    TrangThai = false;
            }
        }
        
    }
}

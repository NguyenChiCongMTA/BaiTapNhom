using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyGVHS_THPT
{
    class KQ
    {
        public double ht_10;
        public double ht_11;
        public double ht_12;
        public char rl_10;
        public char rl_11;
        public char rl_12;
        public KQ(double _ht10,double _ht11,double _ht12,char _rl10,char _rl11,char _rl12)
        {
            ht_10 = _ht10; ht_11 = _ht11; ht_12 = _ht12;
            rl_10 = _rl10;  rl_11 = _rl11; rl_12 = _rl12;
        }
        public KQ()
        {
        }
    }
}

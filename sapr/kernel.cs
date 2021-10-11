using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr
{
    [Serializable]
    class Kernel
    {
        public int numb { get; set; }
        public double L { get; set; }
        public double A { get; set; }
        public double E { get; set; }
        public double V { get; set; }
        public double Q { get; set; }
        public Kernel(int n, double l, double a, double e, double v, double q)
        {
            numb = n;
            L = l;
            A = a;
            E = e;
            V = v;
            Q = q;
        }
    }
}

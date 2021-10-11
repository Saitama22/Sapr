using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr
{
    [Serializable]
    class Knot
    {
        public int number { get; set; }
        public double F { get; set; }
        Knot(int n, double f)
        {
            number = n;
            F = f;
        }
        public Knot(double f)
        {
            F = f;
        }
    }
}

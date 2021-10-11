using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr
{
    [Serializable]
    class Logic
    {
        List<Kernel> ListKers = new List<Kernel>();
        List<Knot> ListKnots = new List<Knot>();
        public bool left { get; set; }
        public bool right{ get; set; }
        [NonSerialized]
        int curker;
        public Logic() {
            curker = 0;
            left = false;
            right = false;
        }
        public void addKer(Kernel ker)
        {
            ListKers.Add(ker);
            curker = 0;
        }
        public void addKer(Kernel ker, int numK)
        {
            //  LinkedList<int> a = new LinkedList<int>;
            ListKers.Insert(numK, ker);
            curker = 0;
            //istKers.
        }
        public void setKer(Kernel ker, int numb)
        {
            ListKers[numb] = ker;
        }
        public void rm(int numb)
        {
            curker = 0;
            if (ListKers.Count != 0)
                ListKers.Remove(ListKers[numb]);
        }
        //public (double, double, double) getNextker()
        //{
        //    if(curker != ListKers.Count)
        //    {
        //        return (ListKers[curker].L, ListKers[curker].A, ListKers[curker++].Q);
        //    }
        //    return (-1, -1, -1);
        //}
        public bool hasEls()
        {
            return (ListKers.Count != 0);
        }
        //public (double, double, double) getFker()
        //{
        //    curker = 0;
        //    return (ListKers[curker].L, ListKers[curker].A, ListKers[curker++].Q);
        //}
        public Kernel[] getKernels()
        {
            return ListKers.ToArray();
        }
        public Knot[] GetKnots()
        {
            return ListKnots.ToArray();
        }
        public (string, string, string, string, string) getdata(int num)
        {
            if (num >= ListKers.Count)
                return ("10", "10", "10", "10", "10");
            return (ListKers[num].L.ToString(), 
                ListKers[num].A.ToString(), 
                ListKers[num].E.ToString(), 
                ListKers[num].V.ToString(),
                ListKers[num].Q.ToString());
        }
        public int max()
        {
            return ListKers.Count;
        }

        public void addZeroF()
        {
            ListKnots.Add(new Knot(0));
        }
        public void moveF(int n)
        {
            //ListKnots[n + 1].F = ListKnots[n].F;
            //ListKnots[n].F = 0;            
        }
        public void toZeroF(int n)
        {
            ListKnots[n].F = 0;
        }
        public void addF(double f)
        {
            ListKnots.Add(new Knot(f));
        }
        public void setf(int n, double f)
        {
            ListKnots[n].F = f;
        }
        public string getKnot(int num)
        {
            if (num >= ListKnots.Count)
                return "10";
            return ListKnots[num].F.ToString();
        }
        //public double getKnotDouble(int num)
        //{
        //    if (num >= ListKnots.Count)
        //        return 0;
        //    return ListKnots[num].F;
        //}
        public void rmf(int numb)
        {
            if (numb < ListKnots.Count && ListKnots.Count != 0)
                ListKnots[numb].F = 0;
        }
    }
}

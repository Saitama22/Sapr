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
        public bool right { get; set; }
        [NonSerialized]
        int curker;
        public Logic()
        {
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




        public double[] solveB()
        {
            double[] B = new double[ListKers.Count + 1];
            for (int i = 0; i <= ListKers.Count; i++)
            {                
                B[i] += ListKnots[i].F;
                if (i != 0)
                    B[i] += ListKers[i - 1].Q * ListKers[i - 1].L / 2;
                if (i != ListKers.Count)
                    B[i] += ListKers[i].Q * ListKers[i].L / 2;
            }
            if (left == true)
                B[0] = 0;
            if (right == true)
                B[ListKers.Count] = 0;
            return B;
        }
        public double[,] solveA()
        {
            double[,] A = new double[ListKers.Count + 1, ListKers.Count + 1];
            for (int i = 0; i < ListKers.Count + 1; i++)
            {
                for (int j = 0; j < ListKers.Count + 1; j++)
                {
                    A[i, j] = 0;
                }
            }
            for (int i = 0; i < ListKers.Count; i++)
            {
                A[i, i] += ListKers[i].A * ListKers[i].E / ListKers[i].L;
                A[i, i + 1] -= ListKers[i].A * ListKers[i].E / ListKers[i].L;
                A[i + 1, i] -= ListKers[i].A * ListKers[i].E / ListKers[i].L;
                A[i + 1, i + 1] += ListKers[i].A * ListKers[i].E / ListKers[i].L;
            }
            if (left == true)
            {
                A[0, 0] = 1;
                A[1, 0] = 0;
                A[0, 1] = 0;
            }
            if (right == true)
            {
                A[ListKers.Count, ListKers.Count] = 1;
                A[ListKers.Count - 1, ListKers.Count] = 0;
                A[ListKers.Count, ListKers.Count - 1] = 0;
            }
            return A;
        }

        public double[] solve6()
        {
            double[,] A = new double[ListKers.Count + 1, ListKers.Count + 1];
            double[] B = new double[ListKers.Count + 1];
            A =solveA();
            B = solveB();
            A = Auxil.inversion(A, ListKers.Count + 1);
            return Auxil.VecMatMul(A, B, ListKers.Count + 1);
        }

        public double[,] solveN()
        {
            double[,] A = new double[ListKers.Count + 1, ListKers.Count + 1];
            double[] B = new double[ListKers.Count + 1];
            A = solveA();
            B = solveB();
            A = Auxil.inversion(A, ListKers.Count + 1);
            double[] v6 = Auxil.VecMatMul(A, B, ListKers.Count + 1);
            double[,] N = new double[ListKers.Count, 2];
            for (int i = 0; i < ListKers.Count; i++)
            {
                N[i, 0] = (ListKers[i].A * ListKers[i].E / ListKers[i].L) * (v6[i + 1] - v6[i]);
                if (ListKers[i].Q!=0)
                {
                    N[i, 0] += (ListKers[i].Q * ListKers[i].L /2);
                    N[i, 1] -= ListKers[i].Q;
                }                
            }
            return N;
        }
        public double[,] solveU()
        {
            double[,] A = new double[ListKers.Count + 1, ListKers.Count + 1];
            double[] B = new double[ListKers.Count + 1];
            A = solveA();
            B = solveB();
            A = Auxil.inversion(A, ListKers.Count + 1);
            double[] v6 = Auxil.VecMatMul(A, B, ListKers.Count + 1);
            double[,] U = new double[ListKers.Count, 3];
            for (int i = 0; i < ListKers.Count; i++)
            {
                U[i, 0] = v6[i];
                U[i, 1] = (v6[i + 1] - v6[i]) / ListKers[i].L;
                U[i, 1] += (ListKers[i].Q * ListKers[i].L) / (2 * ListKers[i].E * ListKers[i].A);
                U[i, 2] = -(ListKers[i].Q / (2 * ListKers[i].E * ListKers[i].A)); 
            }
            return U;
        }
        public double[] getL()
        {
            double[] arrL = new double[ListKers.Count];
            for (int i = 0; i < ListKers.Count; i++)
            {
                arrL[i] = ListKers[i].L;
            }
            return arrL;
        }
    }
}

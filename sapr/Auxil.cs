using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapr
{
    class Auxil
    {
        public static bool IsPosnumb(string str)
        {
            double numb;
            try
            {
                numb = Double.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            if (numb <= 0)
                return false;
            return true;
        }
        public static bool IsNumb(string str)
        {
            if (str.Length == 0)
                return true;
            double numb;
            try
            {
                numb = Double.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //public static bool Isnumb(object str)
        //{
        //    //double numb = Double.Parse(str.ToString());
        //    //if (numb.ToString().Length != str.ToString().Length || str.ToString().Contains("-"))
        //    //    return false;
        //    //return true;
        //}

        public static double[,] inversion(double[,] A, int N)
        {
            double temp;

            double[,] E = new double[N,N];


            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    E[i,j] = 0f;

                    if (i == j)
                        E[i,j] = 1f;
                }

            for (int k = 0; k < N; k++)
            {
                temp = A[k,k];

                for (int j = 0; j < N; j++)
                {
                    A[k,j] /= temp;
                    E[k,j] /= temp;
                }

                for (int i = k + 1; i < N; i++)
                {
                    temp = A[i,k];

                    for (int j = 0; j < N; j++)
                    {
                        A[i,j] -= A[k,j] * temp;
                        E[i,j] -= E[k,j] * temp;
                    }
                }
            }

            for (int k = N - 1; k > 0; k--)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    temp = A[i,k];

                    for (int j = 0; j < N; j++)
                    {
                        A[i,j] -= A[k,j] * temp;
                        E[i,j] -= E[k,j] * temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    A[i,j] = E[i,j];
            return E;
        }
        public static double[] VecMatMul(double[,] inputMartix, double[] vector, int N)
        {
            //if (inputMartix.ColumnsCount() != vector.Length)
            //{
            //    throw new Exception("Умножение не возможно! Количество столбцов матрицы должно совпадать с количеством элементов вектора.");
            //}

            double []resultMatrix = new double[N];

            for (var i = 0; i < N; i++)
            {
                resultMatrix[i] = 0;

                for (var k = 0; k < N; k++)
                {
                    resultMatrix[i] += inputMartix[i, k] * vector[k];
                }
            }
            return resultMatrix;
        }
        public static string optstr(string str)
        {
            if (str[str.Length - 3] == '0')
            {
                str = str.Remove(str.Length - 3, 1);
                if (str[str.Length - 2] == '0')
                {
                    str = str.Remove(str.Length - 2, 1);
                    if (str[str.Length - 1] == '0')
                        str = str.Remove(str.Length - 3);
                }
            }
            return str;
        }
    }
}

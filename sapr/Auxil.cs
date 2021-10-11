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
    }
}

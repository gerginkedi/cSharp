using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneUzerindenMetod
{
    internal class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
        public double Topla(double a, double b)
        {
            return a + b;
        }


        public double Topla(double a, double b, double c)// 2 metodunda adio ayni bu yuzden overload metod oldu
        {
            return a + b + c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha15_2
{
    internal static class RaizQuad
    {
        public static int raizquadrada(int num)
        {
            return (int)Math.Sqrt(num);
        }
        public static double raizquadrada(double num)
        {
            return Math.Round(Math.Sqrt(num),2);
        }
    }
}

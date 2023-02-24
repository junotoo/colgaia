using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    public static class RaizQuad
    {
        public static int RaizQuadrada(int num)
        {
            return (int) Math.Sqrt(num);
        }

        public static double RaizQuadrada(double num)
        {
            return Math.Round(Math.Sqrt(num), 2);
        }

        public static double RaizQuadrada(double num, int tamanho)
        {
            return Math.Round(Math.Sqrt(num), tamanho);
        }
    }
}

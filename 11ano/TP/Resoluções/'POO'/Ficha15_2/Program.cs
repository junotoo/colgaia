using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = RaizQuad.raizquadrada(5);
            double num2 = RaizQuad.raizquadrada(502.2);
            Console.Write(num+ "\t" );
            Console.Write(num2);
            Console.ReadKey();
        }
    }
}

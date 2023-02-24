using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FazerCirculos();
        }

        static void FazerCirculos()
        {
            int N = 0, x = 0, y = 0;
            double raio = 0.5;
            bool flag;

            do
            {
                Console.WriteLine("Introduza o número de círculos: ");
                flag = int.TryParse(Console.ReadLine(), out N);
                
                if (!flag)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (!flag);

            Console.Clear();

            Circulo[] circulo = new Circulo[N];

            for (int i = 0; i < N; i++)
            {
                circulo[i] = new Circulo(x, y, raio);
                x++;
                y++;
                raio *= 2;
            }

            foreach (Circulo circulo_sh in circulo)
            {
                Console.WriteLine(circulo_sh.CoodCentro());
                Console.WriteLine(circulo_sh.Area());
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}

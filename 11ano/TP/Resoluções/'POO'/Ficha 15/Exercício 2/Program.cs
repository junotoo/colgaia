using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            int root_int, dec_place;
            double root_doub;

            do
            {
                Console.WriteLine("Introduza um número inteiro para a raiz: ");
                flag = int.TryParse(Console.ReadLine(), out root_int);
                if (!flag)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (!flag);

            Console.Clear();

            do
            {
                Console.WriteLine("Introduza um número real para a raiz: ");
                flag = double.TryParse(Console.ReadLine(), out root_doub);
                if (!flag)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!flag);

            Console.Clear();

            do
            {
                Console.WriteLine("Introduza o número de casas decimais para a última opção: ");
                flag = int.TryParse(Console.ReadLine(), out dec_place);
                if (!flag)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!flag);

            Console.Clear();

            Console.WriteLine("Raiz inteira: " + RaizQuad.RaizQuadrada(root_int));
            Console.WriteLine("Raiz real (2 casas decimais): " + RaizQuad.RaizQuadrada(root_doub));
            Console.WriteLine("Raiz real ({0} casas decimais): " + RaizQuad.RaizQuadrada(root_doub, dec_place), dec_place);
            Console.ReadKey();
        }
    }
}

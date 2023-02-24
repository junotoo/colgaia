using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApelidoNome apelidoNome = new ApelidoNome();

            do
            {
                Console.WriteLine("Introduza um nome: ");
                apelidoNome.PNome = Console.ReadLine();

                if (apelidoNome.PNome == "")
                {
                    Console.WriteLine("O nome não pode estar nulo!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (apelidoNome.PNome == "");

            Console.Clear();

            do
            {
                Console.WriteLine("Introduza um apelido: ");
                apelidoNome.PApelido = Console.ReadLine();
                
                if (apelidoNome.PApelido == "")
                {
                    Console.WriteLine("O apelido não pode estar nulo!");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (apelidoNome.PApelido == "");

            Console.Clear();

            Console.WriteLine("Apelido, Nome: {0}", apelidoNome.ToString());
            Console.ReadKey();
        }
    }
}

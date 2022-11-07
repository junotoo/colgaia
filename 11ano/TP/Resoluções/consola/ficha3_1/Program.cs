using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 3_1 \n\nSelecione o exercicio:\n 1 - Ex01 \n 2 - Ex02 \n 3 - Ex03\n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            ex01();
                            break;
                        case 2:
                            ex02();
                            break;
                        case 3:
                            ex03();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void ex01()
        {
            bool y = false;
            double[] notas = new double[3];
            for (int i = 1; i < 20; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    while (y == false)
                    {
                        Console.Write("Introduza a {0}ª nota do {1}º aluno: ", j, i);
                        y = double.TryParse(Console.ReadLine(), out notas[j - 1]);
                        if (!y)
                        {
                            Console.WriteLine("Introduza um valor válido. \n \n \n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    Console.Write(" A média do {0}º aluno é:", ((notas[0] + notas[1] + notas[2]) / 3));
                }
            }
            Console.ReadKey();
        }
        static void ex02()
        {
            double x = 0;
            for (double i = 1; i <= 20; i++)
            {
                x = i;
                for (double j = 2; j <= i; j++)
                {
                    x += (i / j);
                }
                Console.WriteLine("N = {0} | S = " + x, i);
            }
            Console.ReadKey();
        }
        static void ex03()
        {
            double x = 0;
            for (double i = 1; i <= 20; i++)
            {
                x = 1;
                for (double j = 0; j < i; j++)
                {
                    x = x * (i-j);
                }
                Console.WriteLine("Fatorial de {0}: "+x, i);
            }
            Console.ReadKey();
        }
    }
}

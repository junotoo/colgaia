using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione o exercicio:\n 1 - Ex02 \n 2 - Ex03 \n 3 - Ex04 \n 4 - Ex06 \n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            ex02();
                            break;
                        case 2:
                            ex03();
                            break;
                        case 3:
                            ex04();
                            break;
                        case 4:
                            ex06();
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
        static void ex02()
        {
            bool y = false;
            int num = 0;
            while (y == false)
            {
                Console.Write("Introduza um valor: ");
                y = int.TryParse(Console.ReadLine(), out num);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(num*i);
            }
            Console.ReadKey();
        }
        static void ex03()
        {
            bool y = false;
            int num = 0;
            while (y == false)
            {
                Console.Write("Introduza um valor: ");
                y = int.TryParse(Console.ReadLine(), out num);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine(num + i);
            }
            Console.ReadKey();
        }
        static void ex04()
        {
            for (int i = 2; i < 40; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void ex06()
        {
            bool y = false;
            int num = 0;
            int num2 = 0;
            while (y == false)
            {
                Console.Write("Introduza um valor: ");
                y = int.TryParse(Console.ReadLine(), out num);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            for(int i = 1; i < 30; i++)
            {
                num2 += num / i;
            }
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}

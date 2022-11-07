    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 6A \n\nSelecione o exercicio:\n 1 - Ex01 \n 2 - Ex02 \n 3 - Ex03\n 4 - Ex04\n 5 - Ex05\n 6 - Ex06 \n \n 0 - Sair do programa");
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
                        case 4:
                            ex04();
                            break;
                        case 5:
                            ex05();
                            break;
                        case 6:
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
        static void ex01()
        {
            int num=lerNum("Introduza um valor: ");
                if (positivo(num))
                {
                    Console.WriteLine("O número é positivo");
                }
                else
                {
                    Console.WriteLine("O número não é positivo");
                }
                Console.ReadKey();
        }
        static bool positivo(int num)
        {
            if (num > 0)
            {
                return true;
            }
            else return false;
            
        }
        static void ex02()
        {
            int num = lerNum("Introduza um valor: ");
            if (nulo(num))
            {
                Console.WriteLine("O número é nulo");
            }
            else
            {
                Console.WriteLine("O número não é nulo");
            }
            Console.ReadKey();
        }
        static bool nulo(int num)
        {
            if (num == 0)
            {
                return true;
            }
            else return false;

        }
        static int lerNum(string write)
        {
            bool y = false;
            int num = 0;
            while (y == false)
            {
                Console.Write(write);
                y = int.TryParse(Console.ReadLine(), out num);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            return num;
        }
        static void ex03()
        {
            int num1 = lerNum("Introduza o valor de a: ");
            int num2 = lerNum("Introduza o valor de b: ");
            int num3 = lerNum("Introduza o valor de c: ");
            Console.WriteLine("delta = " + delta(num1, num2, num3));
            Console.ReadKey();
        }
        static int delta(int num1,int num2,int num3)
        {
            return num2 ^ 2 - 4 * num1 * num3;
        }
        static void ex04()
        {
            int num1 = lerNum("Introduza o valor de a: ");
            int num2 = lerNum("Introduza o valor de b: ");
            int num3 = lerNum("Introduza o valor de c: ");
            if (!nulo(num1))
            {
                int delta1 = delta(num1, num2, num3);
                if (delta1 > 0)
                {
                    Console.WriteLine("Raiz 1: " + (-num2 + Math.Sqrt(delta1)) / (2 * num1));
                    Console.WriteLine("Raiz 2: " + (-num2 + Math.Sqrt(delta1)) / (2 * num1));
                }
                else if (nulo(delta1))
                {
                    Console.WriteLine("Raiz : " + -num1 / (2 * num1));
                }
                else if (delta1 < 0) Console.WriteLine("O valor de delta não pode ser negativo.");
            } else Console.WriteLine("O valor de a não pode ser negativo.");
            Console.ReadKey();
        }
        static void ex05()
        {
            Console.WriteLine("1 - Celsius para Farenheit \n2 - Farenheit para Celsius");
            int escolha = lerNum("");
            int temp = lerNum("Introduza a tempertura: ");
            switch (escolha)
            {
                case 1:
                    Console.Write("A temperatura em Farenheit é: " + (temp * 9 / 5 + 32));
                    break;
                case 2:
                    Console.Write("A temperatura em Celsius é: " + (temp - 32) * 5 / 9);
                    break;
            }
            Console.ReadKey();
        }
        static void ex06()
        {
            Random random = new Random();
            int[] cont = new int[7];
            Array.Clear(cont, 0, 7);
            for (int i = 0; i < 300; i++)
            {
                cont[Dado(random)] += 1;
            }
            for (int i = 0; i < cont.Length; i++)
            {
                Console.WriteLine(" O número {0} foi gerado {1} vezes.",i,cont[i]+1);
            }
            Console.ReadKey();
        }
        static int Dado(Random rnd)
        {
            return rnd.Next(0,7);
        }
    }
}

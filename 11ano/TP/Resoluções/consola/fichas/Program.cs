using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione o exercicio:\n 1 - Ex02 \n 2 - Ex04 \n 3 - Ex06 \n 4 - Ex11 \n \n 5 - Sair do programa");
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
                            ex04();
                            break;
                        case 3:
                            ex06();
                            break;
                        case 4:
                            ex11();
                            break;
                        case 5:
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
            Int16 c = 1;
            do
            {
                Console.WriteLine(c++);
            } while (c <= 20);
            Console.ReadKey();
        }
        static void ex04()
        {
            Int16 c = 0;
            Console.Write("Introduza um valor:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 1)
            {
                num++;
            }
            do
            {
                Console.WriteLine(num + c);
                c += 2;
            } while (c < 20);
            Console.ReadKey();
        }
        static void ex06()
        {
            Console.Write("Introduza a nota do teste teórico:");
            double nota1 = int.Parse(Console.ReadLine());
        Console.Write("Introduza a nota do teste prático:");
            double nota2 = int.Parse(Console.ReadLine());
        double media = (nota1 + nota2) / 2;
            if (media >= 9.5)
            {
                Console.WriteLine("Aluno Aprovado, nota:" + media);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado, nota:" + media);
            }
            Console.ReadKey();
        }
        static void ex11()
        {
            int num;
            Int16 c = 0;
            Console.Write("Introduza um valor:");
            int maior = int.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.Write("Introduza um valor:");
                num = int.Parse(Console.ReadLine());
                if (num > maior)
                {
                    maior = num;
                }
                c++;
            } while (c < 30);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecione o exercicio:\n 1 - Ex01 \n 2 - Ex02 \n 3 - Ex03 \n 4 - Ex04 \n 5 - Ex05 \n 6 - Ex06 \n \n 0 - Sair do programa");
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
            short c = 0;
            while (c < 20)
            {
                Console.WriteLine(++c);
            }
            Console.ReadKey();
        }
        static void ex02()
        {
            Console.Write("Introduza um valor: ");
            int num = int.Parse(Console.ReadLine());
            short c = 1;
            while (c <= 30)
            {
                Console.WriteLine(num + c++);
            }
            Console.ReadKey();
        }
        static void ex03()
        {
            short c = 0;
            while (c < 80)
            {
                Console.WriteLine(c += 2);
            }
            Console.ReadKey();
        }
        static void ex04()
        {
            bool y = false;
            char x = '\0';
            int vogais, digitos, pontuacao, outros;

            vogais =  digitos = pontuacao = outros = 0;

            while (x != ' ')
            {
                    Console.Write("Introduza um carater: ");
                    y = char.TryParse(Console.ReadLine(), out x);
                    Console.Clear();
                    if (!y)
                    {
                        Console.WriteLine("Introduza um carater válido. \n \n \n");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                x = char.ToLower(x);
                switch (x)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vogais++;
                        break;
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        digitos++;
                        break;
                    case ':':
                    case '.':
                    case ',':
                    case ';':
                    case '!':
                    case '?':
                        pontuacao++;
                        break;
                    default:
                        outros++;
                        break;
                }
            }
            Console.WriteLine("Foram introduzidos: \n - {0} vogais \n - {1} digitos \n - {2} carateres de pontuação \n - {3} outros carateres", vogais, digitos, pontuacao, --outros);
            Console.ReadKey();
        }
        static void ex05()
        {
            bool y = false;
            Int16 c = 0;
            while (c < 15)
            {
                Console.Write("Introduza o nome do aluno: ");
                string nome = Console.ReadLine();
                while (y == false)
                {
                    Console.Write("Introduza a idade do aluno: ");
                    y = Int16.TryParse(Console.ReadLine(), out Int16 idade);
                    if (!y)
                    {
                        Console.WriteLine("Introduza uma idade válida. \n \n \n");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                }
                c++;

            }
        }
        static void ex06()
        {
            bool y = false;
            while (y == false)
            {
                Console.Write("Introduza um número: ");
                y = Int16.TryParse(Console.ReadLine(), out Int16 idade);
                if (!y)
                {
                    Console.WriteLine("Introduza uma idade válida. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}

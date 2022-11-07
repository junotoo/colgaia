using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha4
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
            double[] num = new double[20];
            for (int i = 0; i < 20; i++)
            {
                bool y = false;
                while (y == false)
                {
                    Console.Write("Introduza o {0}º número: ", i + 1);
                    y = double.TryParse(Console.ReadLine(), out num[i - 1]);
                    if (!y)
                    {
                        Console.WriteLine("Introduza um valor válido. \n \n \n");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                Console.ReadKey();
            }
            Console.WriteLine(" O 3º elemento lido:" + num[2]);
            Console.WriteLine(" O 8º elemento lido + o 18º:" + (num[7] + num[17]));
            Console.WriteLine("O resultado do último menos o primeiro:" + (num[19] - num[0]));
            Console.ReadKey();
        }
        static void ex02()
        {
            int[] num = new int[11];
            bool y = false;
            while (y == false)
            {
                Console.Write("Introduza o valor: ");
                y = int.TryParse(Console.ReadLine(), out num[5]);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            for (int i = -5; i < 5; i++)
            {
                num[i+5] = num[i+5]+i;
                Console.WriteLine(num[i + 5]);
            }
            Console.ReadKey();
        }
        static void ex03()
        {
            double[] num = new double[20];
            for (int i = 0; i < 20; i++)
            {
                bool y = false;
                while (y == false)
                {
                    Console.Write("Introduza o {0}º número: ", i + 1);
                    y = double.TryParse(Console.ReadLine(), out num[i]);
                    if (!y)
                    {
                        Console.WriteLine("Introduza um valor válido. \n \n \n");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
            }
            double[] num2 = Enumerable.Reverse(num).ToArray();
            Console.WriteLine("vetor 1: " + String.Join(",", num));
            Console.WriteLine("vetor 2: " + String.Join(",", num2));
            Console.ReadKey();
        }
        static void ex04()
        {
            int[] nums = new int[10];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("             MENU \n\n 1 - Leitura de 10 valores \n 2 - Mostra elementos \n 3 - Inverte valores lidos\n 4 - Média dos elementos lidos  \n\n 0 - Fim");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            for (int c = 0; c < 10; c++)
                            {
                                bool y = false;
                                while (y == false)
                                {
                                    Console.Write("Introduza o {0}º número: ", i + 1);
                                    y = int.TryParse(Console.ReadLine(), out nums[i]);
                                    if (!y)
                                    {
                                        Console.WriteLine("Introduza um valor válido. \n \n \n");
                                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                }
                            }
                            break;
                        case 2:
                            ex04_2(nums);
                            break;
                        case 3:
                            nums =Enumerable.Reverse(nums).ToArray();
                            break;
                        case 4:
                            Console.WriteLine("A média é: " + ex04_4(nums));
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
        static void ex04_2(int[] nums)
        {
            Console.WriteLine("vetor 2: " + String.Join(",", nums));
            Console.ReadKey();
        }
        static int ex04_4(int[] nums)
        {
            int media = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                media += nums[i];   
            }
            media /= nums.Length;
            return media;
        }
    }
}

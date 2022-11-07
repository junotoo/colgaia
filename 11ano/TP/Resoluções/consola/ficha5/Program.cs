using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 3_1 \n\nSelecione o exercicio:\n 1 - Ex01 \n 2 - Ex02 \n 3 - Ex03\n 4 - Ex04 \n \n 0 - Sair do programa");
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
            int[,] nums = new int[4,4];
            int soma, max;
            soma = max = 0;
            for (int i = 0; i < 4; i++) 
            {
                for (int c = 0; c < 4; c++)
                {
                    bool y = false;
                    while (y == false)
                    {
                        Console.Write("Introduza o {0}º número: ", (c + 1)+(i*4));
                        y = int.TryParse(Console.ReadLine(), out nums[i, c]);
                        if (!y)
                        {
                            Console.WriteLine("Introduza um valor válido. \n \n \n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    soma+=nums[i, c];
                    if (nums[i, c] > max)
                    {
                        max = nums[i, c];
                    }
                }
            }
            Console.WriteLine("A soma de todos os elementos foi: {0}\n\n A Média dos elementos lidos foi: {1}\n\n O maior elemento lido foi:{2}", soma, soma/16, max);
            Console.WriteLine("\n\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static void ex02()
        {
            int[,] nums = new int[10, 5];
            int[,] nums2 = new int[10, 5];
            int[,] soma = new int[10, 5];
            nums = LerMatriz(ref soma,1);
            nums2 = LerMatriz(ref soma,2);
            Console.WriteLine(String.Join(", ", soma.Cast<int>()));
            Console.ReadKey();
        }
        static int[,] LerMatriz(ref int[,] soma, int numMat)
        {
            int[,] nums = new int[10, 5];
            for (int i = 0; i < 10; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    bool y = false;
                    while (y == false)
                    {
                        Console.Write("Introduza o {0}º número da {1} matriz: ", (c + 1) + (i * 5),numMat);
                        y = int.TryParse(Console.ReadLine(), out nums[i, c]);
                        if (!y)
                        {
                            Console.WriteLine("Introduza um valor válido. \n \n \n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    soma[i,c]+= nums[i,c];
                }
            }
            return nums;
        }
        static void ex03()
        {
            int[,] nums = LerMatriz2(1);
            int[,] nums2 = LerMatriz2(2);
            int[] vet1,vet2,vet3,vet4;
            vet1 = CriarVetor(nums, nums2, 0);
            vet2 = CriarVetor(nums, nums2, 1);
            vet3 = CriarVetor(nums, nums2, 2);
            vet4 = CriarVetor(nums, nums2, 3);
            Console.WriteLine("vetor 1: "+String.Join(",", vet1));
            Console.WriteLine("\nvetor 2: "+String.Join(",", vet2));
            Console.WriteLine("\nvetor 3: "+String.Join(",", vet3));
            Console.WriteLine("\nvetor 4: "+String.Join(",", vet4));
            Console.ReadKey();
        }
        static int[,] LerMatriz2(int numMat)
        {
            int[,] nums = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    bool y = false;
                    while (y == false)
                    {
                        Console.Write("Introduza o {0}º número da {1} matriz: ", (c + 1) + (i * 4), numMat);
                        y = int.TryParse(Console.ReadLine(), out nums[i, c]);
                        if (!y)
                        {
                            Console.WriteLine("Introduza um valor válido. \n \n \n");
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                }
            }
            return nums;
        }
        static int[] CriarVetor(int[,] mat1,int[,] mat2, int col)
        {
            int[] vet = new int[5];
            for (int i = 0; i < 4; i++)
            {
                vet[i] = mat1[i, col] + mat2[i, col];
            }
            return vet;
        }
        static void ex04()
        {
            int[,] nums = new int[6, 4];
            bool y = false;
            while (y == false)
            {
                Console.Write("Introduza um valor: ");
                y = int.TryParse(Console.ReadLine(), out nums[0, 0]);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            for(int i = 0; i < nums.GetLength(1); i++)
            {
                for(int j = 0; j < nums.GetLength(0); j++)
                {
                    nums[j, i] = nums[0,0]-j-i ;
                    Console.Write(nums[j, i] + "\t");
                }
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

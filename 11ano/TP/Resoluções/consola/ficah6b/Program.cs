using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha6b
{
    internal class Program
    {
        public static int[,] mat1_1 = new int[3, 3];
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 6B \n\nSelecione a versão:\n 1 - Versão 1 \n 2 - Versão 2\n 3 - Versão 3\n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            ver1();
                            break;
                        case 2:
                            ver2();
                            break;
                        case 3:
                            ver3();
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
        static void ver1()
        {
            int a = 0;
            while (true)
            {
                
                switch (menu(a))
                {
                    case 1:
                        ver1_1();
                        a = 1;
                        break;
                    case 2:
                        ver1_2();
                        break;
                    case 3:
                        ver1_3();
                        break;
                    case 4:
                        Console.WriteLine(ver1_4());
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(ver1_5());
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static int menu(int a)
        {
            bool y = false;
            Int16 num = 0;
            while (y == false)
            { 
                Console.WriteLine("Menu \n\n 1 - Ler matriz quadrada \n 2 - Ver Matriz \n 3 - Diagonal Principal\n 4 - media\n 5 - maior\n\n 0 - Sair do programa");
                y = Int16.TryParse(Console.ReadLine(), out num);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            if (a == 0 & num != 1 & num != 0)
            {
                Console.WriteLine("Os dados têm de ser lidos antes de qualquer operação");
                return 1;
            }
            return num;
        }
        static void ver1_1()
        {
            for (int i = 0; i < mat1_1.GetLength(1); i++) {
                for (int j = 0; j < mat1_1.GetLength(0); j++) {
                bool y = false;
                    while (y == false)
                    {
                        Console.WriteLine("Introduza o {0}º valor da {1}ª coluna",i+1,j+1);
                        y = int.TryParse(Console.ReadLine(), out mat1_1[i,j]);
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
        }
        static void ver1_2()
        {
            for (int i = 0; i < mat1_1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1_1.GetLength(1); j++)
                {
                    Console.Write(mat1_1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ver1_3()
        {
            for (int i = 0; i < mat1_1.GetLength(0); i++)
            {
                Console.Write(mat1_1[i, i] + "\t");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static int ver1_4()
        {
            int media=0;
            for (int i = 0; i < mat1_1.GetLength(1); i++)
            {
                for (int j = 0; j < mat1_1.GetLength(0); j++)
                {
                    media += mat1_1[i, j];
                }
            }
            media /= (mat1_1.GetLength(0) + mat1_1.GetLength(1));
            return media;
        }
        static int ver1_5()
        {
            int maior = mat1_1[0,0];
            for (int i = 0; i < mat1_1.GetLength(1); i++)
            {
                for (int j = 0; j < mat1_1.GetLength(0); j++)
                {
                    if (mat1_1[i,j]> maior)
                    {
                        maior = mat1_1[i, j];
                    }
                }
            }
            return maior;
        }
        static void ver2()
        {
            int a = 0;
            int[,] mat2 = new int[3, 3];
            while (true)
            {

                switch (menu(a))
                {
                    case 1:
                        ver2_1(mat2);
                        a = 1;
                        break;
                    case 2:
                        ver2_2(mat2);
                        break;
                    case 3:
                        ver2_3(mat2);
                        break;
                    case 4:
                        Console.WriteLine(ver2_4(mat2));
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(ver2_5(mat2));
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void ver2_1(int[,] mat2)
        {
            for (int i = 0; i < mat2.GetLength(1); i++)
            {
                for (int j = 0; j < mat2.GetLength(0); j++)
                {
                    bool y = false;
                    while (y == false)
                    {
                        Console.WriteLine("Introduza o {0}º valor da {1}ª coluna", i + 1, j + 1);
                        y = int.TryParse(Console.ReadLine(), out mat2[i, j]);
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
        }
        static void ver2_2(int[,] mat2)
        {
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.Write(mat2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ver2_3(int[,] mat2)
        {
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                Console.Write(mat2[i, i] + "\t");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static int ver2_4(int[,] mat2)
        {
            int media = 0;
            for (int i = 0; i < mat2.GetLength(1); i++)
            {
                for (int j = 0; j < mat2.GetLength(0); j++)
                {
                    media += mat2[i, j];
                }
            }
            media /= (mat2.GetLength(0) + mat2.GetLength(1));
            return media;
        }
        static int ver2_5(int[,] mat2)
        {
            int maior = mat2[0, 0];
            for (int i = 0; i < mat2.GetLength(1); i++)
            {
                for (int j = 0; j < mat2.GetLength(0); j++)
                {
                    if (mat2[i, j] > maior)
                    {
                        maior = mat2[i, j];
                    }
                }
            }
            return maior;
        }
        static void ver3()
        {
            int a = 0;
            int[,] mat3 = new int[3, 3];
            while (true)
            {

                switch (menu(a))
                {
                    case 1:
                        ver3_1(ref mat3);
                        a = 1;
                        break;
                    case 2:
                        ver3_2(ref mat3);
                        break;
                    case 3:
                        ver3_3(ref mat3);
                        break;
                    case 4:
                        Console.WriteLine(ver3_4(ref mat3));
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine(ver3_5(ref mat3));
                        Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void ver3_1(ref int[,] mat3)
        {
            for (int i = 0; i < mat3.GetLength(1); i++)
            {
                for (int j = 0; j < mat3.GetLength(0); j++)
                {
                    bool y = false;
                    while (y == false)
                    {
                        Console.WriteLine("Introduza o {0}º valor da {1}ª coluna", i + 1, j + 1);
                        y = int.TryParse(Console.ReadLine(), out mat3[i, j]);
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
        }
        static void ver3_2(ref int[,] mat3)
        {
            for (int i = 0; i < mat3.GetLength(0); i++)
            {
                for (int j = 0; j < mat3.GetLength(1); j++)
                {
                    Console.Write(mat3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ver3_3(ref int[,] mat3)
        {
            for (int i = 0; i < mat3.GetLength(0); i++)
            {
                Console.Write(mat3[i, i] + "\t");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        static int ver3_4(ref int[,] mat3)
        {
            int media = 0;
            for (int i = 0; i < mat3.GetLength(1); i++)
            {
                for (int j = 0; j < mat3.GetLength(0); j++)
                {
                    media += mat3[i, j];
                }
            }
            media /= (mat3.GetLength(0) + mat3.GetLength(1));
            return media;
        }
        static int ver3_5(ref int[,] mat3)
        {
            int maior = mat3[0, 0];
            for (int i = 0; i < mat3.GetLength(1); i++)
            {
                for (int j = 0; j < mat3.GetLength(0); j++)
                {
                    if (mat3[i, j] > maior)
                    {
                        maior = mat3[i, j];
                    }
                }
            }
            return maior;
        }
    }
}

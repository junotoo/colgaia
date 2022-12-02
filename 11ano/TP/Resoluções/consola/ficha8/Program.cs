using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> lista = new List<int>();
            int j = 0;
            int x = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 8 \n\nSelecione uma opção:\n 1 - Ler \n 2 - Escrever\n 3 - Ler ficheiro\n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            lista = new List<int>();
                            leitura(ref lista);
                            j++;
                            break;
                        case 2:
                            if (j > 0)
                            {
                                escrever(lista);
                                x++;
                            }
                            else
                            {
                                Console.WriteLine("Deve fazer a leitura(opção 1) primeiro...");
                                Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 3:
                            if (i > 0)
                            {
                                lerficheiro();
                            }
                            else
                            {
                                Console.WriteLine("Deve fazer a escrita(opção 2) primeiro...");
                                Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                            }
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
        static void leitura(ref List<int> lista)
        {
            do
            {
                bool y = false;
                int num = 0;
                while (y == false)
                {
                    Console.Write("Introduza o {0}º valor: ", (lista.Count+1));
                    y = int.TryParse(Console.ReadLine(), out num);
                    if (!y)
                    {
                        Console.WriteLine("Introduza um valor válido. \n \n \n");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    } else lista.Add(num);
                    Console.Clear();
                }
            } while (!lista.Contains(0));
            lista.Remove(0);
        }
        static void escrever(List<int> lista)
        {
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\tp\ficha9");
            try
            {
                dir1.Create();
                if (File.Exists(@"C:\tp\ficha8\Numeros.txt")) File.Delete(@"C:\tp\ficha8\Numeros.txt");
                FileStream fls = new FileStream(@"C:\tp\ficha8\Numeros.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fls);
                foreach (int i in lista)
                {
                    sw.WriteLine(i.ToString());
                }
                sw.Close();
                Console.WriteLine("Valores introduzidos!");
                Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
        static void lerficheiro()
        {
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha8\Numeros.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fls);
                Console.Write("Existem {0} números: ", File.ReadAllLines(@"C:\tp\ficha9\Numeros.txt").Count());
                for (int i = 0; i < File.ReadAllLines(@"C:\tp\ficha9\Numeros.txt").Count(); i++)
                {
                    Console.Write(sr.ReadLine() + " ");
                }
                sr.Close();
            }
            catch (IOException ex) { Console.WriteLine(ex); }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juno_21
{
    internal class Program //Juno Oliveira @ 09/12/2022
    {
        static void Main(string[] args)
        {
            int[] codNum = new int[2];
            string[] descProd = new string[2];
            int[] precos = new int[2];
            int opt = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Adicionar informação da(s) Peça(s)\n\n2. Listar a indormação relativa às peças que iniciam a descrição por uma dada letra\n\n3. Sair da aplicação");
                bool y = int.TryParse(Console.ReadLine(),out opt);
                Console.Clear();
                if (y) {
                    switch (opt){
                        case 1:
                            adicionarInfo(ref codNum,ref descProd,ref precos);
                            break;
                        case 2:
                            listarInfos(codNum,descProd,precos);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Introduza um valor válido.\n\n Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("O valor introduzido não era numérico.\n\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        static void adicionarInfo(ref int[] vetCods,ref string[] descProd,ref int[] precos)
        {
            int codNum = 0;
            bool y = false;
            int preco = 0;
            int[] vet2 = vetCods;
            string[] vetstr = descProd;
            int[] vet3 = precos;
            while (!y)
            {
                Console.Write("Introduza o código numérico da peça: ");
                y = int.TryParse(Console.ReadLine(), out codNum);
                if (y)
                {
                    vet2[vet2.Length - 1] = codNum;
                    vetCods = new int[vetCods.Length+1];
                    int c = 0;
                    foreach(int i in vet2)
                    {
                        vetCods[c] = i;
                        c++;
                    }
                }
                else {
                    Console.WriteLine("O valor introduzido não era numérico.\n\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            Console.Write("Introduza a descrição do produto: ");
            vetstr[vetstr.Length - 1] = Console.ReadLine(); ;
            descProd = new string[descProd.Length + 1];
            int j = 0;
            foreach (string i in vetstr)
            {
                vetstr[j] = i;
                j++;
            }
            y = false;
            while (!y)
            {
                Console.Write("Introduza o preço da peça: ");
                y = int.TryParse(Console.ReadLine(), out preco);
                if (y)
                {
                    vet3[vet3.Length - 1] = preco;
                    precos = new int[precos.Length + 1];
                    int c = 0;
                    foreach (int i in vet3)
                    {
                        precos[c] = i;
                        c++;
                    }
                }
                else
                {
                    Console.WriteLine("O valor introduzido não era numérico.\n\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
        static void listarInfos(int[] vetCods, string[] descProd, int[] precos)
        {
            bool y = false;
            char c = ' ';
            bool enc = false;
            Console.Write("Introduza o carater a procurar: ");
            while (!y)
            {
                Console.Write("Introduza o código numérico da peça: ");
                y = char.TryParse(Console.ReadLine(), out c);
                if (y)
                {
                    for (int i = 0; i < descProd.Length; i++)
                    {
                        if (descProd[i].StartsWith(c.ToString()))
                        {
                            if (!enc)
                            {
                                Console.WriteLine("Foram encontrados o(s) seguinte(s) valore(s): \n");
                            }
                            Console.WriteLine(vetCods[i]);
                            Console.WriteLine(descProd[i]);
                            Console.WriteLine(precos[i] + "\n");
                            enc = true;
                        }
                    }
                    if (!enc) { Console.WriteLine("Não foi encontrada nenhuma peça..."); }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("O valor introduzido não era um carater.\n\n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}

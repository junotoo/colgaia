using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Contactos
{
    internal class Program //Juno Oliveira @ 09/12/2022
    {
        static void Main(string[] args)
        {
            int opt = 0;
            List<string> nums = new List<string>();
            List<string> nomes = new List<string>();
            lerFicheiro(ref nums, ref nomes);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Inserir contacto\n\n2. Alterar contacto\n\n3. Sair da aplicação");
                bool y = int.TryParse(Console.ReadLine(), out opt);
                Console.Clear();
                if (y)
                {
                    switch (opt)
                    {
                        case 1:
                            inserirCont(ref nums, ref nomes);
                            break;
                        case 2:
                            alterarContacto(nums, nomes);
                            break;
                        case 3:
                            escreverFicheiro(nums, nomes);
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
                Console.Clear();
            }
        }
        static void inserirCont(ref List<string> nums, ref List<string> nomes)
        {
            Console.Write("Introduza o nome do contacto: ");
            nums.Add(Console.ReadLine());
            Console.Clear();
            Console.Write("Introduza o número do contacto: ");
            nomes.Add(Console.ReadLine());
        }
        static void lerFicheiro(ref List<string> nums, ref List<string> nomes)
        {
            DirectoryInfo dir1 = new DirectoryInfo((@"C:\contactos\"));
            dir1.Create();
            FileStream fls = new FileStream(@"C:\contactos\contactos.bin", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fls);
            for (int i = 0; i < File.ReadAllLines(@"C:\contactos\contactos.bin").Count(); i++)
            {
                nums.Add(br.ReadString());
                nomes.Add(br.ReadString());
            }
            br.Close();
        }
        static void escreverFicheiro(List<string> nums, List<string> nomes)
        {
            DirectoryInfo dir1 = new DirectoryInfo((@"C:\contactos\"));
            dir1.Create();
            FileStream fls = new FileStream(@"C:\contactos\contactos.bin", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fls);
            for (int i = 0; i < nums.Count; i++)
            {
                bw.Write(nums[i]);
                bw.Write(nomes[i]);
            }
            bw.Close();
        }
        static void alterarContacto(List<string> nums, List<string> nomes)
        {
            bool enc = false;
            Console.Write("Introduza o nome do contacto a alterar: ");
            string alt = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == alt)
                {
                    if (!enc)
                    {
                        Console.WriteLine("Foram encontrados o(s) seguinte(s) contacto(s): \n");
                    }
                    Console.WriteLine("O número é: " + nums[i] + "\n");
                    Console.Write("Alterar para: ");
                    nums[i] = Console.ReadLine();
                    enc = true;
                }
            }
            if (!enc) { Console.WriteLine("Não foi encontrado nenhum contacto..."); }
            Console.ReadKey();
        }

    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ficha10b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir1 = new DirectoryInfo(@"C:\tp\ficha10");
            dir1.Create();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 10 \n\nSelecione uma opção:\n 1 - Ler \n 2 - Pesquisar por nome\n 3 - Pesquisar por idade\n 4 - Procurar por data de nascimento\n 5 - Apagar Aluno\n 6 - Listar todos\n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            leitura();
                            break;
                        case 2:
                            if (File.Exists(@"C:\tp\ficha10\alunos"))
                            {
                                procurarNome();
                            }
                            break;
                        case 3:
                            if (File.Exists(@"C:\tp\ficha10\alunos"))
                            {
                                procurarIdade();
                            }
                            break;
                        case 4:
                            if (File.Exists(@"C:\tp\ficha10\alunos"))
                            {
                                procurarData();
                            }
                            break;
                        case 5:
                            apagarLinha();
                            break;
                        case 6:
                            try
                            {
                                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos", FileMode.OpenOrCreate, FileAccess.Read);
                                BinaryReader sr = new BinaryReader(fls);
                                try
                                {
                                    while (true)
                                    {
                                        string s = sr.ReadString();
                                        string ida = sr.ReadString();
                                        string dt = sr.ReadString();
                                        Console.WriteLine("Nome:\t\t\t" + s);
                                        Console.WriteLine("Idade:\t\t\t" + ida);
                                        Console.WriteLine("Data de nascimento:\t" + dt + "\n");
                                    }
                                }
                                catch { }
                                sr.Close();
                            }
                            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
                            Console.ReadKey();
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
        static void leitura()
        {
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos", FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fls);
                try
                {
                    Console.Write("Introduza o nome do aluno: ");
                    bw.Write(Console.ReadLine());
                    Console.Clear();
                    bw.Write(lerIdade().ToString());
                    bw.Write(lerDataNasc().ToString("yyyy-dd-MM"));
                    bw.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }
            }
            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
        }
        static int lerIdade()
        {
            bool y = false;
            int idade = 0;
            while (y == false)
            {
                Console.Write("Introduza a idade do aluno: ");
                y = int.TryParse(Console.ReadLine(), out idade);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            return idade;
        }
        static DateTime lerDataNasc()
        {
            bool y = false;
            DateTime dataNasc = new DateTime(1999 - 10 - 10);
            while (y == false)
            {
                Console.Write("Introduza a data de nascimento do aluno: ");
                y = DateTime.TryParse(Console.ReadLine(), out dataNasc);
                if (!y)
                {
                    Console.WriteLine("Introduza uma data válida. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            return dataNasc;
        }
        static void procurarNome()
        {
            Console.Write("Introduza o nome a procurar: ");
            string pesq = Console.ReadLine();
            Console.Clear();
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader sr = new BinaryReader(fls);
                try
                {
                    while (true)
                    {
                        string s = sr.ReadString();
                        string i = sr.ReadString();
                        string dt = sr.ReadString();
                        if (s.IndexOf(pesq) != -1)
                        {
                            Console.WriteLine("Nome:\t\t\t" + s);
                            Console.WriteLine("Idade:\t\t\t" + i);
                            Console.WriteLine("Data de nascimento:\t" + dt + "\n");
                        }
                    }
                }
                catch { }
                sr.Close();
            }
            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
            Console.ReadKey();
        }
        static void procurarIdade()
        {
            bool y = false;
            int pesq = 0;
            while (y == false)
            {
                Console.Write("Introduza a idade a procurar: ");
                y = int.TryParse(Console.ReadLine(), out pesq);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader sr = new BinaryReader(fls);
                try
                {
                    while (true)
                    {
                        string s = sr.ReadString();
                        string i = sr.ReadString();
                        string dt = sr.ReadString();
                        if (i == pesq.ToString())
                        {
                            Console.WriteLine("Nome:\t\t\t" + s);
                            Console.WriteLine("Idade:\t\t\t" + i);
                            Console.WriteLine("Data de nascimento:\t" + dt + "\n");
                        }
                    }
                }
                catch { }
                sr.Close();
            }
            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
            Console.ReadKey();
        }
        static void procurarData()
        {
            bool y = false;
            DateTime pesq = new DateTime(1999 - 10 - 10);
            while (y == false)
            {
                Console.Write("Introduza a data de nascimento a procurar: ");
                y = DateTime.TryParse(Console.ReadLine(), out pesq);
                if (!y)
                {
                    Console.WriteLine("Introduza uma data válida. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader sr = new BinaryReader(fls);
                try
                {
                    while (true)
                    {
                        string s = sr.ReadString();
                        string i = sr.ReadString();
                        string dt = sr.ReadString();
                        if (dt == pesq.ToString("yyyy-dd-MM"))
                        {
                            Console.WriteLine("Nome:\t\t\t" + s);
                            Console.WriteLine("Idade:\t\t\t" + i);
                            Console.WriteLine("Data de nascimento:\t" + dt + "\n");
                        }
                    }
                }
                catch { }
                sr.Close();
            } catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
            Console.ReadKey();
        }
        static void apagarLinha()
        {

            string nomeRem;
            Console.Write("Introduza o nome a remover: ");
            nomeRem = Console.ReadLine();
            Console.Clear();
            string filePath = @"C:\tp\ficha10\alunos";
            string tempFilePath = "tempFile.dat";
            bool prim = true;
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(tempFilePath, FileMode.Create)))
                    {
                        while (reader.PeekChar() > -1)
                        {
                            string nome = reader.ReadString();
                            string dt = reader.ReadString();
                            string idade = reader.ReadString();

                            if (nome != nomeRem || (nome == nomeRem && !Confirmar(nome, idade, dt, prim)))
                            {
                                prim = false;
                                writer.Write(nome);
                                writer.Write(dt);
                                writer.Write(idade);
                            }
                        }
                    }
                }
                File.Delete(filePath);
                File.Move(tempFilePath, filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
            Console.WriteLine("Aluno(s) Removido(s).");
            Console.ReadKey();
        }
        static bool Confirmar(string nome, string idade, string dt, bool prim)
        {
            if (!prim) { Console.WriteLine("O seguinte aluno tem o mesmo nome que o aluno a remover.\n"); }
            else { Console.WriteLine("Foi encontrado o seguinte aluno: \n"); }
            Console.WriteLine("Nome:\t\t\t" + nome);
            Console.WriteLine("Idade:\t\t\t" + idade);
            Console.WriteLine("Data de nascimento:\t" + dt + "\n");
            Console.WriteLine("Deseja confirmar? (Alunos com nomes iguais serão mostrados após pressionar 'n') [Y/n]");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "" || input.ToUpper() == "Y" || input.ToUpper().StartsWith("Y"))
            {
                return true;
            }
            else return false;
        }
    }
}

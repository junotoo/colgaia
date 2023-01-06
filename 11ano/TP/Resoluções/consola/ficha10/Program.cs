using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nome = new List<string>();
            List<int> idade = new List<int>();
            List<string> dataNasc = new List<string>();
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
                    lerficheiro(ref nome, ref idade, ref dataNasc);
                    switch (i)
                    {
                        case 1:
                            leitura();
                            break;
                        case 2:
                            if (File.Exists(@"C:\tp\ficha10\alunos.save"))
                            {
                                procurarNome(nome, idade, dataNasc);
                            }
                            break;
                        case 3:
                            if (File.Exists(@"C:\tp\ficha10\alunos.save"))
                            {
                                procurarIdade(nome, idade, dataNasc);
                            }
                            break;
                        case 4:
                            if (File.Exists(@"C:\tp\ficha10\alunos.save"))
                            {
                                procurarData(nome, idade, dataNasc);
                            }
                            break;
                        case 5:
                            apagarLinha(ref nome,ref idade,ref dataNasc);
                            break;
                        case 6:
                            for (int j = 0; j <= nome.Count-1; j++)
                            {
                                if (nome[j] != null)
                                {
                                    Console.WriteLine("Nome:\t\t\t" + nome[j]);
                                    Console.WriteLine("Idade:\t\t\t" + idade[j]);
                                    Console.WriteLine("Data de nascimento:\t" + dataNasc[j] + "\n");
                                }
                                else break;
                            }
                            Console.ReadKey();
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                    nome.Clear();
                    idade.Clear();
                    dataNasc.Clear();
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
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos.save", FileMode.Append, FileAccess.Write);
                StreamWriter bw = new StreamWriter(fls);
                try
                {
                    Console.Write("Introduza o nome do aluno: ");
                    bw.WriteLine(Console.ReadLine());
                    Console.Clear();
                    bw.WriteLine(lerIdade());
                    bw.WriteLine(lerDataNasc().ToString("yyyy-dd-MM"));
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
        static void lerficheiro(ref List<string> nome, ref List<int> idade, ref List<string> dataNasc)
        {
            try
            {
                FileStream fls = new FileStream(@"C:\tp\ficha10\alunos.save", FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fls);
                try
                {
                    while (true)
                    {
                        nome.Add(sr.ReadLine());
                        idade.Add(int.Parse(sr.ReadLine()));
                        dataNasc.Add(sr.ReadLine());
                    }
                }
                catch { }
                sr.Close();
            }
            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
        }
        static void procurarNome(List<string> nome, List<int> idade, List<string> dataNasc)
        {
            Console.Write("Introduza o nome a procurar: ");
            string pesq = Console.ReadLine();
            int c = 0;
            foreach (string s in nome)
            {
                if (s == null) break;
                if (s.IndexOf(pesq) != -1)
                {
                    Console.WriteLine("Nome:\t\t\t" + s);
                    Console.WriteLine("Idade:\t\t\t" + idade[c]);
                    Console.WriteLine("Data de nascimento:\t" + dataNasc[c] + "\n");
                }
                c++;
            }
            Console.ReadKey();
        }
        static void procurarIdade (List<string> nome, List<int> idade, List<string> dataNasc)
        {
            int c = 0;
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
            foreach (int s in idade)
            {
                if (s == pesq)
                {
                    Console.WriteLine("Nome:\t\t\t" + nome[c]);
                    Console.WriteLine("Idade:\t\t\t" + s);
                    Console.WriteLine("Data de nascimento:\t" + dataNasc[c] + "\n");
                }
                c++;
            }
            Console.ReadKey();
        }
        static void procurarData(List<string> nome, List<int> idade, List<string> dataNasc)
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
            int c = 0;
            foreach (string s in dataNasc)
            {
                DateTime data = DateTime.Parse(s);
                if (pesq == data)
                {
                    Console.WriteLine("Nome:\t\t\t"+nome[c]);
                    Console.WriteLine("Idade:\t\t\t"+idade[c]);
                    Console.WriteLine("Data de nascimento:\t"+s + "\n");
                }
                c++;
            }
            Console.ReadKey();
        }
        static void apagarLinha(ref List<string> nome, ref List<int> idade, ref List<string> dataNasc)
        {
            try
            {
                string nomeRem;
                Console.Write("Introduza o nome a remover: ");
                nomeRem = Console.ReadLine();
                Console.Clear();
                try
                {
                    if (nome.IndexOf(nomeRem) != -1)
                    {
                        int c = nome.IndexOf(nomeRem);
                        Console.WriteLine("O seguinte aluno será removido.\n");
                        Console.WriteLine("Nome:\t\t\t" + nome[c]);
                        Console.WriteLine("Idade:\t\t\t" + idade[c]);
                        Console.WriteLine("Data de nascimento:\t" + dataNasc[c] + "\n");
                        Console.WriteLine("Deseja confirmar? (Alunos com nomes iguais serão mostrados após pressionar 'n') [Y/n]");
                        string i = Console.ReadLine();
                        if (i == "" || i.ToUpper() == "Y" || i.ToUpper().StartsWith("Y"))
                        {
                            nome.RemoveAt(c);
                            idade.RemoveAt(c);
                            dataNasc.RemoveAt(c);
                            FileStream fls = new FileStream(@"C:\tp\ficha10\alunos.save", FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fls);
                            for (int j = 0; j <= nome.Count - 1; j++)
                            {
                                if (nome[j] != null)
                                {
                                    sw.WriteLine(nome[j]);
                                    sw.WriteLine(idade[j]);
                                    sw.WriteLine(dataNasc[j]);
                                }
                                else break;
                            }
                            sw.Close();
                            Console.Clear();
                            Console.WriteLine("Aluno removido!");
                            Console.ReadKey();
                        }
                        else
                        {
                            while(nome.IndexOf(nomeRem, c+1) != -1)
                            {
                                Console.Clear();
                                c = nome.IndexOf(nomeRem, c+1);
                                Console.WriteLine("Foi encontrado outro aluno com o mesmo nome! Deseja removê-lo?\n");
                                Console.WriteLine("Nome:\t\t\t" + nome[c]);
                                Console.WriteLine("Idade:\t\t\t" + idade[c]);
                                Console.WriteLine("Data de nascimento:\t" + dataNasc[c] + "\n");
                                Console.WriteLine("Confirmar? (Alunos com nomes iguais serão mostrados após pressionar 'n') [Y/n]");
                                string x = Console.ReadLine();
                                if (i == "" || i.ToUpper() == "Y" || i.ToUpper().StartsWith("Y"))
                                {
                                    FileStream fls = new FileStream(@"C:\tp\ficha10\alunos.save", FileMode.Create, FileAccess.Write);
                                    StreamWriter sw = new StreamWriter(fls);
                                    nome.RemoveAt(c);
                                    idade.RemoveAt(c);
                                    dataNasc.RemoveAt(c);
                                    for (int j = 0; j <= nome.Count - 1; j++)
                                    {
                                        if (nome[j] != null)
                                        {
                                            sw.WriteLine(nome[j]);
                                            sw.WriteLine(idade[j]);
                                            sw.WriteLine(dataNasc[j]);
                                        }
                                        else break;
                                    }
                                    sw.Close();
                                    Console.Clear();
                                    Console.WriteLine("Aluno removido!");
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                }
                catch { }
            }
            catch (IOException ex) { Console.WriteLine(ex); Console.ReadKey(); }
        }
    }
}

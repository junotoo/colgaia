using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 7 \n\nSelecione a versão:\n 1 - ex1\n2 - ex2\n \n 0 - Sair do programa");
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
            byte opt = 0, idd = 0;
            char Letra = ' ';
            var nome = new List<string>();
            var idade = new List<byte>();
            bool x = false, flag = false;
            while (opt != 4)
            {
                Console.WriteLine("     Menu\n1 –Entrada de Dados\n2 –Listar Alunos dada uma idade\n3 –Listar os Alunos que iniciam o Nome por uma dada Letra\n4 –Sair");
                x = byte.TryParse(Console.ReadLine(), out opt);
                Console.Clear();
                if (!x)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (opt)
                {
                    case 1:
                        {
                            ler(ref nome, ref idade);
                            flag = true;
                            break;
                        }
                    case 2 when flag:
                        {
                            Console.Write("Introduza a idade que deseja procurar:");
                            x = byte.TryParse(Console.ReadLine(), out idd);
                            Console.Clear();
                            if (!x)
                            {
                                Console.WriteLine("Valor inválido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            ProcurarIdd(idd, idade, nome);
                            break;
                        }
                    case 3 when flag:
                        {
                            Console.Write("Introduza a 1º letra do nome que deseja procurar:");
                            x = char.TryParse(Console.ReadLine(), out Letra);
                            Console.Clear();
                            if (!x)
                            {
                                Console.WriteLine("Valor inválido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            PrimeiraLetra(Letra, nome);
                            break;
                        }
                    case 4: break;
                    default:
                        {
                            Console.WriteLine("Valor inválido");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
        static void ler(ref List<string> nome, ref List<byte> idade)
        {
            byte N = 0;
            bool x = false;
            byte y;
            while (!x)
            {
                Console.WriteLine("Introduza o número de alunos que irá introduzir você tem {0} vagas", 30 - nome.Count());
                x = byte.TryParse(Console.ReadLine(), out N);
                Console.Clear();
                if (N > 30 || ((nome.Count() + N) > 30))
                {
                    Console.WriteLine("O máximo é 30!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (!x)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Introduza o nome do {0}º aluno", i + 1);
                    nome.Add(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Introduza a turma do {0}", nome[nome.Count() - 1]);
                    nome[i] += " " + Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Introduza a idade do " + nome[nome.Count() - 1]);
                    x = byte.TryParse(Console.ReadLine(), out y);
                    Console.Clear();
                    if (!x)
                    {
                        Console.WriteLine("Valor inválido");
                        Console.ReadKey();
                        Console.Clear();
                        i--;
                        continue;
                    }
                    idade.Add(y);
                }
            }
        }
        static void ProcurarIdd(byte idd, List<byte> idade, List<string> nome)
        {
            Console.WriteLine("Para a idade de " + idd + " encontamos:");
            for (int i = 0; i < idade.Count; i++)
            {
                if (idade[i] == idd)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void PrimeiraLetra(char letra, List<string> nome)
        {
            for (int i = 0; i < nome.Count; i++)
            {
                if (nome[i].StartsWith(letra.ToString().ToUpperInvariant()))
                {
                    Console.WriteLine(nome[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void ex02()
        {
            byte opt = 0, idd = 0;
            char Letra = ' ';
            var nome = new List<string>();
            var idade = new List<byte>();
            bool x = false, flag = false; 
            while (opt != 4)
            {
                Console.WriteLine("     Menu\n1 –Entrada de Dados\n2 –Listar Alunos dada uma idade\n3 –Listar os Alunos que iniciam o Nome por uma dada Letra\n4 –Sair");
                x = byte.TryParse(Console.ReadLine(), out opt);
                Console.Clear();
                if (!x)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (opt)
                {
                    case 1:
                        {
                            ler2(ref nome, ref idade);
                            flag = true;
                            break;
                        }
                    case 2 when flag:
                        {
                            Console.Write("Introduza a idade que deseja procurar:");
                            x = byte.TryParse(Console.ReadLine(), out idd);
                            Console.Clear();
                            if (!x)
                            {
                                Console.WriteLine("Valor inválido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            ProcurarIdd2(idd, idade, nome);
                            break;
                        }
                    case 3 when flag:
                        {
                            Console.Write("Introduza a 1º letra do nome que deseja procurar:");
                            x = char.TryParse(Console.ReadLine(), out Letra);
                            Console.Clear();
                            if (!x)
                            {
                                Console.WriteLine("Valor inválido");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            PrimeiraLetra2(Letra, nome);
                            break;
                        }
                    case 4: break;
                    default:
                        {
                            Console.WriteLine("Valor inválido");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
        static void ler2(ref List<string> nome, ref List<byte> idade)
        {
            byte N = 0;
            bool x = false;
            byte y;
            while (!x)
            {
                Console.WriteLine("Introduza o número de alunos que irá introduzir");
                x = byte.TryParse(Console.ReadLine(), out N);
                Console.Clear();
                if (!x)
                {
                    Console.WriteLine("Valor inválido");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Introduza o nome do {0}º aluno", i + 1);
                    nome.Add(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Introduza a turma do {0}", nome[nome.Count() - 1]);
                    nome[i] += " " + Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Introduza a idade do " + nome[nome.Count() - 1]);
                    x = byte.TryParse(Console.ReadLine(), out y);
                    Console.Clear();
                    if (!x)
                    {
                        Console.WriteLine("Valor inválido");
                        Console.ReadKey();
                        Console.Clear();
                        i--;
                        continue;
                    }
                    idade.Add(y);
                }
            }
        }
        static void ProcurarIdd2(byte idd, List<byte> idade, List<string> nome)
        {
            Console.WriteLine("Para a idade de " + idd + " encontramos:");
            for (int i = 0; i < idade.Count; i++)
            {
                if (idade[i] == idd)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void PrimeiraLetra2(char letra, List<string> nome)
        {
            for (int i = 0; i < nome.Count; i++)
            {
                if (nome[i].StartsWith(letra.ToString().ToUpperInvariant()))
                {
                    Console.WriteLine(nome[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

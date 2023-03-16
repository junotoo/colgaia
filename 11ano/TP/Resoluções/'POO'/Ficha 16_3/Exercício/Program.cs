using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, ano;
            bool flag, flag_confirm;
            string nome;
            byte dia, mes;
            char ans;

            do
            {
                Console.WriteLine("Introduza o número de amigos pretendidos: ");
                flag = int.TryParse(Console.ReadLine(), out N);

                if (!flag)
                {
                    Console.WriteLine("Valor inválido!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (!flag);

            Console.Clear();
            Amigo[] amigos = new Amigo[N];

            for (int i = 0; i < N; i++)
            {
                flag_confirm = false;
                do
                {
                    Console.WriteLine("Introduza o nome do aluno: ");
                    nome = Console.ReadLine().Trim();

                    if (nome == "")
                    {
                        Console.WriteLine("Valor inválido!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (nome == "");

                Console.Clear();

                while (!flag_confirm)
                {
                    do
                    {
                        Console.WriteLine("Introduza o dia de nascimento: ");
                        flag = byte.TryParse(Console.ReadLine(), out dia);

                        if (!flag || dia <= 0 || dia > 31)
                        {
                            Console.WriteLine("Valor inválido!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (!flag || dia <= 0 || dia > 31);

                    Console.Clear();

                    do
                    {
                        Console.WriteLine("{0}/", dia);
                        Console.WriteLine("Introduza o mês de nascimento: ");
                        flag = byte.TryParse(Console.ReadLine(), out mes);

                        if (!flag || mes <= 0 || mes > 12)
                        {
                            Console.WriteLine("Valor inválido!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (!flag || mes <= 0 || mes > 12);

                    Console.Clear();

                    do
                    {
                        Console.WriteLine("{0}/{1}/", dia, mes);
                        Console.WriteLine("Introduza o ano de nascimento: ");
                        flag = int.TryParse(Console.ReadLine(), out ano);

                        if (!flag || ano <= 1900 || ano > DateTime.Now.Year)
                        {
                            Console.WriteLine("Valor inválido!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    } while (!flag || ano <= 1900 || ano >= DateTime.Now.Year);

                    Console.Clear();

                    if (DateTime.TryParse(dia+"/"+mes+"/"+ano, out _))
                    {
                        do
                        {
                            Console.WriteLine("{0}/{1}/{2}", dia, mes, ano);
                            Console.WriteLine("Confirma esta data? [S/N]");
                            Console.WriteLine("NOTA: Apenas o 1º carater da resposta será contabilizado");
                            ans = Console.ReadLine().ToUpper()[0];

                            if (ans != 'S' && ans != 'N')
                            {
                                Console.WriteLine("Valor inválido!");
                            }

                        } while (ans != 'S' && ans != 'N');

                        switch (ans)
                        {
                            case 'S':
                                amigos[i] = new Amigo(nome, new DataCronologica(dia, mes, ano));
                                flag_confirm = true;
                                break;
                            case 'N':
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data inválida!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }  
                Console.Clear();
            }

            
            Console.WriteLine("Lista de Amigos:");
            for (int i = 0; i < amigos.Length; i++)
            {
                Console.WriteLine(amigos[i].PNome + " - " + amigos[i].PDataNasc.ToString());
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

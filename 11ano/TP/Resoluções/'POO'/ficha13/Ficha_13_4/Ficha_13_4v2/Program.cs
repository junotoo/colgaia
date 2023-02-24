using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ficha_13_4;

namespace Ficha_13_4v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] transacoes = new ContaCorrente[0];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ficha 13_4v2 \n\nSelecione uma opção:\n 1 - Adicionar Transação\n 2 - Listar transações por tipo (validas)\n 3 - Número de transações anuladas\n 4 - Mostrar Saldo\n \n 0 - Sair do programa");
                bool v = Int16.TryParse(Console.ReadLine(), out Int16 i);
                Console.Clear();
                if (v)
                {
                    switch (i)
                    {
                        case 1:
                            AdicionarTrans(ref transacoes);
                            break;
                        case 2:
                            Listar(transacoes);
                            break;
                        case 3:
                            Console.WriteLine("Número de Transações anuladas: " + ContaCorrente.LeNumTransInvalida()+ "\n\n\n Pressione qualquer tecla para continuar...");   
                            Console.ReadKey();                   
                            Console.Clear();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Saldo: " + ContaCorrente.SaldoConta() + "\n\n\n Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
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
        static void AdicionarTrans(ref ContaCorrente[] transacoes)
        {
            char trans;
            Array.Resize(ref transacoes, transacoes.Length+1);
            while (true)
            {
                Console.WriteLine("Depósito ou Levantamento\n\n(Insira 'D' para depósito e 'L' para levantamento\n");
                trans = Console.ReadLine().ToCharArray()[0];
                if (trans != 'D' && trans != 'L') {
                    Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                } else break;
            }
            bool v = false;
            while (!v)
            {
                Console.Clear();
                Console.WriteLine("Introduza o valor.\n");
                v = double.TryParse(Console.ReadLine(), out double valor);
                Console.Clear();
                if (!v)
                {
                    transacoes[transacoes.Length] = new ContaCorrente(valor,trans);
                    Console.WriteLine("Transação registada.\n \n \n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Introduza um valor válido \n \n \n Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void Listar(ContaCorrente[] transacoes)
        {
            bool prim = true;
            int c = 0;
            foreach (ContaCorrente transacao in transacoes)
            {
                c++;
                if (transacao.LeValida() && transacao.LeTrans()=='D')
                {
                    if (prim)
                    {
                        Console.WriteLine("\n\t\tDepósitos\n\tNumTrans\tValor ");
                    }
                    Console.WriteLine("\t{0}\t\t{1}", c, transacao.LeValor());
                }
            }
            c = 0;
            foreach (ContaCorrente transacao in transacoes)
            {
                c++;
                if (transacao.LeValida() && transacao.LeTrans() == 'L')
                {
                    if (prim)
                    {
                        Console.WriteLine("\n\t\tLevantamentos\n\tNumTrans\tValor ");
                    }
                    Console.WriteLine("\t{0}\t\t{1}", c, transacao.LeValor());
                }
            }
            Console.ReadKey();
        }
    }
}



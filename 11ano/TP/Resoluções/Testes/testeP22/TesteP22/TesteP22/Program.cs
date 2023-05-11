using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteP22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Cliente.cliente[] clientes = new Cliente.cliente[1];
            ClienteFreq.clienteFreq[] clientesFreq = new ClienteFreq.clienteFreq[20];
            int c = 0;
            while (true) { 
            do {
                opc = 0;
                Console.WriteLine("1 - Adiciona reserva temporário\n2 - Adiciona reserva cliente frequente");
                bool y = int.TryParse(Console.ReadLine(), out opc);
                if (y || (opc !=1 &&opc!=2))
                {
                    break;
                }else { Console.WriteLine("Valor introduzido inválido, introduza novamente...");Console.ReadKey(); Console.Clear();}
                } while (true);
                Console.Clear();
                if (opc == 1)
                {
                    Console.WriteLine("Indique o Nome do cliente: ");
                    string nomecli = Console.ReadLine();
                    Console.Clear();
                    int andar;
                    do
                    {
                        Console.WriteLine("Indique o numero do andar: ");
                        bool y = int.TryParse(Console.ReadLine(), out andar);
                        if (y || (opc != 1 && opc != 2))
                        {
                            break;
                        }
                        else { Console.WriteLine("Valor introduzido inválido, introduza novamente..."); Console.ReadKey(); Console.Clear();
                        }
                        Console.Clear();

                    } while (true); Console.Clear();
                    Console.WriteLine("Indique o tipo de quarto: ");
                    string tipoquarto = Console.ReadLine();
                    Console.Clear();
                    clientes[clientes.Length - 1] = new Cliente.cliente(andar, nomecli, tipoquarto);
                    Console.WriteLine(clientes[clientes.Length-1].ToString());
                    Array.Resize(ref clientes, clientes.Length);
                    Basica.basica.NumCli++;
                }
                else
                {
                    Console.WriteLine("Indique o Nome do cliente: ");
                    string nomecli = Console.ReadLine();
                    Console.Clear();
                    int andar;
                    do
                    {
                        Console.WriteLine("Indique o numero do andar: ");
                        bool y = int.TryParse(Console.ReadLine(), out andar);
                        if (y || (opc != 1 && opc != 2))
                        {
                            break;
                        }
                        else { Console.WriteLine("Valor introduzido inválido, introduza novamente..."); Console.ReadKey(); Console.Clear();
                        }

                    } while (true);
                    Console.Clear();
                    bool servQuarto;
                    do
                    {
                        Console.WriteLine("É pretendido serviço de quarto? (se sim, escreva 'true', se não, escreva 'false'");
                        bool y = bool.TryParse(Console.ReadLine(), out servQuarto);
                        if (y || (opc != 1 && opc != 2))
                        {
                            break;
                        }
                        else { Console.WriteLine("Valor introduzido inválido, introduza novamente..."); Console.ReadKey(); Console.Clear();
                        }

                    } while (true); Console.Clear();
                    Console.WriteLine("Indique o tipo de quarto: ");
                    string tipoquarto = Console.ReadLine();
                    Console.Clear();
                    clientesFreq[c] = new ClienteFreq.clienteFreq(andar, nomecli, tipoquarto, servQuarto);
                    Console.WriteLine(clientesFreq[c].ToString());
                    c++;
                }
                Console.WriteLine("\nExistem {0} clientes temporários.", Basica.basica.NumCli.ToString());
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

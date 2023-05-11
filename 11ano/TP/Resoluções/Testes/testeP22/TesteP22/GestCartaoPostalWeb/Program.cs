using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCartaoPostalWeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            CartaoPostalWeb.cartaoPostalWeb[] cartoes = new CartaoPostalWeb.cartaoPostalWeb[50];
            int c = 0;
            while (c<=49)
            {
                do
                {
                    opc = 0;
                    Console.WriteLine("1 - Cartão de Natal\n2 - Cartão de Aniversário\n3 - Cartão de Dia dos Namorados");
                    bool y = int.TryParse(Console.ReadLine(), out opc);
                    if (y || (opc != 1 && opc != 2 && opc != 3))
                    {
                        break;
                    }
                    else { Console.WriteLine("Valor introduzido inválido, introduza novamente..."); Console.ReadKey(); Console.Clear(); }
                } while (true);
                Console.Clear();
                if (opc == 1)
                {
                    Console.Write("Introduza o nome do destinatário: ");
                    string dest = Console.ReadLine();
                    cartoes[c] = new Natal.natal(dest);
                    Console.Clear();
                }else if (opc == 2)
                {
                    Console.Write("Introduza o nome do destinatário: ");
                    string dest = Console.ReadLine();
                    cartoes[c] = new Aniversario.aniversario(dest);
                    Console.Clear();
                }else
                {
                    Console.Write("Introduza o nome do destinatário: ");
                    string dest = Console.ReadLine();
                    cartoes[c] = new DiaDosNamorados.diaDosNamorados(dest);
                    Console.Clear();
                }
                c++;
            }
            foreach (CartaoPostalWeb.cartaoPostalWeb cartao in cartoes)
            {
                Console.WriteLine(cartao.mensagemPostal() + "\n");
            }
            Console.ReadKey();
        }
    }
}

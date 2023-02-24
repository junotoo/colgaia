using Ficha_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i = 0;
            EstudanteINF[] Aluno = new EstudanteINF[1];
            double ClassF;
            do
            {
                Console.Clear();
                Aluno[i] = new EstudanteINF();
                Console.Write("Introduza o nome do " + (i + 1) + "º aluno: ");
                Aluno[i].AtribuirNome(Console.ReadLine());
            teste1:
                Console.Clear();
                try
                {
                    Console.Write("Introduza a nota do 1º teste do " + (i + 1) + "º aluno: ");
                    Aluno[i].AtribuirTeste1(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                    if (Aluno[i].LerTeste1() > 20 || Aluno[i].LerTeste1() < 0)
                    {
                        Console.Write("O número introduzido tem de ser entre 0 e 20\n Prima qualquer tecla para continuar...");
                        Console.ReadKey();
                        goto teste1;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.Write("O número introduzido tem de ser real!!\n Prima qualquer tecla para continuar...");
                    Console.ReadKey();
                    goto teste1;
                }
            teste2:
                Console.Clear();
                try
                {
                    Console.Write("Introduza a nota do 2º teste do " + (i + 1) + "º aluno: ");
                    Aluno[i].AtribuirTeste2(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                    if (Aluno[i].LerTeste2() > 20 || Aluno[i].LerTeste2() < 0)
                    {
                        Console.Write("O número introduzido tem de ser entre 0 e 20\n Prima qualquer tecla para continuar...");
                        Console.ReadKey();
                        goto teste2;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.Write("O número introduzido tem de ser real!!\n Prima qualquer tecla para continuar...");
                    Console.ReadKey();
                    goto teste2;
                }
                ClassF = Aluno[i].ClassFinal();
                Console.WriteLine("Aluno: " + Aluno[i].LerNome());
                Console.WriteLine("Nota do 1º teste: " + Aluno[i].LerTeste1());
                Console.WriteLine("Nota do 2º teste: " + Aluno[i].LerTeste1());
                Console.WriteLine("Classificação final = " + ClassF);
                Console.ReadKey();
                i++;
                Array.Resize(ref Aluno, Aluno.Length + 1);
            } while (true);
        }
    }
}

using Ficha_13;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = (int)LerValor("Introduza o número de alunos a registar: ");
            EstudanteINF[] A = new EstudanteINF[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = new EstudanteINF();
                Console.Write("Introduza o nome do {0}º aluno: ", i + 1);
                A[i].AtribuirNome(Console.ReadLine());
                A[i].AtribuirTeste1(LerValor("Introduza a 1ª nota do "+ A[i].LerNome()+ ": "));
                A[i].AtribuirTeste2(LerValor("Introduza a 2ª nota do " + A[i].LerNome() + ": "));
                Console.Clear();
            }
            Console.WriteLine("|\t Aluno\t|\tTeste 1\t|\tTeste 2\t|\t Classificação\t|");
            for (int i = 0; i < A.Length; i++) Console.WriteLine("|\t" + A[i].LerNome() + "\t|\t" + A[i].LerTeste1()+"\t|\t"+ A[i].LerTeste2()+"\t|");
            Console.ReadKey();
        }
        static double LerValor(string msg)
        {
            double N = 0;
            bool y = false;
            while (y == false)
            {
                Console.Write(msg);
                y = double.TryParse(Console.ReadLine(), out N);
                if (!y)
                {
                    Console.WriteLine("Introduza um valor válido. \n \n \n");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            return N;
        }
    }
}

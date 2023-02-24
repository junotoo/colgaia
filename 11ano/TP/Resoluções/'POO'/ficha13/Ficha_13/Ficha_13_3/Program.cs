using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ficha_13;

namespace Ficha_13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EstudanteINF[] estudante = new EstudanteINF[0];
            int N = 0;
            bool x = false;
            while (!x || N <= 0)
            {
                Console.WriteLine("Introduza o número de alunos: ");
                x = int.TryParse(Console.ReadLine(), out N);
                Console.Clear();
                if (!x)
                {
                    Console.WriteLine("Tem de ser um número!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (N <= 0)
                {
                    Console.WriteLine("Superior a zero!!!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Array.Resize(ref estudante, N);
            for (int i = 0; i < estudante.Length; i++)
            {
                estudante[i] = new EstudanteINF();
                Console.WriteLine("Introduza o nome do aluno" + (i + 1) + " : ");
                estudante[i].AtribuirNome(Console.ReadLine());
                Console.Clear();
                do
                {
                    Console.WriteLine("Introduza a nota do 1º teste do {0}º aluno", i + 1);
                    estudante[i].AtribuirTeste1(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                } while (estudante[i].LerTeste1() <= 0 || estudante[i].LerTeste1() > 20);
                do
                {
                    Console.WriteLine("Introduza a nota do 2º teste do {0}º aluno", i + 1);
                    estudante[i].AtribuirTeste1(Convert.ToDouble(Console.ReadLine()));
                    Console.Clear();
                } while (estudante[i].LerTeste2() <= 0 || estudante[i].LerTeste2() > 20);
                estudante[i].SomaNotas();
                estudante[i].IncPositivas();
            }
            for (int i = 0; i < estudante.Length; i++)
            {
                Console.WriteLine(estudante[i].LerNome());
                Console.WriteLine(estudante[i].LerTeste1());
                Console.WriteLine(estudante[i].LerTeste2());
                Console.WriteLine(estudante[i].ClassFinal());
                if (estudante[i].ClassFinal() >= 10)
                {
                    Console.WriteLine("Aluno aprovado");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("A média dos alunos é: " + EstudanteINF.CalculaMediaClassFinal());
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Alunos com pelo menos 1 positiva: {0}", EstudanteINF.LerPositivas());
            Console.ReadKey();
            Console.Clear();
        }
    }
}

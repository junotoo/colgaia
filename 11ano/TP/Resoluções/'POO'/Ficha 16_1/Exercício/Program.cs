using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, escola, morada;
            double nota1, nota2;
            bool flag;
            Aluno[] aluno = new Aluno[5];

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Introduza o nome do {0}º aluno: ", i + 1);
                    nome = Console.ReadLine();

                    if (nome == "")
                    {
                        Console.WriteLine("Nome inválido");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }while (nome == "");

                Console.Clear();

                do
                {
                    Console.WriteLine("Introduza a nota do 1º teste do {0}: ", nome);
                    flag = double.TryParse(Console.ReadLine(), out nota1);

                    if (!flag || nota1 >= 20 || nota1 <= 0)
                    {
                        Console.WriteLine("Valor inválido");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (!flag || nota1 >= 20 || nota1 <= 0);

                Console.Clear();

                do
                {
                    Console.WriteLine("Introduza a nota do 2º teste do {0}: ", nome);
                    flag = double.TryParse(Console.ReadLine(), out nota2);

                    if (!flag || nota2 >= 20 || nota2 <= 0)
                    {
                        Console.WriteLine("Valor inválido");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (!flag || nota2 >= 20 || nota2 <= 0);

                Console.Clear();

                do
                {
                    Console.WriteLine("Introduza a escola que o {0} frequenta: ", nome);
                    escola = Console.ReadLine();

                    if (escola == "")
                    {
                        Console.WriteLine("Escola inválida");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (escola == "");

                Console.Clear();

                do
                {
                    Console.WriteLine("Introduza a morada da escola \"{0}\" frequentada pelo {1}: ", escola, nome);
                    morada = Console.ReadLine();

                    if (morada == "")
                    {
                        Console.WriteLine("Morada inválida");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (morada == "");

                Console.Clear();

                aluno[i] = new Aluno(nome, nota1, nota2, escola, morada);
            }

            Console.WriteLine("Alunos:");

            for(int i=0; i < aluno.Length; i++)
            {
                Console.WriteLine(aluno[i].ToString());
                Console.WriteLine();
                aluno[i] = null;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

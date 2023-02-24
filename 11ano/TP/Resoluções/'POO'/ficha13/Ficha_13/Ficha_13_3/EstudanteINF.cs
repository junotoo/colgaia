using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_13
{
    internal class EstudanteINF
    {
        private double Teste1, Teste2;
        private string Nome;
        private static int Nalunos = 0;
        private static double SomatorioCL = 0;
        private static int Npositivas = 0;
        public EstudanteINF() { }

        public EstudanteINF(string NomeEst, double Teste1Est, double Teste2Est)
        {
            this.Nome = NomeEst;
            this.Teste1 = Teste1Est;
            this.Teste2 = Teste2Est;
        }
        public double ClassFinal()
        {return (Teste1 + Teste2) / 2;}
        public string LerNome()
        {return Nome;}
        public double LerTeste1()
        {return Teste1;}
        public double LerTeste2()
        {return Teste2;}
        public void AtribuirNome(string nome)
        {Nome = nome;}
        public void AtribuirTeste1(double teste1)
        {Teste1 = teste1;}
        public void AtribuirTeste2(double teste2)
        {Teste2 = teste2;}
        public string SituaAluno()
        { if ((Teste1 + Teste2) / 2 > 9.5) return "Aprovado"; else if ((Teste1 + Teste2) / 2 >= 8) return "Exame Oral"; else return "Reprovado"; }
        public void SomaNotas()
        {
            SomatorioCL += ClassFinal();
            Nalunos++;
        }
        public void IncPositivas()
        {
            if (Teste1 >= 10 || Teste2 >= 10)
            {
                Npositivas++;
            }
        }
        public static int LerPositivas()
        {
            {
                return Npositivas;
            }
        }
        public static double CalculaMediaClassFinal()
        {
            return Math.Round(SomatorioCL / Nalunos, 2, MidpointRounding.AwayFromZero);
        }
    }
}

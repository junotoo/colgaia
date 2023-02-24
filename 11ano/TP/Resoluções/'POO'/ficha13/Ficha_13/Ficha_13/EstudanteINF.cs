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

        public EstudanteINF() { }

        public EstudanteINF(string NomeEst, double Teste1Est, double Teste2Est)
        {
            this.Nome = NomeEst;
            this.Teste1 = Teste1Est;
            this.Teste2 = Teste2Est;
        }
        public double ClassFinal()
        {
            return (Teste1 + Teste2) / 2;
        }
        public string LerNome()
        {
            return Nome;
        }
        public double LerTeste1()
        {
            return Teste1;
        }
        public double LerTeste2()
        {
            return Teste2;
        }
        public void AtribuirNome(string nome)
        {
            Nome = nome;
        }
        public void AtribuirTeste1(double teste1)
        {
            Teste1 = teste1;
        }
        public void AtribuirTeste2(double teste2)
        {
            Teste2 = teste2;
        }

    }
}

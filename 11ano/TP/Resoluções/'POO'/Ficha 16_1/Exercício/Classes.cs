using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    internal class Escola
    {
        private string Nome;
        private string Morada;

        public Escola(string Nome, string Morada) 
        { 
            this.Nome = Nome;
            this.Morada = Morada; 
        }

        ~Escola() 
        { 
        }

        public string PNomeEsc { get { return Nome; } set { Nome = value; } }
        public string PMorada { get { return Morada; } set { Morada = value; } }
    }

    internal class Aluno : Escola
    {
        private string Nome;
        private double Nota;

        public Aluno(string NomeAlu, double Nota1, double Nota2, string NomeEsc, string Morada) : base(NomeEsc, Morada)
        {
            this.Nome = NomeAlu;
            this.Nota = (Nota1 + Nota2) / 2;
        }

        ~Aluno()
        {
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nNota: " + Nota + "\nEscola: " + PNomeEsc + "\nMorada da Escola: " + PMorada;
        }
    }
}

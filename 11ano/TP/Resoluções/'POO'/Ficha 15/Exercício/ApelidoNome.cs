using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    public class ApelidoNome
    {
        private string Nome;
        private string Apelido;

        public string PNome { get => Nome; set => Nome = value; }
        public string PApelido { get => Apelido; set => Apelido = value; }

        public ApelidoNome(string nome, string apelido)
        {
            Nome = nome;
            Apelido = apelido;
        }

        public ApelidoNome()
        {
        }
        public override string ToString()
        {
            return Apelido + ", " + Nome;
        }
    }
}

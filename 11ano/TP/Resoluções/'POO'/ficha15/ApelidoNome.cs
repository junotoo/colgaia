using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ficha15
{
    internal class ApelidoNome
    {
        private string Nome;
        private string Apelido; 
        public ApelidoNome(string nome, string apelido)
        {
            this.Nome = nome;
            this.Apelido = apelido;
        }
        public override string ToString()
        {
            return (string)(Nome + "," + Apelido);
        }
    }
}
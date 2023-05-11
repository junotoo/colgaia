using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteP22
{
    internal class Cliente
    {
        public class cliente : Basica.basica
        {
            protected int andar; 
            public cliente(int Andar, string nomeCli, string tipoQuarto) : base(nomeCli, tipoQuarto)
            {
                andar = Andar;
            }
            public override string ToString()
            {
                return TipoQuarto + " para " + NomeCli + " andar:" + andar.ToString();
            }
        }
    }
}

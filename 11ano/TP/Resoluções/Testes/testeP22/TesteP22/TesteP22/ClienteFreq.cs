using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteP22
{
    internal class ClienteFreq
    {
        public class clienteFreq : Cliente.cliente
        {
            private bool servQuarto;
            public clienteFreq(int Andar, string nomeCli, string tipoQuarto, bool ServQuarto) : base(Andar, nomeCli, tipoQuarto)
            {
                servQuarto = ServQuarto;
            }
            public override string ToString()
            {
                if (servQuarto)
                {
                    return TipoQuarto + " para " + NomeCli + " andar:" + andar.ToString() + " com serviço de quarto";
                }
                else
                {
                    return TipoQuarto + " para " + NomeCli + " andar:" + andar.ToString() + " sem serviço de quarto";
                }
            }
        }
    }
}

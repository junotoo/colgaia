using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCartaoPostalWeb
{
    internal class CartaoPostalWeb
    {
        public abstract class cartaoPostalWeb
        {
            protected string destinatario;
            public cartaoPostalWeb(string Destinatario)
            {
                destinatario = Destinatario;
            }
            public abstract string mensagemPostal();
        }
    }
}

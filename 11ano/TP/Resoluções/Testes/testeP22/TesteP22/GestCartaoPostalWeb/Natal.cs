using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCartaoPostalWeb
{
    internal class Natal
    {
        public class natal : CartaoPostalWeb.cartaoPostalWeb
        {
            public natal(string Destinatario) : base(Destinatario)
            {

            }
            public override string mensagemPostal()
            {
                return "Feliz Natal, " + destinatario + "!";
            }
        }
    }
}

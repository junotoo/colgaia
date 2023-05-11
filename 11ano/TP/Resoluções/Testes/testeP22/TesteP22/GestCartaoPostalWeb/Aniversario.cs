using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCartaoPostalWeb
{
    internal class Aniversario
    {
        public class aniversario : CartaoPostalWeb.cartaoPostalWeb
        {
            public aniversario(string Destinatario) : base(Destinatario)
            {

            }
            public override string mensagemPostal()
            {
                return "Parabéns pelo teu aniversário, " + destinatario + "!";
            }
        }
    }
}

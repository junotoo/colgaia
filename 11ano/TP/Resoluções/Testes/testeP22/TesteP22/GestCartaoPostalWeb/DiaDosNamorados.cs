using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestCartaoPostalWeb
{
    internal class DiaDosNamorados
    {
        public class diaDosNamorados : CartaoPostalWeb.cartaoPostalWeb
        {
            public diaDosNamorados(string Destinatario) : base(Destinatario)
            {

            }
            public override string mensagemPostal()
            {
                return "Feliz Dia dos Namorados, " + destinatario + "!";
            }
        }
    }
}

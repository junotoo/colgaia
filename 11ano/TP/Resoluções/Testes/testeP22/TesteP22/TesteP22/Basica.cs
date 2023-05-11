using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteP22
{
    internal class Basica
    {
        public class basica
        {
            protected static int numCli=0;
            protected string NomeCli { get; set; }
            protected string TipoQuarto { get; set; }
            public basica(string nomeCli, string tipoQuarto)
            {
                NomeCli = nomeCli;
                TipoQuarto = tipoQuarto;
            }
            public string nomeCli { 
            get { return NomeCli; }
            }
            public string tipoQuarto
            {
                get { return TipoQuarto; }
            }
            public override string ToString()
            {
                return TipoQuarto + " para " + NomeCli;
            }
            public static int NumCli { get { return numCli; } 
            set { numCli = value; }
            }
        }
    }
}

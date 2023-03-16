using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvaliacaoORG.AvaliacaoOrg[] Org = new AvaliacaoORG.AvaliacaoOrg[2];
            Org[0] = new AvaliacaoORG.Comercial(50000, 200000, "Empresa 1");
            Org[1] = new AvaliacaoORG.ONG(30, 20000, 10000, "Empresa 2");

            double V, Totv = 0;

            for (int i = 0; i < Org.Length; i++)
            {
                V = Org[i].Valor();
                Console.WriteLine(Org[i].ToString() + V + " euros");
                Totv += V;
            }

            Console.WriteLine("Valor total das empresas {0,8:F} euros", Totv);
            Console.ReadKey();

        }
    }
}

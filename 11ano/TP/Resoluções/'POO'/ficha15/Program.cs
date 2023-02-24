using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ficha15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApelidoNome apnm = new ApelidoNome("Jorge", "Creme");
            Console.WriteLine(apnm.ToString());
            Console.ReadKey();
        }
    }
}

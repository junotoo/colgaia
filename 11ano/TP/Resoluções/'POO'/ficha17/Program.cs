using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza o nome da estrada: ");
            string estrada = Console.ReadLine();
            Console.Clear();
            Console.Write("Introduza a velocidade máxima da estrada: ");
            int vMax = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Introduza a velocidade minima da estrada: ");
            int vMin = int.Parse(Console.ReadLine());
            Console.Clear();
            estrada.AutoEstrada autoEstrada = new estrada.AutoEstrada(estrada, vMax, vMin);
            Console.WriteLine("Limites para \"{0}\"", autoEstrada.LerDesignacao());
            Console.WriteLine("Max em autoestrada: {0} Km/h", autoEstrada.LerVelocidadeMax());
            Console.WriteLine("Min em autoestrada: {0} Km/h", autoEstrada.LerVelocidadeMin());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício
{
    public class Centro
    { 
        private int x;
        private int y;
        public Centro()
        {
            x = 0;
            y = 0; 
        } 
        public Centro(int x, int y) 
        { 
            this.x = x;
            this.y = y;
        } 
        public string CoodCentro() 
        {
            return "Centro = (" + x + "," + y + ")";
        } 
    }
    public class Circulo : Centro
    {
        private double Raio; public Circulo() 
        { 
        }
        public Circulo(int x, int y, double R) : base(x, y) 
        { 
            Raio = R; 
        }

        public double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Raio, 2), 2);
        }
    }
}
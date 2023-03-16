using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha17
{
    internal class estrada
    {
        public abstract class Estradas
        {
            protected string designacao;
            protected int velMax;
            protected int velMin;

            public Estradas(string designacao, int velMax, int velMin)
            {
                this.designacao = designacao;
                this.velMax = velMax;
                this.velMin = velMin;
            }

            public abstract string LerDesignacao();
            public abstract int LerVelocidadeMax();
            public abstract int LerVelocidadeMin();
        }

        public class AutoEstrada : Estradas
        {
            public AutoEstrada(string designacao, int velMax, int velMin) : base(designacao, velMax, velMin) { }

            public override string LerDesignacao()
            {
                return designacao;
            }

            public override int LerVelocidadeMax()
            {
                return velMax;
            }

            public override int LerVelocidadeMin()
            {
                return velMin;
            }
        }

    }
}


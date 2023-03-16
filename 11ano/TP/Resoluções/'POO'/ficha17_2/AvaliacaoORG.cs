using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha17_2
{
    internal class AvaliacaoORG
    {
        public abstract class AvaliacaoOrg
        {
            protected string nome;

            public AvaliacaoOrg(string nome)
            {
                this.nome = nome;
            }

            public abstract double Valor();

            public override string ToString()
            {
                return "Avaliação de \"" + nome + "\": ";
            }
        }

        public class ONG : AvaliacaoOrg
        {
            private int numPatrocinadores;
            private double valorPatrocinio;
            private double custosCorrentes;

            public ONG(int numPatrocinadores, double valorPatrocinio, double custosCorrentes, string nome) : base(nome)
            {
                this.numPatrocinadores = numPatrocinadores;
                this.valorPatrocinio = valorPatrocinio;
                this.custosCorrentes = custosCorrentes;
            }

            public override double Valor()
            {
                return numPatrocinadores * valorPatrocinio - custosCorrentes;
            }
        }

        public class Comercial : AvaliacaoOrg
        {
            private double proveitos;
            private double custos;

            public Comercial(double proveitos, double custos, string nome) : base(nome)
            {
                this.proveitos = proveitos;
                this.custos = custos;
            }

            public override double Valor()
            {
                return proveitos - custos;
            }
        }

    }
}

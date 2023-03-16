using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Pessoa
    {
        private string Nome;

        public string PNome { get => Nome; set => Nome = value; }

        public Pessoa(string nome)
        {
            PNome = nome;
        }
    }

    internal class Amigo : Pessoa
    {
        private DataCronologica DataNasc;
        
        public DataCronologica PDataNasc { get => DataNasc; set => DataNasc = value; }
        
        public Amigo(string nome, DataCronologica dataNasc) : base(nome)
        {
            PDataNasc = dataNasc;
        }
    }

    internal class DataCronologica
    {
        byte Dia, Mes;
        int Ano;

        public byte PDia { get => Dia; set => Dia = value; }
        public byte PMes { get => Mes; set => Mes = value; }
        public int PAno { get => Ano; set => Ano = value; }

        public DataCronologica(byte dia, byte mes, int ano)
        {
            PDia = dia;
            PMes = mes;
            PAno = ano;
        }

        public override string ToString()
        {
            return PDia + "/" + PMes + "/" + PAno;
        }
    }
}

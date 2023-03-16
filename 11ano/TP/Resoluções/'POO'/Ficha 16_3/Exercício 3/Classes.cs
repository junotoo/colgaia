using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
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
        private byte Dia, Mes;
        private int Ano;

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

        public static bool AnoBissexto(int ano)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int DiaDoAno(DataCronologica data)
        {
            int[] DiasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int TD = 0;
            if (AnoBissexto(data.PAno))
            {
                DiasMeses[1] += 1;
            }

            for (int i = 0; i < data.PMes - 1; i++)
            {
                TD += DiasMeses[i];
            }

            TD += data.PDia;
            return TD;
        }

        public int Idade(int ano_atual)
        {
            return ano_atual - PAno;
        }

        public int Idade(DateTime data_atual)
        {
            int idade, num1, num2;
            if (data_atual.Year == PAno)
            {
                num1 = DiaDoAno(new DataCronologica(PDia, PMes, PAno));
                num2 = DiaDoAno(new DataCronologica((byte)data_atual.Day, (byte)data_atual.Month, data_atual.Year));
                
                return Math.Abs(num1 - num2);
            }
            else
            {
                if (AnoBissexto(PAno))
                {
                    idade = 366 - DiaDoAno(new DataCronologica(PDia, PMes, PAno));

                }
                else
                {
                    idade = 365 - DiaDoAno(new DataCronologica(PDia, PMes, PAno));
                }

                for (int i = PAno + 1; i < data_atual.Year; i++)
                {
                    if (AnoBissexto(i))
                    {
                        idade += 366;
                    }
                    else
                    {
                        idade += 365;
                    }
                }

                num2 = DiaDoAno(new DataCronologica((byte)data_atual.Day, (byte)data_atual.Month, data_atual.Year));

                idade += num2;
            }

            return idade;
        }
    }
}

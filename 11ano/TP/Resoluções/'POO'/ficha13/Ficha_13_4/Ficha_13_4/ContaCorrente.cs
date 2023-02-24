using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_13_4
{
    internal class ContaCorrente
    {
        private char Transacao;
        private double Valor;
        private static double Saldo;
        private static int NumTrans;

        public ContaCorrente(double valor, char transacao)
        {
            Transacao = transacao;
            Valor = valor;
            NumTransESaldo();
        }
        private void NumTransESaldo()
        {
            NumTrans++;
            if (Transacao == 'L') Saldo -= Valor;
            else Saldo += Valor;
        }
        public static int LeNumTransEfetuada()
        { return NumTrans; }
        public static double SaldoConta()
        { return Saldo; }
    }
}

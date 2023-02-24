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
        private bool Valida;
        private static double Saldo;
        private static int NumTrans;
        private static int NumTransInv;

        public ContaCorrente(double valor, char transacao)
        {
            Validar(transacao,valor);
            if (Valida)
            {
                Transacao = transacao;
                Valor = valor;
                NumTransESaldo();
            }
        }
        private void NumTransESaldo()
        {
            NumTrans++;
            if (Transacao == 'L') Saldo -= Valor;
            else Saldo += Valor;
        }
        public static int LeNumTransVal()
        { return NumTrans; }
        public static int LeNumTransInvalida() 
        { return NumTransInv; }
        public static double SaldoConta()
        { return Saldo; }
        public bool LeValida() { return Valida; }
        public char LeTrans() { return Transacao; }
        public double LeValor() { return Valor; }
        private void Validar(char transacao, double valor)
        { if (transacao == 'L' && Saldo < valor) { Valida = false; NumTransInv++; } else Valida = true; }
    }
}

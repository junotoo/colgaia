using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_13_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente C1 = new ContaCorrente(100,'D');
            Console.WriteLine("Numero de Transações = {0} Saldo Conta Corrente = { 1}", ContaCorrente.LeNumTransEfetuada(),ContaCorrente.SaldoConta());
            ContaCorrente C2 = new ContaCorrente(50, 'L');
            Console.WriteLine("Numero de Transações = { 0} Saldo Conta Corrente = { 1}", ContaCorrente.LeNumTransEfetuada(),ContaCorrente.SaldoConta());
            ContaCorrente C3 = new ContaCorrente(1000, 'D');
            Console.WriteLine("Numero de Transações = { 0} Saldo Conta Corrente = { 1}", ContaCorrente.LeNumTransEfetuada(),ContaCorrente.SaldoConta());
            ContaCorrente C4 = new ContaCorrente(500, 'L');
            Console.WriteLine("Numero de Transações = { 0} Saldo Conta Corrente = { 1}", ContaCorrente.LeNumTransEfetuada(),ContaCorrente.SaldoConta());
        }
    }
}

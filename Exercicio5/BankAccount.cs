using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    internal class BankAccount
    {
        public long Codigo { get; set; }
        public string NomeProprietario { get; set; }
        public double Saldo { get; set; }

        public void Deposito(double valorDepositado)
        {
            Saldo += valorDepositado;
            Console.WriteLine($"O valor depositado foi: R${valorDepositado} \nSaldo total da conta: R${Saldo}.");
        }
        public void Saques(double valorSacado)
        {
            Saldo -= valorSacado;
            Console.WriteLine($"O valor sacado foi: R${valorSacado} \nSaldo total da conta: R${Saldo}.");
        }
    }
}

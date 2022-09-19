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
            Console.WriteLine($"DEPOSITO REALIZADO!\nO valor depositado foi: R${valorDepositado}.\nSaldo total da conta: R${Saldo}.");
        }
        public void Saques(double valorSacado)
        {
            if(valorSacado > Saldo)
            {
                Saldo -= valorSacado;
                Console.WriteLine($"SAQUE REALIZADO!\nO valor sacado foi: R${valorSacado}.\nSaldo total da conta: R${Saldo}.");
            }
            else 
            { Console.Write("Operação não permitida: Valor de saque maior que saldo!"); }
        }

        public BankAccount(long codigo, string nomeProprietario, double saldo)
        {
            this.Codigo = codigo;
            this.NomeProprietario = nomeProprietario;
            if(saldo > 0)
            {
                this.Saldo = saldo;
            }
        }
    }
}

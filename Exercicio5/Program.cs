using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client("Yohans","Programador","01/10/2002","yohans@gmail.com");

            BankAccount contaBancaria = new BankAccount(11223344, "Yohans", 123);
            Client cliente2 = new Client("Yohans","Programador","01/10/2002","yohans@gmail.com", contaBancaria);

            
            Client cliente3 = new Client("Vitor Marden","Programador","09/09/2002","marden@gmail.com", new BankAccount(111222333444, "Vitor MARDEN", 10000000));

            cliente2.Info();

            cliente3.Info();

            
        }
    }
}

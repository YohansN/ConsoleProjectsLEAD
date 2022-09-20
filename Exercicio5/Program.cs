using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client("Yohans","Programador","01/10/2002","yohans@gmail.com");

            cliente.Info();

            cliente.Age();
            
        }
    }
}

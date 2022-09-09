using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string username = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua ocupação:");
            string occupation = Console.ReadLine();
            Console.WriteLine("Digite sua remuneração bruta:");
            double bruteWage = double.Parse(Console.ReadLine());

            
            double wage = bruteWage - (bruteWage * (7.5 / 100));

            Console.WriteLine($"{username} é um / uma {occupation} de {age} anos e sua remuneração líquida é de R${wage}");
        }
    }
}

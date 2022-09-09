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

            double wage = 0;
            double taxa = 0;
            if (bruteWage <= 1903.98)
                wage = bruteWage;
            else if (bruteWage >= 1903.99 && bruteWage <= 2826.65)
            {
                taxa = 7.5;
                wage = bruteWage - (bruteWage * (taxa / 100));
            }
            else if (bruteWage >= 2826.66 && bruteWage <= 3751.05)
            {
                taxa = 15;
                wage = bruteWage - (bruteWage * (taxa / 100));
            }
                
            else if (bruteWage >= 3751.06 && bruteWage <= 4664.68)
            {
                taxa = 22.5;
                wage = bruteWage - (bruteWage * (taxa / 100));
            }
                
            else if (bruteWage > 4664.68)
            {
                taxa = 27.5;
                wage = bruteWage - (bruteWage * (taxa / 100));
            }
                
            
            Console.WriteLine($"{username} é um / uma {occupation} de {age} anos e sua remuneração líquida (após taxação de {taxa}%) é de R${wage}");
        }
    }
}

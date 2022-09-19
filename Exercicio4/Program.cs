using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta) ) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta) ) / (2 * a);
            
            if(delta == 0)
            {
                Console.WriteLine(x1);
            }
            else if(delta > 0)
            {
                Console.WriteLine($"X1: {x1}");
                Console.WriteLine($"X2: {x2}");
            }
            else
            {
                Console.WriteLine("Não possui raiz");
            }
        }
    }
}

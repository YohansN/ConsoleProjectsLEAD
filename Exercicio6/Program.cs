using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(6, 3);
            Console.WriteLine(retangulo.Area());

            Triangulo triangulo = new Triangulo(4, 5);
            Console.WriteLine(triangulo.Area());
        }
    }
}

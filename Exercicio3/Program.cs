using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a expressão para que seja verificado a existência de parenteses duplicados: ");
            string input = Console.ReadLine();

            Stack<string> abertura = new Stack<string>();
            Stack<string> fechamento = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    abertura.Push("(");
                }
                else if (input[i] == ')')
                {
                    fechamento.Push(")");
                }
            }

            if (abertura.Count >= 2 && fechamento.Count >= 2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

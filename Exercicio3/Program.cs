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

            //Stack<string> parenteses = new Stack<string>();
            int contadorAbrirParenteses = 0;
            int contadorFecharParenteses = 0;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '(')
                {
                    if (contadorAbrirParenteses != 0 && contadorFecharParenteses != 0) //Caso em que o proximo parentese de abertura vem depois de um de fechamento.
                    {
                        //parenteses.Push("(");
                        contadorAbrirParenteses = 0;
                        contadorAbrirParenteses++;
                        contadorFecharParenteses = 0;
                    }
                    else //Caso em que o parentese de abertura vem em primeiro lugar ou depois de outro de abertura.
                    {
                        //parenteses.Push("(");
                        contadorAbrirParenteses++;
                    }
                }
                else if (input[i] == ')')
                {
                    //parenteses.Pop();
                    contadorFecharParenteses++;
                }
            }

            if(contadorAbrirParenteses >= 2 && contadorFecharParenteses >= 2)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
/*
Se ouver dois atos de "botar na pilha" SEGUIDOS então deve haver dois atos de tirar da fila seguidos tambem. Quando isso ocorre a saída é um true.
Quando encontra um '(' coloca ele na pilha.
Quando encontra um ')' tira o ultimo '(' da pilha e reseta o contador.
*/
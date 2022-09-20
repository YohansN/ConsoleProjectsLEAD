using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    internal class Client
    {
        public string Nome { get; set; }
        public string Ocupacao { get; set; }
        public string DataNascimento { get; set; } 
        public string Email { get; set; }

        public void Info()
        {
            Console.WriteLine($"Nome: {Nome}\nOcupação: {Ocupacao}\nData de nascimento: {DataNascimento}\nEmail: {Email}");
        }

        public void Age()
        {
            DateTime dataNascimento = Convert.ToDateTime(this.DataNascimento);
            DateTime dataAtual = DateTime.Now;

            int anoAtual = dataAtual.Year;
            int anoNascimento = dataNascimento.Year;

            int age = anoAtual - anoNascimento;
            
            Console.WriteLine($"Idade do cliente: {age} anos.");
        }

        public Client(string nome, string ocupacao, string dataNascimento, string email)
        {
            Nome = nome;
            Ocupacao = ocupacao;
            DataNascimento = dataNascimento;
            Email = email;
        }
    }
}

using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Ronaldo";
            int idade = 19;
            double saldo = 1000.00;
            DateTime data = DateTime.Today;

            Console.WriteLine($"Meu nome é {nome}");
            Console.WriteLine($"Eu tenho {idade} anos de idade");
            Console.WriteLine($"Meu saldo na conta é de {saldo}");
            Console.WriteLine($"{data.ToLongDateString()}"); //Exibe a data por extenso
            Console.WriteLine($"{data.ToShortDateString()}"); //Exibe a data abreviada
            Console.WriteLine($"{data.Month}"); //Exibe apenas o mês
            Console.WriteLine($"{data.Year}"); //Exibe apenas o ano
            Console.WriteLine($"{data.Day}"); //Exibe apenas o dia
        }
    }
}

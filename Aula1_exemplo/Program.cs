using System;

namespace Aula1_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Ronaldo";
            int idade = 19;
            double saldo = 1000.00;
            DateTime data = DateTime.Today;

            Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos, meu saldo na conta é de {saldo.ToString("c")} ");
            Console.Write($"{data.ToLongDateString()} \n");



            Console.Write("------------------------------------------------------------------------------ \n");



            Console.Write("Digite seu nome: \n");
            String nome2 = Console.ReadLine();

            Console.Write("Digite sua idade: \n");
            int idade2 = int.Parse(Console.ReadLine());

            Console.Write("Digite seu saldo: \n");
            double saldo2 = double.Parse(Console.ReadLine());

            Console.Write($"Meu nome é {nome2}, tenho {idade2} anos, meu saldo na conta é de {saldo2.ToString("c")} \n");



            Console.Write("------------------------------------------------------------------------------ \n");



            double valor1 = 50,
                   valor2 = 35;

            double soma = valor1 + valor2;
            double sub = valor1 - valor2;
            double mult = valor1 * valor2;
            double div = valor1 / valor2;
            double restoDiv = valor1 % valor2;

            Console.Write($"Resultado da soma é: {soma} \n");
            Console.Write($"Resultado da subtração é: {sub} \n");
            Console.Write($"Resultado da multiplicação é: {mult} \n");
            Console.Write($"Resultado da divisão é: {div} \n");
            Console.Write($"Resultado do resto da divisão é: {restoDiv} \n");
        }
    }
}

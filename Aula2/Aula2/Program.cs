using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;
            double saldo;


            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Meu nome e {nome}, tenho {idade} anos, meu saldo na conta é de {saldo.ToString("c")} ");

            Console.WriteLine("-----------------------------------------------------------------");

            double valor1 = 50, valor2 = 35;

            double soma = valor1 + valor2; //Somar
            double sub = valor1 - valor2; //Subtrair
            double mult = valor1 * valor2; //Multiplicar
            double div = valor1 / valor2; //Dividir
            double restoDiv = valor1 % valor2; //Resto da Divisão

            Console.WriteLine($"Resultado da soma é: {soma} ");
            Console.WriteLine($"Resultado da subtração é: {sub} ");
            Console.WriteLine($"Resultado da multiplicação é: {mult} ");
            Console.WriteLine($"Resultado da divisão é: {div} ");
            Console.WriteLine($"Resultado da resto da divisão é: {restoDiv} ");

            Console.WriteLine("-----------------------------------------------------------------");

            String chuva;

            Console.WriteLine("Hoje está chovendo? (s) ou (n)");
            chuva = Console.ReadLine();

            if(chuva == "s")
            {
                Console.WriteLine("Não irei viajar");
            }
            else
            {
                Console.WriteLine("Eu irei viajar");
            }
        }
    }
}

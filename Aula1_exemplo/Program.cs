using System;

namespace Aula1_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.Nome = Console.ReadLine(); 

            Console.WriteLine($"Nome: {calc.Nome}");
            Console.WriteLine($"O Resultado da soma é: {calc.Somar()}");
            Console.WriteLine($"O Resultado da subtração é: {calc.Subtrair()}");
            Console.WriteLine($"O Resultado da multiplicação é: {calc.Multiplicar()}");
            Console.WriteLine($"O Resultado da divisão é: {calc.Dividir()}");
            Console.WriteLine($"O Resultado do resto da divisão é: {calc.DividirResto()}");
            
        }
    }
}

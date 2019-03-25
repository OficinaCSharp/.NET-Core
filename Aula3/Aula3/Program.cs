using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"Numero {i}");
            }

            int j = 1, l = 10;
            while(j <= l){
                Console.WriteLine($"Numero {j}");
                j++;
            }

            int valor=0;
            do
            {
                Console.WriteLine("Digite '1' para sair");
                valor = Convert.ToInt32(Console.ReadLine());
            } while (valor != 1);
        }
    }
}

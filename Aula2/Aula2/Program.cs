using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;

            Console.WriteLine("Digita sua nota");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita sua nota");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita sua nota");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita sua nota");
            n4 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4) / 4;

            if(media >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }

        }
    }
}

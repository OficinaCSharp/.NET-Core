using System;
using System.Collections.Generic;
using System.Globalization;

namespace AulaList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();

            //list.Add("Matheus");
            //list.Add("Prado");
            //list.Add("Neymar");
            //list.Add("Cristiano");
            //list.Insert(2, "Lima");
            //list.Add("Maradona");
            //list.Add("Hazard");
            //list.Add("Pele");
            //list.Add("Messi");

            //foreach (string obj in list)
            //{
            //}

            //string s1 = list.Find(Apoio.Test);
            //Console.WriteLine("Fisrt 'N': " + s1);


            //string s2 = list.Find(x => x[0] == 'M');
            //Console.WriteLine("Fisrt 'M': " + s2);


            //string s3 = list.FindLast(x => x[0] == 'M');
            //Console.WriteLine("Last 'M': " + s3);


            //int s4 = list.FindIndex(x => x[0] == 'M');
            //Console.WriteLine(" first Index  'M': " + s4);


            //int s5 = list.FindLastIndex(x => x[0] == 'M');
            //Console.WriteLine(" Last Index  'M': " + s5);

            //Console.WriteLine("List count: " + list.Count);


            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("----------------------");
            //foreach (string obj in list2)
            //{
            //    Console.WriteLine(obj);
            //}



            //list.Remove("Prado");
            //Console.WriteLine("------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}


            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //// Primeiro Numero representa qual posição da lista, o segundo numero representa quantos elementos serão removido apartir da posição escolhida anteriormente
            //list.RemoveRange(1, 2);
            //Console.WriteLine("------------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}


            Console.Write("Quantos Empregados quer registrar? ");

            int n = int.Parse(Console.ReadLine());



            List<Empregado> list = new List<Empregado>();



            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Empregado #" + i + ":");

                Console.Write("Id: ");

                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");

                string name = Console.ReadLine();

                Console.Write("Salario: ");

                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregado(id, name, salario));

                Console.WriteLine();

            }



            Console.Write("Entre com o id do Empregado que deseja aumentar o salario: ");

            int searchId = int.Parse(Console.ReadLine());



            Empregado emp = list.Find(x => x.Id == searchId);

            if (emp != null)
            {

                Console.Write("Entre com a porcentagem: ");

                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncreaseSalary(percentage);

            }

            else
            {

                Console.WriteLine("Id 404 kk");

            }


            Console.WriteLine();

            Console.WriteLine("Updated list of Empregados:");

            foreach (Empregado obj in list)
            {

                Console.WriteLine(obj);

            }
            Console.ReadKey();

        }
    }
}

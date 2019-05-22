using System.Globalization;

namespace AulaList
{
    class Empregado
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }



        public Empregado(int id, string name, double salary)
        {
            Id = id;

            Name = name;

            Salary = salary;
        }



        public void IncreaseSalary(double percentage)
        {

            Salary += Salary * percentage / 100.0;

        }

        public override string ToString()
        {

            return Id

                + ", "

                + Name

                + ", "

                + Salary.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}

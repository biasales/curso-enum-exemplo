using System;
using Course.Entites.Enums;
using Course.Entites;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary:");
            double basesalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, basesalary, dept);

            Console.Write("How many contracts for worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine($"Enter {i} contracts data:");
                DateTime date = DateTime.Parse(Console.ReadLine());
                double valorperhour = double.Parse(Console.ReadLine());
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valorperhour, hours);
                worker.AddContract(contract);

            }

            Console.Write("Entre com mes e ano para saber o ganho");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departament"+worker.Departament.Name);
            Console.WriteLine("Income for" + monthAndYear + ":" + worker.Income(year, month));


        }
    }
}

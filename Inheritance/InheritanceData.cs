using System;

namespace Inheritance
{
    class InheritanceData
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Alice",
                BasicSalary = 50000,
                HRA = 20000,
                DA = 10000
            };
            Console.WriteLine($"{manager.Name}'s Gross Salary: {manager.CalculateGrossSalary()}");

            Developer developer = new Developer
            {
                Name = "Bob",
                BasicSalary = 40000,
                Bonus = 15000
            };
            Console.WriteLine($"{developer.Name}'s Gross Salary: {developer.CalculateGrossSalary()}");

            Intern intern = new Intern
            {
                Name = "Charlie",
                BasicSalary = 20000,
                Stipend = 5000
            };
            Console.WriteLine($"{intern.Name}'s Gross Salary: {intern.CalculateGrossSalary()}");

            Console.ReadLine();
        }
    }
}

using System;

namespace Inheritance
{
    class Employee
    {
        public string Name { get; set; }
        public double BasicSalary { get; set; }

        // Virtual method to calculate gross salary
        public virtual double CalculateGrossSalary()
        {
            return BasicSalary;
        }
    }
}

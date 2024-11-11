using System;

namespace Inheritance
{
    // Derived class 1
    class Manager : Employee
    {
        public double HRA { get; set; }
        public double DA { get; set; }

        // Overriding the base class method
        public override double CalculateGrossSalary()
        {
            return BasicSalary + HRA + DA;
        }
    }

    // Derived class 2
    class Developer : Employee
    {
        public double Bonus { get; set; }

        // Overriding the base class method
        public override double CalculateGrossSalary()
        {
            return BasicSalary + Bonus;
        }
    }

    // Derived class 3
    class Intern : Employee
    {
        public double Stipend { get; set; }

        // Overriding the base class method
        public override double CalculateGrossSalary()
        {
            return BasicSalary + Stipend;
        }
    }
}

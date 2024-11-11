using System;

namespace EmployeeExample
{
    public class Employee : IComparable
    

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
    }
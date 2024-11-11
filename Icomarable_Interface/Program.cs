namespace Icomarable_Interface
  class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee(1, "John Doe", 50000m);
            employees[1] = new Employee(2, "Jane Smith", 60000m);
            employees[2] = new Employee(3, "Bob Johnson", 40000m);
            employees[3] = new Employee(4, "Alice Brown", 70000m);

            Console.WriteLine("Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            
        }
    }
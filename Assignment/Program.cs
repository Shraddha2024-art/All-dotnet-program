//  using System;
//  namespace Assignment
//  {
// public class Program
// {
//     public static void f1()
//     {
//         f2();
//     }
 
//     public static void f2()
//     {
//         f3();
//     }
 
//     public static void f3()
//     {
//         try
//         {
//             Console.Write("Enter the numerator: ");
//             int numerator = int.Parse(Console.ReadLine());
 
//             Console.Write("Enter the denominator: ");
//             int denominator = int.Parse(Console.ReadLine());
 
//             int result = numerator / denominator;
//             Console.WriteLine($"Result of division: {result}");
//         }
//         catch (DivideByZeroException ex)
//         {
//             Console.WriteLine("Error: Division by zero is not allowed.");
//             Console.WriteLine(ex.Message);
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine("Error: Invalid input format. Please enter valid integers.");
//             Console.WriteLine(ex.Message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An unexpected error occurred.");
//             Console.WriteLine(ex.Message);
//         }
//     }
 
//     public static void Main()
//     {
//         try
//         {
//             f1();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred in the main function.");
//             Console.WriteLine(ex.Message);
//         }
//         finally
//         {
//             Console.WriteLine("Execution completed.");
//         }
//     }
// }
//  }

//Example Reflection:-

using System;
using System.Reflection;
 
namespace Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Shraddha", 01, 60),
                new Student("Janhvi", 02, 50),
                new Student("Raj", 03, 70),
                new Student("Ram", 04, 50),
                new Student("Rani", 05, 5)
            };
 
            foreach (Student student in students)
            {
                Type type = student.GetType();
                MethodInfo method = type.GetMethod("GetResult");
                method.Invoke(student, null);
            }
        }
    }
}
 
//  namespace Delegates
// {
//     public delegate string Mydelegate(string a, string b);
//     delegate void MymathDel(int a, int b);

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Mydelegate obj = new Mydelegate(GetFullName);
//             string ans = obj("shraddha", "Butle");
//             Console.WriteLine("Called function via delegate: " + ans);

//              MymathDel obj1 = new MymathDel(Sum);
//              obj1 += Sub;
//              obj1 += Product;
//              obj1 += Divide;


//              obj1.Invoke(20,4);
//         }

//         public static string GetFullName(string fname, string lname)
//         {
//             return fname + " " + lname;
//         }

//         public static void Sum(int a, int b)
//         {
//             Console.WriteLine($"{a} + {b} = {a + b}");
//         }

//         public static void Sub(int a, int b)
//         {
//             Console.WriteLine($"{a} - {b} = {a - b}");
//         }
//          public static void Product(int a, int b)
//         {
//             Console.WriteLine($"{a} * {b} = {a * b}");
//         }
//         public static void Divide(int a, int b)
//         {
//             Console.WriteLine($"{a} / {b} = {a /b}");
//         }
//     }
// }

// uppercase , lowercase ,Normal

using System;

namespace StringManipulationDelegates
{
    // Define a delegate that takes a string and returns a string
    public delegate string StringDelegate(string input);

    class Program
    {
        static void Main(string[] args)
        {
            // Create delegate instances for ToUpper and ToLower methods
            StringDelegate toUpperDelegate = new StringDelegate(ToUpper);
            StringDelegate toLowerDelegate = new StringDelegate(ToLower);

            // Use the delegates to convert strings
            string original = "Shraddha is Good Girl";
            string upper = toUpperDelegate(original);
            string lower = toLowerDelegate(original);

            // Print the results
            Console.WriteLine("Original: " + original);
            Console.WriteLine("Uppercase: " + upper);
            Console.WriteLine("Lowercase: " + lower);
        }

        // Method to convert a string to uppercase
        public static string ToUpper(string input)
        {
            return input.ToUpper();
        }

        // Method to convert a string to lowercase
        public static string ToLower(string input)
        {
            return input.ToLower();
        }
    }
}

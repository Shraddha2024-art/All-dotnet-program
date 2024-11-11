using System
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[]args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Entter a number");
                a= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entter a number");
                b= Convert.ToInt32(Console.ReadLine());
                c = a/b;
                Console.WriteLine($"{a}/{b}={c}");
             
             }
              catch(Exception ex)
              {
               Console.WriteLine("ex.Message");
              }
              finally
              {
              
              Console.WriteLine("Tata bye bye");

              }
            Console.Read();
        }
    }
}
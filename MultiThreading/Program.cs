// namespace MultiThreading 
// {
//     class Program
//     {
//         static void Main ()
//         {
//           Thread t = Thread.CurrentThread;
//           T.Name = "Main Thread";
//           Console.WriteLine($"Main Thread is working");
//           Thread t1 = new Thread(DisplayNumber);
//           t1.Name = "thread"
//           t1.Start();

//           Console.WriteLine();
namespace MultiThreading
 
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Thread t = new Thread(fun1);
 
 
            Thread t1 = new Thread(fun2);
 
 
            Thread t2 = new Thread(fun3);
 
            t.Start();
            t1.Start();
            t2.Start();
            t.Join();
            t1.Join();
            t2.Join();
 
            System.Console.WriteLine("Main Thread is Ending!!!  ");
            Console.ReadLine();
           
        }
 
 
        public static void fun1()
        {
            for (int i = 1; i <= 10; i++)
            {
 
                Thread.Sleep(1000);
 
                System.Console.WriteLine(2 * i);
            }
        }
 
        public static void fun2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
 
 
 
                System.Console.WriteLine(3 * i);
            }
        }
 
        public static void fun3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
 
                System.Console.WriteLine(4 * i);
            }
        }
    }
}
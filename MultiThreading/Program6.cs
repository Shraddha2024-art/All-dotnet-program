using System.Text.RegularExpressions;
using System.Threading;
using System;
 
namespace MultiThreading
{
    public class Program6
    {
        private static Mutex = new Mutex(false, "Globe\\MyuniqueMutexName");
 
        public static void Main(string[] args)
        {
            if (!Mutex.WaitOne(TimeSpam.fromsecond(3),false))
            {
                Console.WriteLine("Another instance of the application is already running");
                return;
            }
            try
            {
                Console.WriteLine("Application  is running .Press Enter to exit ");
                Console.ReadLine("");
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
 

 
using System;
using System.Threading;

namespace MultiThreading
{
    class Program3
    {
        static void Main()
        {
            // Create a new thread using ParameterizedThreadStart
            Thread t1 = new Thread(new ParameterizedThreadStart(DisplayNumbers));
            t1.Name = "Worker Thread";
            t1.Start(5); // Pass an integer parameter to the thread

            // Optionally, wait for the worker thread to finish
            t1.Join();

            Console.WriteLine("Main Thread is finished");
        }

        // Method that accepts an object parameter
        public static void DisplayNumbers(object count)
        {
            // Directly use the parameter as an integer
            for (int i = 1; i <= (int)count; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is displaying number: {i}");
                Thread.Sleep(1000); // Simulate some work with a 1-second delay
            }
    }
}
}
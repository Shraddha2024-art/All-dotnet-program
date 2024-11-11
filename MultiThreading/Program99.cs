using System.Threading;
using System;
 
namespace MutliThreading
{
    class Program99
 
{
    private static int count = o;
    public class ProgramINTERLKED
    {
        Thread[] thread = new  Thread [10];
 
        for (int i = 0; i < 1000; i++)
        {
            thread[i] = new Thread(IncrementCounter);
            thread.Start;
        }
 
        for (Thread t in threads)
        {
            t.join();
        }
 
        Console.WriteLine($"Final counter value :  {count}");
 
         
    }
 
    static void IncrementCounter(object value)
    {
        for (int i = 0; i <1000;i++)
        {
            Interlocked.Add(ref counter  )Increment(ref count);
        }
    }
}
 
 
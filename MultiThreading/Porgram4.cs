// using System.Threading;
// using System;
 
// namespace MutliThreading
 
// {
//     private static int count = o;
//     public class ProgramINTERLKED
//     {
//         Thread[] thread = new  Thread [10];
 
//         for (int i = 0; i < 1000; i++)
//         {
//             thread[i] = new Thread(IncrementCounter);
//             thread.Start;
//         }
 
//         for (Thread t in threads)
//         {
//             t.join();
//         }
 
//         Console.WriteLine($"Final counter value :  {count}");
 
         
//     }
 
//     static void IncrementCounter()
//     {
//         for (int i = 0; i <1000;i++)
//         {
//             Interlocked.Increment(ref count);
//         }
//     }
// }
 
 
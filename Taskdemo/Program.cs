// namespace Taskdemo
// {
//     class Program
//     {
//         static async Task Main(string [] args)
//         {
//             Console.WriteLine("Starting calculation...");
//             Task<int> calculation = PerformCalculationAsync(10);
//             Console.WriteLine("Doing the other work wait for Complete...");
//             int result = await calculation;
        
//             System.Console.WriteLine($"Calculation RESULT : {result}");  
//           }
 
//           static async Task<int> PerformCalculationAsync(int number)
//           {
//           await Task.Delay(2000);
//           return number * number ;
//       }
//   }
// }
namespace Taskdemo
{
    class Program_Task
    {
    //     static async Task Main(string [] args)
    //     {
    //         Console.WriteLine("Starting calculation...");
    //         Task<int> calculation = PreformCalculationAsync(10);
    //         Console.WriteLine("Doing the other work wait for Complete...");
    //         int result = await calculation
        
    //     Console 
     public static async Task Main(string[] args) // Changed to Task Main
    {
         System.Console.WriteLine("Starting calculation...");
 
     Task<int>task1 = Task.Run(()=> PerformCalculation(10));
     Task<int>task2 = Task.Run(()=> PerformCalculation(20));
     Task<int>task3 = Task.Run(()=> PerformCalculation(30));

     int[] results = await Task.WhenAll(task1,task2, task3);
     Console.WriteLine("Result:");
     foreach (int result in results)
     {
        Console.WriteLine(result);
     }
    static int PerformCalculation(int number)
    {
        int result = number * number;
        Task.Delay(2000);
        Console.WriteLine($"Calculatedb square of {number} as {result}");
        return result;
        
    }
     }
    }

}

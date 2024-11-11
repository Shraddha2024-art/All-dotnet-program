namespace MultiThreading
{
    class Number
    {
        public void DisplayNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is displaying number: {i}");
                Thread.Sleep(1000); // Simulate some work with a 1-second delay
            }
        }
    }
}
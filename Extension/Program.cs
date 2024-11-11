using ExtensionLib;

namespace Extension{
    class Program
    {
        static void Main(string[] args)
        {
            string s="Shraddha is a good girl";
            int i=s.WordCount1();
            System.Console.WriteLine("There is "+i+" sub string");
        }
    }
}
using System.Collections.Concurrent;
using System.ComponentModel;
 
namespace LINQDemo{
 
    internal class Program{
 
        public static void Main(string[] args)
        {
            int[] numbers = {1,4,7,23,45,67,23,11,32,87,31};
 
            var result1=from n in numbers
                        where n < 30
                        select n;
            System.Console.WriteLine(".........Numbers............");
            foreach(var n in result1){
                System.Console.WriteLine(n);
            }    
 
            string[] words = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
 
            var result2= (from w in words    
                         where w[1]=='i'
                         select w).Reverse();
            System.Console.WriteLine("..........Words............");
            foreach(var w in result2){
                System.Console.WriteLine(w);
            }    
 
            string[] musicians = {"Ashok kumar", "Kishor kumar", "Asha Bhosale", "Lata Mangeshkar", "Sonu Nigam"};
 
            var result3= from m in musicians
                         where m.StartsWith("As")
                         select m;
            System.Console.WriteLine("..........Musicians............");
 
            foreach(var m in result3){
                System.Console.WriteLine(m);
            }            
 
            int[] numA ={12,3,5,7,9,14,17,19};
            int[] numB = { 1,2,3,4,5,6,7,8,9};
 
            var result4= numA.Union(numB);
            System.Console.WriteLine("............Union............");
            foreach(var n in result4){
                System.Console.WriteLine(n);
            }
 
           
            var result5= numA.Intersect(numB);
            System.Console.WriteLine("...........Intersect............");
            foreach(var n in result5){
                System.Console.WriteLine(n);
            }
 
              var result6= numA.Except(numB);
            System.Console.WriteLine("...........Except............");
            foreach(var n in result6){
                System.Console.WriteLine(n);
            }
 
            string[]  cities = {"Mumbai", "Pune", "Tuljapur","Amravati","Indore",};
            var result7 = cities();
            Console.WriteLine("..........Distinct city name........");
            foreach(var c in result7)
            {
                //Agreegate functio
                int sum = numbers.Sum();
                Console.WriteLine($ "sum of elements {sum}");
                int sum = numbers.Max();
                Console.WriteLine($ "Max of elements {sum}");
                int sum = numbers.Min();
                Console.WriteLine($ "Min of elements {sum}");
                 int sum = numbers.Count();
                Console.WriteLine($ " Count of elements {sum}");

                Console.WriteLine("------------------");
                string [] Words={"Belive","Relief","Recive","Chief"};
                bool IAfterE = Words.Any(w>=w.Contains("ei"));
                Console.WriteLine($ "Words Array contains ie sequence {IAfterE}");
                bool EAfterI= Words.All(w => w.Contains("ie"));
                Console.WriteLine($ "Words Array contains All element \"ei\" sequence  {EAfterI}");



            }
        }
    }
}
 
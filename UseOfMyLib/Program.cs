using MyLib;
using Currency;
namespace UseOfMyLib
{
    class Program
    {
     static void Main()
     {
        MyLib.MyMath M1 = new MyMath();
        M1.Add(10,30);
        M1.Sub(30,20);
        M1.Multi(3,20);
        M1.Divide(3,10);




        
        
        
        // CurrencyConverter obj=new CurrencyConverter();

        // decimal d=obj.ConvertUSDtoIND(100);

        // System.Console.WriteLine("USD to Indian is :- "+d);

        // decimal d1=obj.ConvertINDtoUSD(200);
        // System.Console.WriteLine("Indian to USD is :- "+d1);

     }
    }
}


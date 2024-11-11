// using System;

// class Keywords

// //Overloading Method : same functio/Method name And 
// //Same arrguments Vriable Name & diffrent/same data type

// {
//     static void Main(string[] args){
//     /*{
//         Sum(30,40);
//         Sum(2,3,2);
//         Sum(2.5,4);
//     }
//         public static void Sum(int a,int b)
//         {
//          Console.WriteLine($"{a}+{b}={a+b}");
//         }
//         public static void Sum(int a,int b,int c)
//         {
//          Console.WriteLine($"{a}+{b}+{c}={a+b+c}");
//         }
//         public static void Sum(double a,int b)
//         {
//          Console.WriteLine($"{a}*{b}={a*b}");
//         }

//     }*/


//     // Keywords: Var, Ref, Out, Params (It is Compile time its diside data type to be int)
//     // 1. Var

    
//         //    Console.WriteLine("Enter the first number:");
//         //     var no1 =Console.ReadLine();

//         //     Console.WriteLine("Enter the second number:");
//         //     var no2 =Console.ReadLine();

//         //     var sum = (no1 + no2);

//         //     Console.WriteLine("The sum is: " + sum);

//         int a = 20;
//         Console.WriteLine();
//         int ans;
//         int b = 30;
//         showDetials(ref a, ref b,out ans);
//         Console.WriteLine("Sum of two number: " + ans);
//         Console.WriteLine($"After Calling function: {a}");
//         dynamic it=10;
//         it="pratik";
//         //dynamic it =20;


//         var obj=20;
//       //  obj="pratik";

//     }


//     public static void  showDetials(ref int a, ref int b,out int ans)
//     {
//         a++;
//         ans = a + b;
//         //return ans;
//     }

// }

// //
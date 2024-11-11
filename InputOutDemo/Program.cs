using System;
//  using System.Net.Http.Headers;
//  using System.Runtime.CompilerServices;
//  using System.Runtime.ConstrainedExecution;

namespace InputOutDemoP{
// {
//     class Program
//     {
//        static void Main(string[] args)
       // {

//             // //Calculate Area
//             //             /*Console.WriteLine("Enter Radius");
//             //             double radius = Convert.ToInt32(Console.ReadLine());
//             //             double area = 3.14*radius*radius;
//             //             System.Console.WriteLine(area);*/

//             // //Area of Rectangle
//             //            /* Console.WriteLine("Enter Lenght Value");
//             //             int length = Convert.ToInt32(Console.ReadLine());
//             //             Console.WriteLine("Enter Width Value");
//             //             int width = Convert.ToInt32(Console.ReadLine());

//             //             int areaOfRect = length*width;
//             //             Console.WriteLine($"Area of rectangle is: {areaOfRect}");*/

//             // // Solve int i = 2, j=4, k=(i--)+2*j;
//             //             //  int i = 2;
//             //             //  int j = 4;
//             //             //  int k =(i--)*(i--)+2*j;
//             //             //  Console.WriteLine($"value of k is: {k}");

//             // //Show even and odd numbers

//             //         // Console.WriteLine("Enter the Number: ");
//             //         // int number = Convert.ToInt32(Console.ReadLine());
//             //         // if (number%2==0)
//             //         // {
//             //         //  Console.WriteLine($"{number} is an Even number.");
//             //         // }  
//             //         // else
//             //         // {
//             //         // Console.WriteLine($"{number} is an Odd number.");
//             //         // }

//             // //        
//             //         //     Console.WriteLine("Enter a number:");
//             //         //     int number = Convert.ToInt32(Console.ReadLine());

//             //         //     if (number == 0)
//             //         //     {
//             //         //         Console.WriteLine("The number is zero.");
//             //         //     }
//             //         //     else
//             //         //     {
//             //         //         if (number > 0)
//             //         //         {
//             //         //             Console.WriteLine("The number is positive.");
//             //         //         }
//             //         //              else
//             //         //         {
//             //         //             Console.WriteLine("The number is negative.");
//             //         //         }

//             //         //         if (number % 2 == 0)
//             //         //         {
//             //         //             Console.WriteLine("The number is even.");
//             //         //         }
//             //         //         else
//             //         //         {
//             //         //             Console.WriteLine("The number is odd.");
//             //         //         }
//             //         //     }



//             //             // Console.WriteLine("Enter the first number:");
//             //             // double num1 = Convert.ToDouble(Console.ReadLine());

//             //             // Console.WriteLine("Enter an operator (+, -, x, /, x):");
//             //             // char operatorInput = Console.ReadLine()[0];

//             //             // Console.WriteLine("Enter the second number:");
//             //             // double num2 = Convert.ToDouble(Console.ReadLine());

//             //             // double result = 0;

//             //             // switch (operatorInput)
//             //             // {
//             //             //     case '+':
//             //             //         result = num1 + num2;
//             //             //         break;
//             //             //     case '-':
//             //             //         result = num1 - num2;
//             //             //         break;
//             //             //     case 'X':
//             //             //     case 'x':
//             //             //         result = num1 * num2;
//             //             //         break;
//             //             //     case '/':
//             //             //         if (num2 != 0)
//             //             //         {
//             //             //             result = num1 / num2;
//             //             //         }
//             //             //         else
//             //             //         {
//             //             //             Console.WriteLine("Error: Division by zero is not allowed.");
//             //             //             return;
//             //             //         }
//             //             //         break;
//             //             //     default:
//             //             //         Console.WriteLine("Invalid operator. Please use +, -, *, /, or x.");
//             //             //         return;
//             //             // }

//             //             // Console.WriteLine($"Result: {num1} {operatorInput} {num2} = {result}");

//             // //do loop
//             //           //  {           
//             //           //   int counter = 1;

//             //           //   while (counter <= 5)
//             //           //   {
//             //           //       Console.WriteLine($"While Loop: Counter is {counter}");
//             //           //       counter++;
//             //           //   }


//             //  //while loop  

//             //           // {
//             //           //  int counter = 1;

//             //           //   do
//             //           //   {
//             //           //       Console.WriteLine($"Do-While Loop: Counter is {counter}");
//             //           //       counter++;
//             //           //   } while (counter <= 5);

//             // //Array
//             //           // {
//             //           //   String[] color = new string[4];
//             //           //   color [0] = "pink";
//             //           //   color [1] = "blue";
//             //           //   color [2] = "yellow";
//             //           //   color [3] = "red";
//             //           //   Console.WriteLine(".......color are......");






//             //     //       }
//             //     //    }
//             //     // }
//             //     // {

//             // //Sawp

//             //     // static void Swap(ref int a, ref int b)
//             //     //     {
//             //     //         int temp = a;
//             //     //         a = b;
//             //     //         b = temp;
//             //     //     }
//             //     // }

//             // //ref Variable    
//             //         {
//             //             Console.WriteLine("Enter the length of the rectangle:");
//             //             double length = Convert.ToDouble(Console.ReadLine());

//             //             Console.WriteLine("Enter the width of the rectangle:");
//             //             double width = Convert.ToDouble(Console.ReadLine());

//             //             double area;
//             //             CalculateArea1(ref length, ref width, out area);

//             //             Console.WriteLine($"The area of the rectangle is: {area}");
//             //         }

//             //         static void CalculateArea1(ref double length, ref double width, out double area)
//             //         {
//             //             area = length * width;
//             //         }
//             //     }
//             //   }


// //Employee class called     
        
          // Employee e1=new Employee();

          // Employee e1=new Employee(101,"Radha","kumar",3000,Department.HR,new Date (9,5,2067));

          // Console.WriteLine(e1);

// //Product class called        
         
        //   Product ProductDetails =new Product (101,"Shraddha","yash",40000,Category.Toys,Manufacturing.International, new Date (9,5,2067));
          
        //   Product DefualtData = new Product();
        //   System.Console.WriteLine(DefualtData);
          
          //MyMath mymath = new 

    //      }

    //  }


public class CurrencyConverter
{
    private const decimal USD_TO_INR = 85.00m;
    private const decimal EUR_TO_INR = 90.00m;
    private const decimal CAD_TO_INR = 65.00m;

    public decimal ConvertINRtoUSD(decimal amount)
    {
        return amount / USD_TO_INR;
    }

    public decimal ConvertUSDtoINR(decimal amount)
    {
        return amount * USD_TO_INR;
    }

    public decimal ConvertINRtoEUR(decimal amount)
    {
        return amount / EUR_TO_INR;
    }

    public decimal ConvertEURtoINR(decimal amount)
    {
        return amount * EUR_TO_INR;
    }

    public decimal ConvertINRtoCAD(decimal amount)
    {
        return amount / CAD_TO_INR;
    }

    public decimal ConvertCADtoINR(decimal amount)
    {
        return amount * CAD_TO_INR;
    }

    public static void Main(string[] args)
    {
        CurrencyConverter converter = new CurrencyConverter();
        Console.WriteLine("Currency Converter");
        Console.WriteLine("1: Convert INR to USD");
        Console.WriteLine("2: Convert USD to INR");
        Console.WriteLine("3: Convert INR to EUR");
        Console.WriteLine("4: Convert EUR to INR");
        Console.WriteLine("5: Convert INR to CAD");
        Console.WriteLine("6: Convert CAD to INR");
        Console.Write("Enter your choice (1-6): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        decimal convertedAmount = 0;
        switch (choice)
        {
            case 1:
                convertedAmount = converter.ConvertINRtoUSD(amount);
                Console.WriteLine($"{amount} INR is equal to {convertedAmount} USD");
                break;
            case 2:
                convertedAmount = converter.ConvertUSDtoINR(amount);
                Console.WriteLine($"{amount} USD is equal to {convertedAmount} INR");
                break;
            case 3:
                convertedAmount = converter.ConvertINRtoEUR(amount);
                Console.WriteLine($"{amount} INR is equal to {convertedAmount} EUR");
                break;
            case 4:
                convertedAmount = converter.ConvertEURtoINR(amount);
                Console.WriteLine($"{amount} EUR is equal to {convertedAmount} INR");
                break;
            case 5:
                convertedAmount = converter.ConvertINRtoCAD(amount);
                Console.WriteLine($"{amount} INR is equal to {convertedAmount} CAD");
                break;
            case 6:
                convertedAmount = converter.ConvertCADtoINR(amount);
                Console.WriteLine($"{amount} CAD is equal to {convertedAmount} INR");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                break;
        }
    }
}
}
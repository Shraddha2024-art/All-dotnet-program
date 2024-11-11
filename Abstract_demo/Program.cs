// See https://aka.ms/new-console-template for more information


using System;

namespace Abstract_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount current = new CurrentAccount(7.5f,32000m,101,new Customer(1,"Raj","Arora","rajarora@gmail.com","Solapur Maharastra",703872322,new Date(14,03,2002)));
 
            SavingAccount saving = new SavingAccount(9.5f,59000m,102,new Customer(2,"Shraddha","Butle","shraddhab.butale@gmail.com","AMT Maharastra",703872322,new Date(14,03,2002)));
 
            System.Console.WriteLine();
            System.Console.WriteLine(current);
            current.ShowBalance();
           
            System.Console.WriteLine();
            System.Console.WriteLine();
 
            System.Console.WriteLine(saving);
            saving.ShowBalance();

        }
    }
}
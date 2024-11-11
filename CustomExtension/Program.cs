using System;
using System.collection.Generic;
namespace CustomeExtension
{
    internal class Program1
    {
        static void Main(string[]args)
        {
            int ticketNo;
            try
            {
                Console.WriteLine("Enter Ticket No");
                ticketNo = Convert.ToInt32(Console.ReadLine());
                if(ticketNo>50)
                throw new CustomeExtension("Ticket Number not Avilable")
            }
        }
    }
}
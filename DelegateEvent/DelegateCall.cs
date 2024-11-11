using System;
 
namespace DelegateEvent
{
    delegate void StuMsg();
    class DelegateCall
    {
 
        public int hour { get; set; }
 
 
        public event StuMsg GM;
 
        public event StuMsg GA;
        public event StuMsg GE;
        public event StuMsg GN;
 
        int live=DateTime.Now.Hour;
 
 
        public void EnterHours(int hr)
        {
            if (hr >= 0 && hr <= 12)
            {
                GM();
            }
 
            else if (hr > 12 && hr <= 16)
            {
                GA();
            }
            else if (hr > 16 && hr <= 20)
            {
                GE();
            }
 
            else if (hr > 20 && hr <= 24)
 
            {
                GN();
 
            }
 
            else
            {
                System.Console.WriteLine("Enter the valid time ");
            }
        }
 
 
        public void LiveHours(int hr)
        {
            if (hr >= 0 && hr <= 12)
            {
                GM();
            }
 
            else if (hr > 12 && hr <= 16)
            {
                GA();
            }
            else if (hr > 16 && hr <= 20)
            {
                GE();
            }
 
            else if (hr > 20 && hr <= 24)
 
            {
                GN();
 
            }
 
            else{
                System.Console.WriteLine("Enter the valid time");
            }
        }
 
 
    }
}
 
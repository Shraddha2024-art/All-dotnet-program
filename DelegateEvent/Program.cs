// namespace DelegateEvent
// {
//     class Program
//     {
//         static void Main(String[] args)
//         {
//             Student obj=new Student(){Id=1,Name="shradha"};

//             obj.Pass+=new Marked(ShowMessage.GoodMsg);
//             obj.Fail+=new Marked(ShowMessage.BadMsg);
//             System.Console.WriteLine("Enter the shradha marks :- ");
//             int marks=Convert.ToInt32(Console.ReadLine());
//             obj.EnterMarks(marks);


//Show Massage Event GM/GN/GA/GN


using System;
using DelegateEventHandling;


namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int live = DateTime.Now.Hour;
 
           DelegateCall obj =new DelegateCall();
            obj.GM += new StuMsg(ShowMessageTime.ShowGM);
            obj.GA += new StuMsg(ShowMessageTime.ShowGF);
            obj.GE += new StuMsg(ShowMessageTime.ShowGE);
            obj.GN += new StuMsg(ShowMessageTime.ShowGN);
 
            //obj.EnterHours(23);
 
            obj.LiveHours(live);
            System.Console.WriteLine("Current Time : "  +DateTime.Now);
        }
    }
}
 
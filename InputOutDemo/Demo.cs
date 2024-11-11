using System;
using System.Runtime.Serialization;

namespace InputOutDemo
{
    class Student
    {
       public int RollNo { get; set; }

       public String Name{ get; set; }

       public int Marks { get; set; }

       public Student (int rollNo, String name, int marks)
       {
        this.RollNo=rollNo;
        Name = name;
        Marks=marks;
       }
       public void Display()
       {
        Console.WriteLine("Student Details: {RollNo}, {Name} {Marks}");
       }
    }

}
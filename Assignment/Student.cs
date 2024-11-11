using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
 
namespace Assignment
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Marks { get; set; }
 
        public Student(string name, int rollNo, int marks)
        {
            Name = name;
            RollNo = rollNo;
            Marks = marks;
        }
 
        public void GetResult()
        {
            if (Marks >= 50)
            {
                Console.WriteLine($"{Name} (Roll No: {RollNo}) has passed with {Marks} marks.");
            }
            else
            {
                Console.WriteLine($"{Name} (Roll No: {RollNo}) has failed with {Marks} marks.");
            }
        }
    }
}
 
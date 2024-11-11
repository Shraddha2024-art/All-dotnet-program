namespace LINQQuery
public class Student 
{
public int ID {get;set;}
public string Name {get;set;}
public string Gender {get;set;}
public string Branch {get;set;}
public int Age {get;set;}
public static List<Student>GetStudents()
{
    List<Student> students = new List<Student>()
    {
        new Student {ID = 1001, Name = "Preety", Gender = "Female",Branch="ETC",Age=23};
        new Student {ID = 1002, Name = "Anurag", Gender = "Male",Branch="ETC",Age=24};
        new Student {ID = 1003, Name = "Pranaya", Gender = "Female",Branch="ETC",Age=25};
        new Student {ID = 1004, Name = "Anurag", Gender = "Male",Branch="ETC",Age=24};
        new Student {ID = 1005, Name = "Priya", Gender = "Female",Branch="ETC",Age=28};
        new Student {ID = 1006, Name = "Shraddha", Gender = "Female",Branch="ETC",Age=24};
        new Student {ID = 1001, Name = "Raj", Gender = "Male",Branch="ETC",Age=26};
        new Student {ID = 1001, Name = "shyam", Gender = "Male",Branch="CPS",Age=29};

    }
}




}
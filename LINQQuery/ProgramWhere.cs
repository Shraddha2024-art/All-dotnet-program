namespace LINQQuery
{ 
    internal class Main (string[] args)
    {
        var result = from s in Student.GetStudent()
                     where s.Gender=="Female"
                     select s;
        Console.WriteLine(".......List of girls.....");
        foreach (var student in result)
        {
         Console.WriteLine(student.ID+" "+student.Gender);

        }  
        // Now using where Lambda Expression

        var result1 = Student.GetStudents().where(s => s.Gender == " Male") ;
        foreach (var student in result1)
        {
        Console.WriteLine(student.ID + " "+ student.Name+" "+)
        }
        
             
    }
}
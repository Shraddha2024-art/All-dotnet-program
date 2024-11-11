// using System;
// using System.Data;
// using EduHub_Repository_Console_Project.Repository;
// using EduHub_Repository_Console_Project.Models;
// namespace EduHub_Repository_Console_Project
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             UserRepository repo = new UserRepository();
//             User user;


//             int id;
//             int result;
//             DataSet ds = new DataSet();
//             int entry;
//             bool Continue = true;
//             char reply;
//             System.Console.WriteLine("-------------------------------------------------");
//             while (Continue)
//             {
//                 System.Console.WriteLine("Press 0 to Exit \n Press 1 for all Teacher \n Press 2 All students \n press 3 for added new user\n");
//                 entry = Convert.ToInt32(Console.ReadLine());
//                 switch (entry)
//                 {
//                     case 0:
//                         Environment.Exit(0);
//                         break;

//                     case 1:
//                         System.Console.WriteLine("Show all teachers -----");
//                         ds = repo.GetAllTeachers();
//                         foreach (DataRow row in ds.Tables[0].Rows)
//                         {
//                             System.Console.WriteLine($"Id : {row["UserId"]}  Teacher name :-  {row["UserName"]}");
//                         }
//                         break;


//                     case 2:


//                         System.Console.WriteLine("showw all Students------------------------");
//                         ds = repo.GetAllStudents();
//                         foreach (DataRow row in ds.Tables[0].Rows)
//                         {
//                             System.Console.WriteLine($"Id :{row["UserId"]} Student name : {row["UserName"]}");
//                         }
//                         break;

//                     case 3:
//                         System.Console.WriteLine("Add new User");
//                         System.Console.WriteLine("To add new user enter username ");
//                         user = new User();
//                         System.Console.WriteLine("Enter username ");
//                         string name = Console.ReadLine();
//                         bool res = repo.UserExists(name);
//                         if (res)
//                         {
//                             System.Console.WriteLine("User name is already exits ");
//                             break;
//                         }

//                         else
//                         {

//                             user.UserName = name;
//                             System.Console.WriteLine("enter password");
//                             user.Password = Console.ReadLine();

//                             System.Console.WriteLine("enter email");
//                             user.Email = Console.ReadLine();

//                             System.Console.WriteLine("enter MobileNumber");
//                             user.MobileNumber = Console.ReadLine();

//                             System.Console.WriteLine("enter UserRole");
//                             user.UserRole = Console.ReadLine();

//                             System.Console.WriteLine("enter ProfileImagej");
//                             user.ProfileImage = Console.ReadLine();

//                             int noOfRows = repo.AddUser(user);
//                             if (noOfRows > 0)
//                             {
//                                 System.Console.WriteLine("user added successfully");
//                             }
//                             else
//                             {
//                                 System.Console.WriteLine("user add fail");

//                             }



//                         }
//                         break;
//                     default:
//                         break;
//                 }

//                 Console.WriteLine("Do you want to continue? Y/N");
//                 reply = Convert.ToChar(Console.ReadLine());
//                 if (reply == 'Y' || reply == 'y')
//                     Continue = true;
//                 else if (reply == 'N' || reply == 'n')
//                 {
//                     Environment.Exit(0);
//                 }



//             }

//         }
//     }
// }
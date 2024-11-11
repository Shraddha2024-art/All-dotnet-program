using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using EduHub_Repository_Console_Project.Models;
using EduHub_Repository_Console_Project.Repository;
namespace EduHub_Repository_Console_Project
{
    class Program2
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static DataSet ds;
        public static DataTable dt;
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            System.Console.WriteLine("Login page");
            System.Console.WriteLine("Enter username ");
            string? username = Console.ReadLine();
            System.Console.WriteLine("Enter passward ");
            string? passward = Console.ReadLine();
            User user = userRepository.Login(username, passward);
            string role = string.Empty;
            if (user != null)
            {
                System.Console.WriteLine($" \n {user.UserName}-{user.Password}-{user.Email}");
                role = user.UserRole;
                if (role == "Educator")
                {
                    EducatorDashboard(user);
                }

                else if (role == "Student")
                {
                    StudentDashBoard(user);
                }
                else
                {
                    System.Console.WriteLine("User role does not exist");
                }
            }
            else
            {
                System.Console.WriteLine("User does not exist");
            }
        }

        public static void EducatorDashboard(User user)
        {
            CourseRepository repo = new CourseRepository();
            int menu;

            bool Continue = true;
            char reply;
            System.Console.WriteLine("-------------------------------------------------");
            while (Continue)
            {
                System.Console.WriteLine("Press 1: show Allcourses \n Press 2: show my Mycourses\n Press 3:  Add New Couses \n Press 4: See and Upload Material  \n Press 5: Update Course \n Press 6: See enrolled student \n Press 7:  Feedback list \n Press 8 Show Enquiry");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        System.Console.WriteLine("-------------------Show All Courses--------------");
                        DataSet ds = new DataSet();
                        ds = repo.GetAllCourses();


                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Data is empty");

                        }
                        else
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"CourseId : {row["CourseId"]}  Course name :-  {row["Title"]}");
                            }

                        }
                        break;

                    case 2:
                        System.Console.WriteLine("-----Show My Courses------ ");

                        ds = repo.GetCourseByUser(user.UserId);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"\nTitle : {row["Title"]} \nDescription : {row["Description"]} \nUserId : {row["UserId"]} \nCategory : {row["Category"]}  \nLevel : {row["Level"]}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("No data found");
                        }

                        break;

                    case 3:
                        System.Console.WriteLine("----------------Add new Courses-----------------");
                        Course course = new Course();


                        System.Console.WriteLine("Enter Title");
                        course.Title = Console.ReadLine();


                        System.Console.WriteLine("Enter Description ");
                        course.Description = Console.ReadLine();

                        System.Console.WriteLine("Enter Start Date ");
                        course.CourseStartDate = Convert.ToDateTime(Console.ReadLine());

                        System.Console.WriteLine("Enter End Date");
                        course.CourseEndDate = Convert.ToDateTime(Console.ReadLine());

                        // System.Console.WriteLine("Enter course Id");
                        course.UserId = user.UserId;

                        System.Console.WriteLine("Enter Category ");
                        course.Category = Console.ReadLine();
                        System.Console.WriteLine("Enter Level ");
                        course.Level = Console.ReadLine();


                        int noOfRows = repo.AddCourse(course);
                        if (noOfRows > 0)
                        {
                            System.Console.WriteLine("course added successfully");
                        }
                        else
                        {
                            System.Console.WriteLine("course add fail");

                        }


                        break;

                    case 4:
                        System.Console.WriteLine("------------------ Material-------------------");
                        System.Console.WriteLine();
                        MaterialRepository materialRepository = new MaterialRepository();
                        Material material = new Material();
                        System.Console.WriteLine("Press 1: See your Material");
                        System.Console.WriteLine("Press 2: Upload New Material ");
                        System.Console.WriteLine();

                        System.Console.WriteLine("Enter the Choice for see and Upload the Material");

                        int flag = Convert.ToInt32(Console.ReadLine());

                        switch (flag)
                        {
                            case 1:
                                System.Console.WriteLine("Enter course Id ");
                                int courseid = Convert.ToInt32(Console.ReadLine());

                                ds = materialRepository.GetCourseMaterialById(courseid);

                                if (ds.Tables[0].Rows.Count == 0)
                                {
                                    System.Console.WriteLine("There is no any material ");

                                }
                                else
                                {
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {
                                        System.Console.WriteLine($"MaterialId:- {row["MaterialId"]} Title:- {row["Title"]} Description :- {row["Description"]} URL:- {row["URL"]}");
                                    }

                                }

                                break;
                            case 2:

                                ds = repo.GetCourseByUser(user.UserId);

                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    System.Console.WriteLine("Currently you have following courses.");
                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {
                                        System.Console.WriteLine($" \n CourseId : {row["courseId"]}\nTitle : {row["Title"]} \nDescription : {row["Description"]}  \nCategory : {row["Category"]}  \nLevel : {row["Level"]}");
                                    }


                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Enter the course Id that you want to Add the Material");
                                    int id3 = Convert.ToInt32(Console.ReadLine());

                                    int count = 0;
                                    int count1 = ds.Tables[0].Rows.Count;


                                    foreach (DataRow row in ds.Tables[0].Rows)
                                    {

                                        if (id3 == (int)row["courseId"])
                                        {

                                            material.CourseId = id3;
                                            System.Console.WriteLine("Enter the Material Title");
                                            string? title1 = Console.ReadLine();

                                            material.Title = title1;

                                            System.Console.WriteLine("Enter the Description");
                                            string Description = Console.ReadLine();
                                            material.Description = Description;

                                            System.Console.WriteLine("Enter the URL");
                                            string URL = Console.ReadLine();
                                            material.URL = URL;

                                            material.UploadDate = DateTime.Now;

                                            System.Console.WriteLine("Enter the Content Type");
                                            string type = Console.ReadLine();
                                            material.ContentType = type;

                                            int result = materialRepository.AddCourseMaterialById(material);

                                            if (result > 0)
                                            {
                                                System.Console.WriteLine("Material Add Successfully ");
                                            }
                                            else
                                            {
                                                System.Console.WriteLine("Sorry Material Not added successfully ");
                                            }

                                        }
                                        count++;

                                        if (count1 == count)
                                        {
                                            System.Console.WriteLine("You dont have that course which you have to upload the materials");


                                        }

                                        // else
                                        // {
                                        //     System.Console.WriteLine("You dont have that course which you have to upload the materials");
                                        //     break;
                                        // }

                                    }


                                }
                                else
                                {
                                    System.Console.WriteLine("Currently you have not any course.");
                                }





                                break;





                            default:
                                System.Console.WriteLine("Enter the Valid Choice ");
                                break;

                        }












                        break;

                    case 5:
                        System.Console.WriteLine("-------------Update course-------------------");
                        break;

                    case 6:
                        System.Console.WriteLine("------------------Student in course-------------- ");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Enter the course Id ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        EnrollmentRepository enrollmentRepository = new EnrollmentRepository();

                        ds = enrollmentRepository.StudentInCourse(id2);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"EnrollmentId :- {row["EnrollmentId"]} UserId:- {row["UserId"]} Title:- {row["Title"]} Status:- {row["Status"]} Enrollment Date:- {row["EnrollmentDate"]}");
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Sorry we could not fount.");
                        }




                        break;

                    case 7:
                        System.Console.WriteLine("---------Feedback list--------------- ");


                        ds = repo.GetCourseByUser(user.UserId);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            System.Console.WriteLine("Following are the list of your courses.");
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"\nTitle : {row["Title"]} \nDescription : {row["Description"]} \nUserId : {row["UserId"]} \nCategory : {row["Category"]}  \nLevel : {row["Level"]}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("No any courses found");
                        }


                        System.Console.WriteLine("Enter the course id which you want the feedback.");
                        int courseid5 = Convert.ToInt32(Console.ReadLine());

                        FeedbackRepository feedbackRepository = new FeedbackRepository();
                        FeedBack feedBack = new FeedBack();

                        ds = feedbackRepository.getFeedbacksByCourseId(courseid5);

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"User name :- {row["username"]} Title :- {row["title"]} Feedback:- {row["feedback"]}");
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Currently there is no any feedback ");
                        }






                        break;

                    case 8:

                        ds = repo.GetCourseByUser(user.UserId);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            System.Console.WriteLine("Following are the list of your courses.");
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"\nTitle : {row["Title"]}\n CourseId:- {row["CourseId"]} \nDescription : {row["Description"]} \nUserId : {row["UserId"]} \nCategory : {row["Category"]}  \nLevel : {row["Level"]}");
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("No any courses found");
                        }

                       
                        Enquiry enquiry=new Enquiry();

                      System.Console.WriteLine("--------------------- Enquiry List --------------");
                        EnquiryRepository enqRepo = new EnquiryRepository();
                        System.Console.WriteLine("Enter courseid: ");
                        int courseid9 = Convert.ToInt32(Console.ReadLine());
 
                        ds = enqRepo.ViewEnquiryByCourseId(courseid9);
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            System.Console.WriteLine($"{row["EnquiryId"]} - {row["UserId"]} - {row["Subject"]} - {row["Message"]} - {row["Status"]} - {row["Response"]}");
                        }

                        break;
                    default:
                        System.Console.WriteLine("Please enter the choice from 1 to 6");
                        break;


                }

                Console.WriteLine("Do you want to continue? Y/N");
                reply = Convert.ToChar(Console.ReadLine());
                if (reply == 'Y' || reply == 'y')
                    Continue = true;
                else if (reply == 'N' || reply == 'n')
                {
                    Environment.Exit(0);
                }
            }
        }


        public static void StudentDashBoard(User user)
        {

            Enrollment enrollment = new Enrollment();
            Course course = new Course();
            EnrollmentRepository enrollmentRepository = new EnrollmentRepository();
            int menu;

            bool Continue = true;
            char reply;
            System.Console.WriteLine("------------------Student-------------------------------");
            while (Continue)
            {
                System.Console.WriteLine(" Press 1: Show Available Courses \n Press 2: Show My Enrolled Courses \n Press 3: Enroll in new Course \n Press 4: Show Material \n Press 5: Enquiry Regarding Course \n Press 6:   Give Feedback \n Press 7: My Feedback ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        System.Console.WriteLine("Show Available Courses");
                        System.Console.WriteLine();
                        DataSet ds = new DataSet();
                        ds = enrollmentRepository.ShowAvailableCourses();

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses");
                        }
                        else
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Course Id :- {row["CourseId"]} Course Name :- {row["Title"]} CourseStartDate:- {row["CourseStartDate"]} CourseEndDate :- {row["CourseEndDate"]}");
                            }
                        }




                        break;

                    case 2:
                        System.Console.WriteLine("Show My Enrolled Courses");

                        System.Console.WriteLine();
                        DataSet dataSet4 = new DataSet();
                        int userid = user.UserId;
                        dataSet4 = enrollmentRepository.EnrolledCourses(userid);

                        if (dataSet4.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses");
                        }
                        else
                        {
                            foreach (DataRow row in dataSet4.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Enrollment Id :- {row["EnrollmentId"]} UserId:- {row["UserId"]} CourseId:- {row["CourseId"]} Title:- {row["Title"]} Enrolled Date :- {row["EnrollmentDate"]} Status :- {row["Status"]}");
                            }
                        }

                        break;

                    case 3:
                        System.Console.WriteLine("Enroll in new Course");

                        System.Console.WriteLine("Show Available Courses");
                        System.Console.WriteLine();
                        DataSet dataSet1 = new DataSet();
                        dataSet1 = enrollmentRepository.ShowAvailableCourses();

                        if (dataSet1.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses");
                        }
                        else
                        {
                            foreach (DataRow row in dataSet1.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Course Id :- {row["CourseId"]} Course Name :- {row["Title"]} CourseStartDate:- {row["CourseStartDate"]} CourseEndDate :- {row["CourseEndDate"]}");
                            }
                        }

                        System.Console.WriteLine("Enter the course Id that you want to Enroll");
                        int id = Convert.ToInt32(Console.ReadLine());

                        foreach (DataRow row in dataSet1.Tables[0].Rows)
                        {
                            if ((int)row[course.CourseId] == id)
                            {
                                Enrollment enrollment1 = new Enrollment();
                                enrollment1.CourseId = id;
                                enrollment1.UserId = user.UserId;
                                System.Console.WriteLine("Enter Enrollment status ");
                                string status = Console.ReadLine();
                                enrollment1.Status = status;

                                enrollment1.EnrollmentDate = DateTime.Now;
                                enrollment1.Title = (string)row["Title"];
                                int result = enrollmentRepository.EnrollInNewCourse(enrollment1);
                                if (result > 0)
                                {
                                    System.Console.WriteLine("You are successfully Enrolled");
                                }
                                else
                                {
                                    System.Console.WriteLine("Sorry there is something wrong");
                                }






                            }
                        }

                        break;

                    case 4:
                        System.Console.WriteLine("----------------Materials--------------");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Following are your Enrolled  courses.");
                        DataSet dataSet5 = new DataSet();
                        int userid2 = user.UserId;
                        dataSet5 = enrollmentRepository.EnrolledCourses(userid2);
                        if (dataSet5.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses");
                        }
                        else
                        {
                            foreach (DataRow row in dataSet5.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Enrollment Id :- {row["EnrollmentId"]} UserId:- {row["UserId"]} CourseId:- {row["CourseId"]} Title:- {row["Title"]} Enrolled Date :- {row["EnrollmentDate"]} Status :- {row["Status"]}");
                            }
                        }


                        System.Console.WriteLine("Enter the courseId which you want the material ");
                        int material = Convert.ToInt32(Console.ReadLine());
                        MaterialRepository materialRepository = new MaterialRepository();


                        ds = materialRepository.GetCourseMaterialById(material);

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("There is no any material ");

                        }
                        else
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"MaterialId:- {row["MaterialId"]} Title:- {row["Title"]} Description :- {row["Description"]} URL:- {row["URL"]}");
                            }

                        }



                        break;

                    case 5:
                        System.Console.WriteLine("Enquiry Regarding Course");


                        //  System.Console.WriteLine();
                        //  dataSet4 = new DataSet();
                        //  userid = user.UserId;
                        // dataSet4 = enrollmentRepository.EnrolledCourses(userid);


                        System.Console.WriteLine();

                        DataSet dataSet6 = new DataSet();
                        int userid3 = user.UserId;
                        dataSet6 = enrollmentRepository.EnrolledCourses(userid3);
                        if (dataSet6.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses the you have enrolled");
                        }
                        else
                        {
                            System.Console.WriteLine("Following are your Enrolled  courses.");
                            foreach (DataRow row in dataSet6.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Enrollment Id :- {row["EnrollmentId"]} UserId:- {row["UserId"]} CourseId:- {row["CourseId"]} Title:- {row["Title"]} Enrolled Date :- {row["EnrollmentDate"]} Status :- {row["Status"]}");
                            }
                        }

                        System.Console.WriteLine("Enter the course id which you want to do enquiry");
                        int courseid6 = Convert.ToInt32(Console.ReadLine());

                        dataSet6 = new DataSet();
                        dataSet6 = enrollmentRepository.EnrolledCourses(user.UserId);

                        if (dataSet6.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow row in dataSet6.Tables[0].Rows)
                            {
                                if (courseid6 == (int)row["CourseId"])
                                {

                                    EnquiryRepository enquiryRepository = new EnquiryRepository();
                                    Enquiry enquiry = new Enquiry();

                                    enquiry.UserId = user.UserId;
                                    enquiry.CourseId = courseid6;
                                    System.Console.WriteLine("Enter the subject of the enquiry");
                                    string sub = Console.ReadLine();
                                    System.Console.WriteLine("Enter the Message ");
                                    string msg = Console.ReadLine();
                                    enquiry.Subject = sub;
                                    enquiry.Message = msg;

                                    // enquiry.EnquiryDate = DateTime.Now;
                                    System.Console.WriteLine("Enter the Status ");
                                    string sts = Console.ReadLine();
                                    System.Console.WriteLine("Enter the Response ");
                                    string response = Console.ReadLine();
                                    enquiry.Status = sts;
                                    enquiry.Response = response;

                                    int res = enquiryRepository.AddEnquiry(enquiry);
                                    if (res > 0)
                                    {
                                        System.Console.WriteLine("Enquiry successfully submited ");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Failed to submit enquiry ");
                                    }


                                }

                            }

                        }













                        break;



                    case 6:
                        System.Console.WriteLine("Give Feedback");

                        System.Console.WriteLine();

                        dataSet6 = new DataSet();
                        userid3 = user.UserId;
                        dataSet6 = enrollmentRepository.EnrolledCourses(userid3);
                        if (dataSet6.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Sorry !! currently there is now any available courses the you have enrolled");
                        }
                        else
                        {
                            System.Console.WriteLine("Following are your Enrolled  courses.");
                            foreach (DataRow row in dataSet6.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Enrollment Id :- {row["EnrollmentId"]} UserId:- {row["UserId"]} CourseId:- {row["CourseId"]} Title:- {row["Title"]} Enrolled Date :- {row["EnrollmentDate"]} Status :- {row["Status"]}");
                            }
                        }

                        FeedbackRepository feedbackRepository = new FeedbackRepository();
                        FeedBack feedBack = new FeedBack();
                        User user3 = new User();

                        System.Console.WriteLine("Enter the coure id in which you want to give feedback");
                        int courseid = Convert.ToInt32(Console.ReadLine());

                        feedBack.CourseId = courseid;
                        feedBack.Date = DateTime.Now;
                        feedBack.UserId = user.UserId;
                        System.Console.WriteLine("Enter you feedback");
                        string feed = Console.ReadLine();
                        feedBack.FeedMessage = feed;

                        int result3 = feedbackRepository.AddFeedback(feedBack, user);
                        if (result3 == 0)
                        {
                            System.Console.WriteLine("your feedback is not submitted");

                        }
                        else
                        {
                            System.Console.WriteLine("Thanks for your feedback ");

                        }






                        break;


                    case 7:

                        FeedbackRepository feedbackRepository1 = new FeedbackRepository();
                        FeedBack feedBack1 = new FeedBack();
                        ds = feedbackRepository1.getFeedbacksByUserId(user.UserId);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            System.Console.WriteLine("Currently you have not give any feedback ");
                        }

                        else
                        {
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                System.Console.WriteLine($"Title :- {row["title"]}  Feedback :- {row["feedback"]}");
                            }
                        }


                        break;

                    default:
                        System.Console.WriteLine("Please Press from 1 to 5 ");

                        break;
                }
                Console.WriteLine("Do you want to continue? Y/N");
                reply = Convert.ToChar(Console.ReadLine());
                if (reply == 'Y' || reply == 'y')
                    Continue = true;
                else if (reply == 'N' || reply == 'n')
                {
                    Environment.Exit(0);
                }


            }



        }


        public static void Mycourses(int CourseId)
        {






        }
    }
}
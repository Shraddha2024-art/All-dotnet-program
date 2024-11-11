using System.Data;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository
{
    class CourseRepository : ICourseRepository
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;

        static DataTable dt;
        public CourseRepository()
        {
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            con = new SqlConnection(connection);
            //  Console.WriteLine("Connection established successfully!");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }




        public int AddCourse(Course course)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into Courses(Title,Description,userid,CourseStartDate,CourseEndDate,Category,Level) values (@Title,@Description,@userid,@CourseStartDate,@CourseEndDate,@Category,@Level)";

                cmd.Parameters.AddWithValue("@Title", course.Title);
                cmd.Parameters.AddWithValue("@Description", course.Description);
                cmd.Parameters.AddWithValue("@CourseStartDate", course.CourseStartDate);
                cmd.Parameters.AddWithValue("@CourseEndDate", course.CourseEndDate);
                 cmd.Parameters.AddWithValue("@UserId", course.UserId);
                cmd.Parameters.AddWithValue("@Category", course.Category);
                cmd.Parameters.AddWithValue("@Level", course.Level);

                con.Open();
                int result = cmd.ExecuteNonQuery();//insert update delete
                con.Close();
                return result;
            }

            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return 0;

        }

        public DataSet GetAllCourses()
        {
            string sql = "select * from Courses";
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

       

        public int updateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public DataSet GetCourseByUser(int userid)
        {
              
           
            da = new SqlDataAdapter();
            cmd.Parameters.Clear();
            cmd.CommandText = "select CourseId, Title,Description,CourseStartDate,CourseEndDate,UserId,Category,Level from Courses where UserId=@userid";
            cmd.Parameters.AddWithValue("@UserId", userid);
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
 
    }
}
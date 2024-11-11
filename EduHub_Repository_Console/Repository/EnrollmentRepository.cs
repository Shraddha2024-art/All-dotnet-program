using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
 using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository{
    internal class EnrollmentRepository: IEnrollmentRepository
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static DataSet ds;
        public static DataTable dt;
 
        public EnrollmentRepository(){
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
 
        public DataSet EnrolledCourses(int userid)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Select courseid,title,userid,enrollmentid,enrollmentdate,status from enrollment";
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.SelectCommand=cmd;
 
            da.Fill(ds);
            return ds;
        }
 
        public int EnrollInNewCourse(Enrollment enroll)
        {
        
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into Enrollment (userid,courseid,title,enrollmentdate,status) values(@userid,@courseid,@title,@enrollmentdate,@status)";

            cmd.Parameters.AddWithValue("@userid",enroll.UserId);
            cmd.Parameters.AddWithValue("@courseid",enroll.CourseId);
            cmd.Parameters.AddWithValue("@title",enroll.Title);
            cmd.Parameters.AddWithValue("@enrollmentdate",enroll.EnrollmentDate);
            cmd.Parameters.AddWithValue("@status",enroll.Status);  
 
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
 
        }

        public DataSet ShowAvailableCourses()
        {
          cmd.Parameters.Clear();
           cmd.CommandText="select CourseId,Title,CourseStartDate,CourseEndDate from Courses";
           da=new SqlDataAdapter();
           ds=new DataSet();
           da.SelectCommand = cmd;
           da.Fill(ds);
           return ds;

        }

        public DataSet StudentInCourse(int courseId)
        {
           cmd.Parameters.Clear();
           cmd.CommandText="select EnrollmentId,UserId,Title,EnrollmentDate,Status from Enrollment where courseId=@courseId";
           cmd.Parameters.AddWithValue("@courseId", courseId);
           da=new SqlDataAdapter();
           ds=new DataSet();
           da.SelectCommand = cmd;
           da.Fill(ds);
           return ds;
        }
 
        public int UnEnrollCourse(User user)
        {
            throw new NotImplementedException();
        }
    }
}
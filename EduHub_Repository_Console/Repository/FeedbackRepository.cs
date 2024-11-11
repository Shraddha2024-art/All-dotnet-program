using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using EduHub_Repository_Console_Project.Models;


namespace EduHub_Repository_Console_Project.Repository
{
    class FeedbackRepository : IFeedbackRepository
    {
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        SqlConnection con;
        public FeedbackRepository()
        {
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            con = new SqlConnection(connection);
            if (con != null)
            {
                System.Console.WriteLine(con.State);
            }
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public int AddFeedback(FeedBack feedBack, User user)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "insert into feedback (UserId,Feedback,Date,CourseId,username) values(@userid,@feedMessage,@date,@courseid,@username)";
            cmd.Parameters.AddWithValue("@userid", feedBack.UserId);
            cmd.Parameters.AddWithValue("@feedMessage", feedBack.FeedMessage);
            cmd.Parameters.AddWithValue("@date", feedBack.Date);
            cmd.Parameters.AddWithValue("@courseid", feedBack.CourseId);
            cmd.Parameters.AddWithValue("@username", user.UserName);
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public DataSet getAllFeedbacks()
        {
            throw new NotImplementedException();
        }

        public DataSet getFeedbacksByUserId(int userId)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select u.username,c.title,f.feedback from Feedback f join users u on f.UserId=u.Userid join Courses c on f.CourseId=c.CourseId where f.UserId=@userid";
            cmd.Parameters.AddWithValue("@userid", userId);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet getFeedbacksByCourseId(int courseId)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select u.username,c.title,f.feedback from Feedback f join users u on f.UserId=u.Userid join Courses c on f.CourseId=c.CourseId where f.CourseId=@courseid";
            cmd.Parameters.AddWithValue("@courseid", courseId);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
}
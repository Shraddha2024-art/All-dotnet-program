using System.Data;
using System.Data.SqlClient;
using EduHub_Repository_Console_Project.Models;

namespace EduHub_Repository_Console_Project.Repository
{
    internal class EnquiryRepository : IEnquiryRepository
    {
        public static SqlDataAdapter da;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static DataSet ds;

        public EnquiryRepository()
        {
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            con = new SqlConnection(connection);
            //  Console.WriteLine("Connection established successfully!");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public int AddEnquiry(Enquiry enquiry)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Insert into Enquiry(userid,courseid,subject,message,enquirydate,status,response) values(@UserId,@CourseId,@Subject,@Message,@EnquiryDate,@status,@Response)";
            cmd.Parameters.AddWithValue("@userid", enquiry.UserId);
            cmd.Parameters.AddWithValue("@courseid", enquiry.CourseId);
            cmd.Parameters.AddWithValue("@subject", enquiry.Subject);
            cmd.Parameters.AddWithValue("@message", enquiry.Message);
            cmd.Parameters.AddWithValue("@enquirydate", DateTime.Now);
            cmd.Parameters.AddWithValue("@status", enquiry.Status);
            cmd.Parameters.AddWithValue("@response", enquiry.Response);

            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }


        public DataSet ViewEnquiryByCourseId(int courseid)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select enquiryid,userid,courseid,subject,message,status,response from enquiry where courseid = @courseid";
            cmd.Parameters.AddWithValue("@courseid", courseid);
            da = new SqlDataAdapter();
            ds = new DataSet();

            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds;
        }

        public DataSet ViewEnquiryByEnquiryID(int enquiryId)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select enquiryid,userid,courseid,subject,message from enquiry where enquiryid = @enquiryId";
            cmd.Parameters.AddWithValue("@enquiryid", enquiryId);
            da = new SqlDataAdapter();
            ds = new DataSet();

            da.SelectCommand = cmd;
            da.Fill(ds);

            return ds;
        }
    }
}

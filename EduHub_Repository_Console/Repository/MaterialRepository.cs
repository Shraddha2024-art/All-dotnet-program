using System.Data;
using System.Data.SqlClient;
 
 using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository{
    internal class MaterialRepository : IMaterialRepository
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static DataSet ds;
 
        public MaterialRepository(){
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
 
        public DataSet GetCourseMaterialById(int courseid)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "select materialid,title,description,url,contenttype from material where courseid=@courseid";
            cmd.Parameters.AddWithValue("@courseid",courseid);
            da = new SqlDataAdapter();
            ds = new DataSet();
 
            da.SelectCommand = cmd;
            da.Fill(ds);
 
            return ds;
 
        }
 
        public int AddCourseMaterialById(Material material)
        {
            cmd.Parameters.Clear();
            cmd.CommandText = "Insert into Material(courseid,title,description,URL,uploaddate,contenttype) values(@CourseId,@Title,@Description,@URL,@UploadDate,@ContentType)";
            cmd.Parameters.AddWithValue("@courseid",material.CourseId);
            cmd.Parameters.AddWithValue("@title",material.Title);
            cmd.Parameters.AddWithValue("@description",material.Description);
            cmd.Parameters.AddWithValue("@URL",material.URL);
            cmd.Parameters.AddWithValue("@uploaddate",material.UploadDate);
            cmd.Parameters.AddWithValue("@contenttype",material.ContentType);
 
            da = new SqlDataAdapter();
            ds = new DataSet();
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
 
            return result;
        }
 
       
 
        public int UpdateMaterial(Material material)
        {
            throw new NotImplementedException();
        }
    }
}
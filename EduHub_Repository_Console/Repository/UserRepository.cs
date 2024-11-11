using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository
{
    class UserRepository : IUserRepository
    {

        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;

        static DataTable dt;
        public UserRepository()
        {
            string connection = "Data Source=YISC1101247LT\\SQLEXPRESS;initial catalog=Demo;integrated security=true;trustservercertificate=true";
            con = new SqlConnection(connection);
            //  Console.WriteLine("Connection established successfully!");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public int AddUser(User newuser)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "Insert into users(username,password,email,mobilenumber,userrole,profileimage) values (@username,@password,@email,@mobilenumber,@userrole,@profileimage)";

                cmd.Parameters.AddWithValue("@username", newuser.UserName);
                cmd.Parameters.AddWithValue("@password", newuser.Password);
                cmd.Parameters.AddWithValue("@email", newuser.Email);
                cmd.Parameters.AddWithValue("@mobilenumber", newuser.MobileNumber);
                cmd.Parameters.AddWithValue("@userrole", newuser.UserRole);
                cmd.Parameters.AddWithValue("@profileimage", newuser.ProfileImage);

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

        public DataSet GetAllStudents()
        {

            string sql = "select UserId,Username,Email,mobilenumber,userrole,profileimage from Users where userrole=" + "'Student'";
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;


            //     cmd.CommandText = "select UserId,UserName,Email,MobileNumber,UserRole,ProfileImage" + "from Users where UserRole=" + "'Student'";
            //     da = new SqlDataAdapter();
            //     da.SelectCommand = cmd;
            //    // ds = new DataSet();
            //     da.Fill(ds);
            //     return ds;
        }

        public DataSet GetAllTeachers()
        {
            string sql = "select UserId,Username,Email,mobilenumber,userrole,profileimage from Users where userrole=" + "'Educator'";
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds);
            return ds;




            //         cmd.CommandText = "select UserId,UserName,Email,MobileNumber,UserRole,ProfileImage" + "from Users where UserRole=" + "'Educator'";
            //         da = new SqlDataAdapter();
            //         da.SelectCommand = cmd;
            //    //     ds = new DataSet();
            //         da.Fill(ds);
            //         return ds;
        }

        public int GetNewUserId()
        {
            throw new NotImplementedException();
        }

        public User Login(string UserName, string Password)
        {
            User loginuser = new User();
            cmd.Parameters.Clear();
            cmd.CommandText = "select UserId, UserName, Password, Email, MobileNumber,UserRole from Users where UserName=@UserName and Password=@Password";
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            da = new SqlDataAdapter();
            ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dt = ds.Tables[0];
            if (dt.Rows.Count == 1)
            {
                loginuser.UserId = (int)dt.Rows[0]["UserId"];
                loginuser.UserName = dt.Rows[0]["UserName"].ToString();
                loginuser.Password = dt.Rows[0]["Password"].ToString();
                loginuser.Email = dt.Rows[0]["Email"].ToString();
                loginuser.MobileNumber = dt.Rows[0]["MobileNumber"].ToString();
                loginuser.UserRole =dt.Rows[0]["UserRole"].ToString();
                return loginuser;

            }
            else
            {
                return loginuser;
            }
        }

        public int updateProfile(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string UserName)
        {
            bool isdata;
            cmd.Parameters.Clear();
            cmd.CommandText = "select UserId from Users where UserName=@UserName";

            cmd.Parameters.AddWithValue("@UserName", UserName);
            con.Open();
            dr = cmd.ExecuteReader();
            isdata = dr.Read();
            System.Console.WriteLine(isdata);
            con.Close();
            if (isdata)
            {
                //System.Console.WriteLine(dr[0]);
                return true;
            }
            else
            {
                return false;
            }
        }
        // public int AddUser(User newuser)
        // {
        //     try
        //     {
        //     }
        //     return 0;
        // }
    }
}
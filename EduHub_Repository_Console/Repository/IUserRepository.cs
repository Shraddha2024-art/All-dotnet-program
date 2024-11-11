using EduHub_Repository_Console_Project.Models;
using System.Data;
namespace EduHub_Repository_Console_Project.Repository
{
    interface IUserRepository
    {

        DataSet GetAllTeachers();
        DataSet GetAllStudents();
        int updateProfile(User user);

        bool UserExists(string username);
        int AddUser(User newuser);

        int GetNewUserId();

        User Login(string username, string passward);

    }
}

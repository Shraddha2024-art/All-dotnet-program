
using EduHub_Repository_Console_Project.Models;
using System.Data;
namespace EduHub_Repository_Console_Project.Repository
{
    interface ICourseRepository
    {
        DataSet GetAllCourses();
        Course GetCourseById(int id);
        DataSet GetCourseByUser(int userid);
        int AddCourse(Course course);
        int updateCourse(Course course);
         
         
    }
}

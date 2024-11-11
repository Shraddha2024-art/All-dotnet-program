using System;
using System.Data;
using System.Runtime.InteropServices;
using EduHub_Repository_Console_Project.Models;

namespace EduHub_Repository_Console_Project.Repository
{
    internal interface IEnrollmentRepository
    {

        DataSet ShowAvailableCourses();

        int EnrollInNewCourse(Enrollment enrollment);

        int UnEnrollCourse(User user);
        DataSet EnrolledCourses(int userid);
        DataSet StudentInCourse(int courseId);
    }
}
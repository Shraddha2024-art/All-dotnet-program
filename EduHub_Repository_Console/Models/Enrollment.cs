using System;

namespace EduHub_Repository_Console_Project.Models
{
    internal class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string CourseName { get; set; }
    }
}
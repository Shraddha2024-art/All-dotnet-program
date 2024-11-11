using System;
using System.Data;
using EduHub_Repository_Console_Project.Models;
namespace EduHub_Repository_Console_Project.Repository
{
    interface IFeedbackRepository
    {

        int AddFeedback(FeedBack feedBack, User user);
        DataSet getFeedbacksByUserId(int userId);
        DataSet getAllFeedbacks();
 
        DataSet getFeedbacksByCourseId(int courseId);
        
    }
}
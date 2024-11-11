using System.Data;

using EduHub_Repository_Console_Project.Models;
 
namespace EduHub_Repository_Console_Project.Repository{
    internal interface IEnquiryRepository{
        int AddEnquiry(Enquiry enquiry);
        DataSet ViewEnquiryByCourseId(int courseid);
        DataSet ViewEnquiryByEnquiryID(int enquiryId);
 
        // int updateEnquiryByEnquiryID(Enquiry enquiry);
        // DataSet getEnquiryByUserId(int userId);
        //    DataSet getAllEnquiry();
    }
}
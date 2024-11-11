namespace EduHub_Repository_Console_Project.Models
{
      internal class FeedBack{  public  int FeedbackId { get; set; }
        public int UserId { get; set; }
        public string FeedMessage { get; set; }
        public DateTime Date { get; set; }
        public int CourseId { get; set; }
     
    }
}
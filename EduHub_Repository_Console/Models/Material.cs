namespace EduHub_Repository_Console_Project.Models
{
    internal class Material
    {
 
        public int MaterialId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public DateTime UploadDate { get; set; }
        public string ContentType { get; set; }
    }
}
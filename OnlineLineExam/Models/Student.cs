namespace OnlineLineExam.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public long MobileNumber { get; set; }
        public string? CVFileName { get; set; }
        public string? PictureFileName  { get; set; }
        public int GroupsId { get; set; }
        public Groups? Groups { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; } = new HashSet<ExamResult>();
    }
}

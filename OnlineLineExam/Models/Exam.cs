namespace OnlineLineExam.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public int Time { get; set; }
        public int GroupId { get; set; }
        public Groups? Groups { get; set; }
        public ICollection<ExamResult>? ExamResults { get; set; } = new HashSet<ExamResult>();

        public ICollection<QandAns> QandAnswers { get; set; }= new HashSet<QandAns>();

    }
}

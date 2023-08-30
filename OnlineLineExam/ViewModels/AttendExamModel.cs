namespace OnlineLineExam.ViewModels
{
    public class AttendExamModel
    {
        public int StudentId { get; set; }
        public string? ExamName { get; set; }
        public List<AttendExamModel>? QandAnslIST { get; set; }
        public string? message { get; set; }
    }
}

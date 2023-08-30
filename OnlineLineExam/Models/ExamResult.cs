namespace OnlineLineExam.Models
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int studentId { get; set; }
        public Student? student { get; set; }
        public int ExamId { get; set; }
        public Exam? Exam { get; set; }
        public int QansAnsId { get; set; }
        public QandAns? Qns { get; set; }
        public int Ans { get; set; }

    }
}

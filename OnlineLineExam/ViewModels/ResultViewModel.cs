namespace OnlineLineExam.ViewModels
{
    public class ResultViewModel
    {
        public int StudnetId { get; set; }
        public string? ExamName { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }

    }
}

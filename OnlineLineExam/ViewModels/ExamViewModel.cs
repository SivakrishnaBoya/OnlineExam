using OnlineLineExam.Models;

namespace OnlineLineExam.ViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public int Time { get; set; }
        public int GroupId { get; set; }
        public List<ExamViewModel> ExamList { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<Groups> groupsList { get; set; }
        public ExamViewModel (Exam Ex)
        {
            Id = Ex.Id;
            Title = Ex.Title;
            Description=Ex.Description;
            StartTime= Ex.StartTime;
            Time = Ex.Time;
            GroupId = Ex.GroupId;
            
        }
        public Exam ConvertViewModel(ExamViewModel ex)
        {
            return new Exam
            {
                    Id=ex.Id,
                    Title=ex.Title,
                    Description=ex.Description,
                    StartTime=ex.StartTime,
                    Time=ex.Time,
                    GroupId=ex.GroupId,
            };
        }
    }
}

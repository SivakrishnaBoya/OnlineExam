using OnlineLineExam.Models;
using System.ComponentModel.DataAnnotations;

namespace OnlineLineExam.ViewModels
{
    public class QAndAnsViewModel
    {
        public int Id { get; set; }
        [Required]
        public int ExamId { get; set; }
        [Required]
        public string? Questions { get; set; }
        [Required]
        public int Answer { get; set; }
        [Required]
        public string? Option1 { get; set; }
        [Required]
        public string? Option2 { get; set; }
        [Required]
        public string? Option3 { get; set; }
        [Required]
        public string? Option4 { get; set; }
        public List<QAndAnsViewModel>? QandAnsList { get; set; }
        public IEnumerable<Exam>? ExamList { get; set; }
        public int TotalCount { get; set; }
        public int SelectedAns { get; set; }

        public QAndAnsViewModel( QandAns qandans)
        {
            Id = qandans.Id;
            ExamId = qandans.ExamId;
            Questions = qandans.Questions;
            Answer = qandans.Answer;
            Option1 = qandans.Option1;
            Option2 = qandans.Option2;
            Option3 = qandans.Option3;
            Option4 = qandans.Option4;

        }

        public QandAns ConvertViewModel(QAndAnsViewModel model)
        {
            return new QandAns
            {
                Id = model.Id,
            ExamId = model.ExamId,
            Questions = model.Questions,
            Answer = model.Answer,
            Option1 =model.Option1,
            Option2 = model.Option2,
            Option3 = model.Option3,
            Option4 = model.Option4

        };
        }
    }
}

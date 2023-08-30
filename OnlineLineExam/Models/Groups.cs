using System.Collections;

namespace OnlineLineExam.Models
{
    public class Groups
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public User? Users { get; set; }
        public ICollection<Student>? Student { get; set; } = new HashSet<Student>();
        public ICollection<Exam>? Exams { get; set; } = new HashSet<Exam>();

    }
}

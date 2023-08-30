using OnlineLineExam.Models;

namespace OnlineLineExam.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public long MobileNumber { get; set; }
        public string? CVFileName { get; set; }
        public string? PictureFileName { get; set; }
        public int GroupsId { get; set; }
        public IFormFile Cvfile { get; set; }
        public IFormFile Picturefile { get; set; }
        public int TotalStudents { get; set; }
        public List<StudentViewModel> StudentList { get; set; }

        public StudentViewModel(Student st)
        {
            Id = st.Id;
            Name = st.Name;
            UserName = st.UserName;
            Password = st.Password;
            MobileNumber = st.MobileNumber;
            CVFileName = st.CVFileName;
            PictureFileName = st.PictureFileName;
            GroupsId = st.GroupsId;


        }
        public Student ConvertViewModel(Student student)
        {
            return new Student
            {
                Id = student.Id,
                Name = student.Name,
                UserName = student.UserName,
                Password = student.Password,
                MobileNumber = student.MobileNumber,
                CVFileName = student.CVFileName,
                PictureFileName = student.PictureFileName,
            GroupsId = student.GroupsId
        };
        }
    }
}

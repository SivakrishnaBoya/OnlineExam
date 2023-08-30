using OnlineLineExam.ViewModels;

namespace OnlineLineExam.AccountServices
{
    public interface IAccountService
    {
        LogInViewModel logIn(LogInViewModel logIn);
        bool AddTeacher(UsersViewModel UVM);
        Pages<UsersViewModel> GetAllTeachers(int pagenumber,int pagesize);
    }
}

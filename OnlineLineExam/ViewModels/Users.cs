using OnlineLineExam.Models;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace OnlineLineExam.ViewModels
{
    public class UsersViewModel
    {

        public UsersViewModel( User users)
        {
            Id = users.Id;
            Name = users.Name;
            UserName = users.UserName;
            Password = users.Password;
            Role = users.Role;
        }
        public User CovertingViewModel(UsersViewModel U)
        {
            return new User
            {
                Id = U.Id,
                Name = U.Name,
            UserName = U.UserName,
            Password = U.Password,
            Role = U.Role

        };
        }
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
 
        public string? Password { get; set; }
        [Required]

        public string? Role { get; set; }
    }
}

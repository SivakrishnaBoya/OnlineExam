using OnlineLineExam.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace OnlineLineExam.ViewModels
{
    public class GroupsViewModel
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int UserId { get; set; }
        public List<GroupsViewModel>? GroupList { get; set; }
        public int TotalCount { get; set; }
        public GroupsViewModel(Groups groups)
        {
            Id = groups.Id;
            Name = groups.Name;
            Description = groups.Description;
            UserId = groups.UserId;

            
        }
        public Groups CovertingViewModel(GroupsViewModel model)
        {
            return new Groups
            {
                Id = model.Id,
            Name = model.Name,
            Description = model.Description,
            UserId = model.UserId
        };
        }

    }
}

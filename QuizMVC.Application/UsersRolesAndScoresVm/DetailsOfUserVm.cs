using AutoMapper;
using QuizMVC.Application.Mapping;
using System.Collections.Generic;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class DetailsOfUserVm : IMapFrom<QuizMVC.Domain.Model.ApplicationUser>
    {
        public string UserName { get; set; }
        public List<ApplicationUserRoleVm> UserRoles { get; set; }
        public List<ApplicationRoleVm> AllRoles { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.ApplicationUser, DetailsOfUserVm>();
        }
    }
}

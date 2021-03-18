using AutoMapper;
using QuizMVC.Application.Mapping;
using QuizMVC.Domain.Model;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class ApplicationUserRoleVm : IMapFrom<QuizMVC.Domain.Model.ApplicationUserRole>
    {
        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.ApplicationUserRole, ApplicationUserRoleVm>();
        }

    }
}

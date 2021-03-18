using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class ApplicationRoleVm : IMapFrom<QuizMVC.Domain.Model.ApplicationRole>
    {
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.ApplicationRole, ApplicationRoleVm>();
        }
    }
}

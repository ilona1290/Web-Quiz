using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class AddAndEditCategoryAdminVm : IMapFrom<QuizMVC.Domain.Model.Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAccepted { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddAndEditCategoryAdminVm, QuizMVC.Domain.Model.Category>().ReverseMap();
        }
    }
}

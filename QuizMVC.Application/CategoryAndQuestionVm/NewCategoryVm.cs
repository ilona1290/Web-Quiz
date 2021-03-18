using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.CategoryAndQuestionVm
{
    public class NewCategoryVm : IMapFrom<QuizMVC.Domain.Model.Category>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCategoryVm, QuizMVC.Domain.Model.Category>();
        }
    }
}

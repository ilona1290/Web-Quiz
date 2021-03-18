using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class QuestionToListAdminVm : IMapFrom<QuizMVC.Domain.Model.Question>
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string CategoryText { get; set; }
        public bool IsAccepted { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.Question, QuestionToListAdminVm>()
                .ForMember(d => d.CategoryText, opt => opt.MapFrom(s => s.Category.Name));
        }
    }
}

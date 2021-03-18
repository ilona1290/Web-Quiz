using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class AnswerToAdminVm : IMapFrom<QuizMVC.Domain.Model.Answer>
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public int QuestionId { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsCorrect { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.Answer, AnswerToAdminVm>().ReverseMap();
        }
    }
}

using AutoMapper;
using QuizMVC.Application.Mapping;
using System.Collections.Generic;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class DetailsOfQuestionAdminVm : IMapFrom<QuizMVC.Domain.Model.Question>
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string CategoryText { get; set; }
        public bool IsAccepted { get; set; }
        public List<AnswerToAdminVm> Answers { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.Question, DetailsOfQuestionAdminVm>().ReverseMap();
        }
    }
}

using AutoMapper;
using QuizMVC.Application.Mapping;
using System.Collections.Generic;

namespace QuizMVC.Application.CategoryAndQuestionVm
{
    public class QuestionVm : IMapFrom<QuizMVC.Domain.Model.Question>
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Category { get; set; }
        public int IdOfSelectedAnswer { get; set; }
        public List<AnswerVm> Answers { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.Question, QuestionVm>()
                .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category.Name));
            //Zmapowanie listy z odpowiedziami
            profile.CreateMap<QuizMVC.Domain.Model.Answer, AnswerVm>();
        }
    }
}

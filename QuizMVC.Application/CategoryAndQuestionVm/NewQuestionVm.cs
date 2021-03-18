using AutoMapper;
using QuizMVC.Application.Mapping;
using System.Collections.Generic;

namespace QuizMVC.Application.CategoryAndQuestionVm
{
    public class NewQuestionVm : IMapFrom<QuizMVC.Domain.Model.Question>
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int CategoryId { get; set; }
        public ListOfCategoriesVm Categories { get; set; }
        public List<AnswerVm> Answers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewQuestionVm, QuizMVC.Domain.Model.Question>();
            profile.CreateMap<AnswerVm, QuizMVC.Domain.Model.Answer>();
        }
    }
}

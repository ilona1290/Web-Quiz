using AutoMapper;
using QuizMVC.Application.Mapping;
using System.Collections.Generic;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class AddAndEditQuestionAndAnswerAdminVm : IMapFrom<QuizMVC.Domain.Model.Question>
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int CategoryId { get; set; }
        public bool IsAccepted { get; set; }
        public ListOfCategoriesAdminVm Categories { get; set; }
        public List<AnswerToAdminVm> Answers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddAndEditQuestionAndAnswerAdminVm, QuizMVC.Domain.Model.Question>().ReverseMap();
            profile.CreateMap<AnswerToAdminVm, QuizMVC.Domain.Model.Answer>().ReverseMap();
        }
    }
}

using AutoMapper;
using QuizMVC.Application.Mapping;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class ScoreVm : IMapFrom<QuizMVC.Domain.Model.Score>
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public int BestResult { get; set; }
        public int Place { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<QuizMVC.Domain.Model.Score, ScoreVm>().ReverseMap();
        }
    }
}

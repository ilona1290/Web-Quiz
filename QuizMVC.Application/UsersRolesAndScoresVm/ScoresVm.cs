using System.Collections.Generic;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class ScoresVm
    {
        public List<ScoreVm> BestResults { get; set; }
        public int Count { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
    }
}

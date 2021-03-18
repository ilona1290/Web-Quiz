using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMVC.Application.StatsVm
{
    public class OtherStatsVm
    {
        public int NumberOfUsersWhoAnsweredToAllQuestions { get; set; }
        public List<string> UsersWhoAnsweredToAllQuestions { get; set; }
        public string QuestionOnWhichTheMostUsersAnsweredGood { get; set; }
        public string QuestionOnWhichTheLeastUsersAnsweredGood { get; set; }
    }
}

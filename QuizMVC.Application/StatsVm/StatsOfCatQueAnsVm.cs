using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMVC.Application.StatsVm
{
    public class StatsOfCatQueAnsVm
    {
        public int AmountOfCategories{ get; set; }
        public int AmountOfQuestions { get; set; }
        public int AmountOfAnswers { get; set; }
        public int AmountOfGoodAnswers { get; set; }
        public int AmountOfNonAcceptedCategories { get; set; }
        public int AmountOfNonAcceptedQuestions { get; set; }
        public int AmountOfNonAcceptedAnswers { get; set; }
        public string CategoryWithTheFewestQuestions { get; set; }
        public string CategoryWithTheMostQuestions { get; set; }
    }
}

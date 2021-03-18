using QuizMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizMVC.Domain.Interface
{
    public interface IStatsRepository
    {
        int GetAmountOfCategories();
        int GetAmountOfQuestions();
        int GetAmountOfAnswers();
        int GetAmountOfGoodAnswers();
        int GetAmountOfNonAcceptedCategories();
        int GetAmountOfNonAcceptedQuestions();
        int GetAmountOfNonAcceptedAnswers();
        IQueryable<CategoryWithEveryQuestionsRespondedCorrectlyByUser> GetUsersWhichAnsweredOnEveryQuestion();
        IQueryable<QuestionsOnWhichUsersRespondCorrectly> GetDataFromQuestionsWithCorrectlyRespondsTable();

    }
}

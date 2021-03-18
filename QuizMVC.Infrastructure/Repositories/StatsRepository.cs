using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizMVC.Infrastructure.Repositories
{
    public class StatsRepository : IStatsRepository
    {
        private readonly Context _context;

        public StatsRepository(Context context)
        {
            _context = context;
        }

        public int GetAmountOfAnswers()
        {
            int amount = _context.Answers.Count();
            return amount;
        }

        public int GetAmountOfCategories()
        {
            int amount = _context.Categories.Count();
            return amount;
        }

        public int GetAmountOfGoodAnswers()
        {
            int amount = _context.Answers.Where(a => a.IsCorrect == true).Count();
            return amount;
        }

        public int GetAmountOfNonAcceptedAnswers()
        {
            int amount = _context.Answers.Where(a => a.IsAccepted == false).Count();
            return amount;
        }

        public int GetAmountOfNonAcceptedCategories()
        {
            int amount = _context.Categories.Where(a => a.IsAccepted == false).Count();
            return amount;
        }

        public int GetAmountOfNonAcceptedQuestions()
        {
            int amount = _context.Questions.Where(a => a.IsAccepted == false).Count();
            return amount;
        }

        public int GetAmountOfQuestions()
        {
            int amount = _context.Questions.Count();
            return amount;
        }

        public IQueryable<CategoryWithEveryQuestionsRespondedCorrectlyByUser> GetUsersWhichAnsweredOnEveryQuestion()
        {
            var users = _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.AsQueryable();
            return users;
        }

        public IQueryable<QuestionsOnWhichUsersRespondCorrectly> GetDataFromQuestionsWithCorrectlyRespondsTable()
        {
            var data = _context.QuestionsWithCorrectlyResponds.AsQueryable();
            return data;
        }
    }
}

using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Infrastructure.Repositories
{
    public class CategoryAndQuestionRepository : ICategoryAndQuestionRepository
    {
        private readonly Context _context;
        public CategoryAndQuestionRepository(Context context)
        {
            _context = context;
        }

        public IQueryable<Category> GetAllAcceptedCategories()
        {
            var categories = _context.Categories.Where(c => c.IsAccepted == true);
            return categories;
        }
        public Category ReturnCategoryById(int idCategory)
        {
            var category = _context.Categories.Find(idCategory);
            return category;
        }
        public IQueryable<Question> GetQuestionsByCategoryId(int categoryId)
        {
            var questions = _context.Questions.Where(q => q.CategoryId == categoryId && q.IsAccepted == true);
            return questions;
        }
        public List<int> GetQuestionIdsWhichUserRespondCorrectly(string username)
        {
            var ids = _context.QuestionsWithCorrectlyResponds.Where(u => u.UserName == username)
                .Select(i => i.QuestionId).ToList();
            return ids;
        }
        public List<int> GetCategoryIdsWhichUserRespondCorrectlyOnItsQuestions(string username)
        {
            var ids = _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.Where(c => c.Username == username)
                .Select(i => i.CategoryId).ToList();
            return ids;
        }
        public Question GetQuestionById(int idQuestion)
        {
            var question = _context.Questions.Find(idQuestion);
            return question;
        }
        public IQueryable<Answer> ReturnAnswersByQuestionId(int idQuestion)
        {
            var answers = _context.Answers.Where(a => a.QuestionId == idQuestion);
            return answers;
        }
        public void SaveIdOfQuestionWhichUserRespondedCorrectly(QuestionsOnWhichUsersRespondCorrectly questionsOnWhichUsersRespondCorrectly)
        {
            _context.QuestionsWithCorrectlyResponds.Add(questionsOnWhichUsersRespondCorrectly);
            _context.SaveChanges();
        }
        public void AddCategoryWithAllGoodRespondsByUser(CategoryWithEveryQuestionsRespondedCorrectlyByUser categoryRespondedCorrectlyByUser)
        {
            _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.Add(categoryRespondedCorrectlyByUser);
            _context.SaveChanges();
        }
        public void SetGoodAnswer(Answer answer)
        {
            _context.Attach(answer);
            _context.Entry(answer).Property("IsCorrect").IsModified = true;
            _context.SaveChanges();
        }
        public Answer ReturnAnswerById(int idAnswer)
        {
            var answer = _context.Answers.Find(idAnswer);
            return answer;
        }
        public int AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category.Id;
        }

        public int AddQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question.Id;
        }

        public void DeleteCategoryFromFinishedCategories(int categoryId)
        {
            var categories = _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.Where(c => c.CategoryId == categoryId).ToList();
            foreach (var item in categories)
            {
                _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.Remove(item);
            }
            _context.SaveChanges();
        }
    }
}

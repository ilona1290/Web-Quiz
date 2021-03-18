using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Infrastructure.Repositories
{
    public class CategoryAndQuestionForAdminRepository : ICategoryAndQuestionForAdminRepository
    {
        private readonly Context _context;

        public CategoryAndQuestionForAdminRepository(Context context)
        {
            _context = context;
        }
        public IQueryable<Category> GetCategoriesForAdmin()
        {
            var categories = _context.Categories;
            return categories;
        }
        public Category ReturnCategoryById(int idCategory)
        {
            var category = _context.Categories.Find(idCategory);
            return category;
        }
        public int AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category.Id;
        }
        public void AcceptCategory(Category category)
        {
            _context.Attach(category);
            _context.Entry(category).Property("IsAccepted").IsModified = true;
            _context.SaveChanges();
        }
        public void DeleteCategory(int idCategory)
        {
            var category = _context.Categories.Find(idCategory);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            _context.Attach(category);
            _context.Entry(category).Property("Name").IsModified = true;
            _context.Entry(category).Property("IsAccepted").IsModified = true;
            _context.SaveChanges();
        }

        public IQueryable<Question> ShowQuestions()
        {
            var questions = _context.Questions;
            return questions;
        }
        public IQueryable<Answer> ReturnAnswersByQuestionId(int idQuestion)
        {
            var answers = _context.Answers.Where(a => a.QuestionId == idQuestion);
            return answers;
        }
        public Question ReturnDetailsOfQuestion(int idQuestion)
        {
            var question = _context.Questions.Find(idQuestion);
            return question;
        }
        public Answer ReturnAnswerById(int idAnswer)
        {
            var answer = _context.Answers.Find(idAnswer);
            return answer;
        }
        public void AcceptQuestion(Question question)
        {
            _context.Attach(question);
            _context.Entry(question).Property("IsAccepted").IsModified = true;
            _context.SaveChanges();
        }
        public void AfterAcceptNewQuestionRemoveItsCategoryFromUsedCategoriesToAllUser(int categoryId)
        {
            var categories = _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser
                .Where(c => c.CategoryId == categoryId).ToList();
            foreach (var item in categories)
            {
                _context.CategoriesWithEveryQuestionsRespondedCorrectlyByUser.Remove(item);
            }
            _context.SaveChanges();
        }
        public void AcceptAnswer(Answer answer)
        {
            _context.Attach(answer);
            _context.Entry(answer).Property("IsAccepted").IsModified = true;
            _context.SaveChanges();
        }

        public void DeleteQuestion(int idQuestion)
        {
            var question = _context.Questions.Find(idQuestion);
            if (question != null)
            {
                _context.Questions.Remove(question);
                _context.SaveChanges();
            }
        }
        public int DeleteAnswer(int idAnswer)
        {
            var answer = _context.Answers.Find(idAnswer);
            var questionIdOfRemovingAnswer = answer.QuestionId;
            if (answer != null)
            {
                _context.Answers.Remove(answer);
                _context.SaveChanges();
            }
            return questionIdOfRemovingAnswer;
        }
        public int AddQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question.Id;
        }
        public void AddExtraAnswer(Answer answer)
        {
            _context.Answers.Add(answer);
            _context.SaveChanges();
        }
        public void SetGoodAnswer(Answer answer)
        {
            _context.Attach(answer);
            _context.Entry(answer).Property("IsCorrect").IsModified = true;
            _context.SaveChanges();
        }
        public void UpdateQuestion(Question question)
        {
            _context.Attach(question);
            _context.Entry(question).Property("QuestionText").IsModified = true;
            _context.Entry(question).Property("CategoryId").IsModified = true;
            _context.Entry(question).Property("IsAccepted").IsModified = true;
            _context.SaveChanges();
        }
        public void UpdateAnswers(List<Answer> answers)
        {
            foreach (var item in answers)
            {
                _context.Answers.Attach(item);
                _context.Entry(item).Property("AnswerText").IsModified = true;
                _context.Entry(item).Property("IsCorrect").IsModified = true;
                _context.Entry(item).Property("IsAccepted").IsModified = true;
            }
            _context.SaveChanges();
        }
    }
}

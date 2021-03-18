using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Domain.Interface
{
    public interface ICategoryAndQuestionRepository
    {
        IQueryable<Category> GetAllAcceptedCategories();
        IQueryable<Question> GetQuestionsByCategoryId(int categoryId);
        Category ReturnCategoryById(int idCategory);
        Answer ReturnAnswerById(int idAnswer);
        void SaveIdOfQuestionWhichUserRespondedCorrectly(QuestionsOnWhichUsersRespondCorrectly questionsOnWhichUsersRespondCorrectly);
        void AddCategoryWithAllGoodRespondsByUser(CategoryWithEveryQuestionsRespondedCorrectlyByUser categoryRespondedCorrectlyByUser);
        void SetGoodAnswer(Answer answer);
        int AddCategory(Category category);
        int AddQuestion(Question question);
        void DeleteCategoryFromFinishedCategories(int categoryId);
        Question GetQuestionById(int idQuestion);
        List<int> GetQuestionIdsWhichUserRespondCorrectly(string username);
        List<int> GetCategoryIdsWhichUserRespondCorrectlyOnItsQuestions(string username);
        IQueryable<Answer> ReturnAnswersByQuestionId(int idQuestion);
    }
}

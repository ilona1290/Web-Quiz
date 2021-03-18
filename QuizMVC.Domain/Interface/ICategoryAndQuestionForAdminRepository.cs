using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Domain.Interface
{
    public interface ICategoryAndQuestionForAdminRepository
    {
        IQueryable<Category> GetCategoriesForAdmin();
        Category ReturnCategoryById(int idCategory);
        int AddCategory(Category category);
        void AcceptCategory(Category category);
        void DeleteCategory(int idCategory);
        void UpdateCategory(Category category);
        IQueryable<Question> ShowQuestions();
        IQueryable<Answer> ReturnAnswersByQuestionId(int idQuestion);
        Question ReturnDetailsOfQuestion(int idQuestion);
        Answer ReturnAnswerById(int idAnswer);
        void AcceptQuestion(Question question);
        void AfterAcceptNewQuestionRemoveItsCategoryFromUsedCategoriesToAllUser(int categoryId);
        void AcceptAnswer(Answer answer);
        void DeleteQuestion(int idQuestion);
        int DeleteAnswer(int idAnswer);
        int AddQuestion(Question question);
        void AddExtraAnswer(Answer answer);
        void SetGoodAnswer(Answer answer);
        void UpdateQuestion(Question question);
        void UpdateAnswers(List<Answer> answers);
    }
}

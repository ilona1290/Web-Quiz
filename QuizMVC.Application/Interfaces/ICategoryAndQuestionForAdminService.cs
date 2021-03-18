using QuizMVC.Application.CategoryAndQuestionForAdminVm;
using QuizMVC.Domain.Model;
using System.Collections.Generic;

namespace QuizMVC.Application.Interfaces
{
    public interface ICategoryAndQuestionForAdminService
    {
        ListOfCategoriesAdminVm GetCategoriesForAdmin();
        AddAndEditCategoryAdminVm GetCategoryToEdit(int idCategory);
        int AddCategory(AddAndEditCategoryAdminVm newCategory);
        void AcceptCategory(int Idcategory);
        void DeleteCategory(int idCategory);
        void EditCategory(AddAndEditCategoryAdminVm model);
        ListOfQuestionAdminVm ShowQuestionsToAdmin(int pageSize, int pageNo, string searchString, int categoryId);
        DetailsOfQuestionAdminVm DetailsOfQuestion(int idQuestion);
        void AcceptQuestion(int idQuestion);
        int AcceptAnswer(int idAnswer);
        void DeleteQuestion(int idQuestion);
        int DeleteAnswer(int idAnswer);
        int AddQuestion(AddAndEditQuestionAndAnswerAdminVm questionVm);
        List<Answer> AddExtraAnswer(AnswerToAdminVm model);
        void ChooseGoodAnswerAndAcceptAnswers(int idAnswer);
        AddAndEditQuestionAndAnswerAdminVm GetQuestionToEdit(int id);
        void EditQuestion(AddAndEditQuestionAndAnswerAdminVm questionVm);
    }
}

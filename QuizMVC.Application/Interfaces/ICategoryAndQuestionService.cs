using QuizMVC.Application.CategoryAndQuestionVm;

namespace QuizMVC.Application.Interfaces
{
    public interface ICategoryAndQuestionService
    {
        ListOfCategoriesVm GetCategories();
        int DrawCategory(string username);
        int AddCategory(NewCategoryVm newCategory);
        QuestionVm ShowRandomlySelectedQuestion(int categoryId, string username);
        ResultVm CheckAnswer(int idOfAnswer, string username);
        QuestionVm GetQuestionById(int idQuestion);
        int AddQuestion(NewQuestionVm questionVm);
        void SetGoodAnswer(int idAnswer);
    }
}

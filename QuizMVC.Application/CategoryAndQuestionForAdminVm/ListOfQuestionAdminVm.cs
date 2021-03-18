using System.Collections.Generic;

namespace QuizMVC.Application.CategoryAndQuestionForAdminVm
{
    public class ListOfQuestionAdminVm
    {
        public List<QuestionToListAdminVm> Questions { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public int Count { get; set; }
        public ListOfCategoriesAdminVm Categories { get; set; }
        public int CategoryId { get; set; }
    }
}

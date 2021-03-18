using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;

namespace QuizMVC.Web.Controllers
{
    [Authorize]
    public class CategoryAndQuestionController : Controller
    {
        private readonly ICategoryAndQuestionService _categoryAndQuestionService;
        public CategoryAndQuestionController(ICategoryAndQuestionService categoryAndQuestionService)
        {
            _categoryAndQuestionService = categoryAndQuestionService;
        }
        [HttpGet]
        public IActionResult ShowCategories()
        {
            var model = _categoryAndQuestionService.GetCategories();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddNewCategory()
        {
            return View(new NewCategoryVm());
        }
        [HttpPost]
        public IActionResult AddNewCategory(NewCategoryVm newCategoryModel)
        {
            var id = _categoryAndQuestionService.AddCategory(newCategoryModel);
            return Redirect("/Home/ShowMenuForUser");
        }
        [HttpGet]
        public IActionResult ShowQuestion()
        {
            var user = User.Identity.Name;
            int id = _categoryAndQuestionService.DrawCategory(user);
            var model = _categoryAndQuestionService.ShowRandomlySelectedQuestion(id, user);
            return View(model);
        }
        [HttpGet]
        public IActionResult CheckAnswer(int IdOfSelectedAnswer)
        {
            var user = User.Identity.Name;
            var result = _categoryAndQuestionService.CheckAnswer(IdOfSelectedAnswer, user);
            return RedirectToAction("ManageScores", "UsersRolesAndScores", result);
        }
        [HttpGet]
        public IActionResult AddNewQuestion()
        {
            var model = new NewQuestionVm()
            {
                Categories = _categoryAndQuestionService.GetCategories()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AddNewQuestion(NewQuestionVm model)
        {
            var id = _categoryAndQuestionService.AddQuestion(model);
            return new RedirectResult(Url.Action("ShowNewQuestion", new { Id = id }));
        }
        [HttpGet]
        public IActionResult ShowNewQuestion(int id)
        {
            var question = _categoryAndQuestionService.GetQuestionById(id);
            return View(question);
        }
        [HttpGet]
        public IActionResult ChooseGoodAnswer(int id)
        {
            _categoryAndQuestionService.SetGoodAnswer(id);
            return Redirect("/Home/ShowMenuForUser");
        }
    }
}

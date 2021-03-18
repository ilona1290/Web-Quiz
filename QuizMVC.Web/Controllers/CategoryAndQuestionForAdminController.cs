using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizMVC.Application.CategoryAndQuestionForAdminVm;
using QuizMVC.Application.Interfaces;
using System;

namespace QuizMVC.Web.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class CategoryAndQuestionForAdminController : Controller
    {
        private readonly ICategoryAndQuestionForAdminService _catAndQueService;
        public CategoryAndQuestionForAdminController(ICategoryAndQuestionForAdminService catAndQueService)
        {
            _catAndQueService = catAndQueService;
        }
        [HttpGet]
        public IActionResult ShowCategoriesForAdmin()
        {
            var model = _catAndQueService.GetCategoriesForAdmin();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View(new AddAndEditCategoryAdminVm());
        }
        [HttpPost]
        public IActionResult AddCategory(AddAndEditCategoryAdminVm model)
        {
            model.IsAccepted = true;
            int id = _catAndQueService.AddCategory(model);
            return RedirectToAction("ShowCategoriesForAdmin");
        }
        [HttpGet]
        public IActionResult AcceptCategory(int id)
        {
            _catAndQueService.AcceptCategory(id);
            return RedirectToAction("ShowCategoriesForAdmin");
        }
        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            _catAndQueService.DeleteCategory(id);
            return RedirectToAction("ShowCategoriesForAdmin");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _catAndQueService.GetCategoryToEdit(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory(AddAndEditCategoryAdminVm model)
        {
            _catAndQueService.EditCategory(model);
            return RedirectToAction("ShowCategoriesForAdmin");
        }
        [HttpGet]
        public IActionResult ShowQuestions()
        {
            var questions = _catAndQueService.ShowQuestionsToAdmin(7, 1, "", 0);
            return View(questions);
        }
        [HttpPost]
        public IActionResult ShowQuestions(int pageSize, int? pageNo, string searchString, int? categoryId)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (!categoryId.HasValue)
            {
                categoryId = 0;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _catAndQueService.ShowQuestionsToAdmin(pageSize, pageNo.Value, searchString, categoryId.Value);
            return View(model);
        }
        [HttpGet]
        public IActionResult DetailsOfQuestion(int id)
        {
            var model = _catAndQueService.DetailsOfQuestion(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult AcceptQuestion(int id)
        {
            _catAndQueService.AcceptQuestion(id);
            return new RedirectResult(Url.Action("DetailsOfQuestion", new { Id = id }));
        }
        public IActionResult AcceptAnswer(int id)
        {
            int idQuestion = _catAndQueService.AcceptAnswer(id);
            return new RedirectResult(Url.Action("DetailsOfQuestion", new { Id = idQuestion }));
        }
        [HttpGet]
        public IActionResult DeleteQuestion(int id)
        {
            _catAndQueService.DeleteQuestion(id);
            return RedirectToAction("ShowQuestions");
        }
        [HttpGet]
        public IActionResult DeleteAnswer(int id)
        {
            int idQuestionOfRemovingAnswer = _catAndQueService.DeleteAnswer(id);
            return new RedirectResult(Url.Action("DetailsOfQuestion", new { Id = idQuestionOfRemovingAnswer }));
        }
        [HttpGet]
        public IActionResult AddQuestion()
        {
            var model = new AddAndEditQuestionAndAnswerAdminVm()
            {
                Categories = _catAndQueService.GetCategoriesForAdmin()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddQuestion(AddAndEditQuestionAndAnswerAdminVm model)
        {
            int id = _catAndQueService.AddQuestion(model);
            return new RedirectResult(Url.Action("ShowNewQuestionAdmin", new { Id = id }));
        }
        [HttpGet]
        public IActionResult ShowNewQuestionAdmin(int id)
        {
            var question = _catAndQueService.DetailsOfQuestion(id);
            return View(question);
        }
        [HttpGet]
        public IActionResult ChooseGoodAnswerAndAcceptAnswersAdmin(int id)
        {
            _catAndQueService.ChooseGoodAnswerAndAcceptAnswers(id);
            return RedirectToAction("ShowQuestions");
        }
        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            var question = _catAndQueService.GetQuestionToEdit(id);
            question.Categories = _catAndQueService.GetCategoriesForAdmin();
            return View(question);
        }
        [HttpPost]
        public IActionResult EditQuestion(AddAndEditQuestionAndAnswerAdminVm model)
        {
            _catAndQueService.EditQuestion(model);
            int iqOfUpdatingQuestion = model.Id;
            return new RedirectResult(Url.Action("DetailsOfQuestion", new { Id = iqOfUpdatingQuestion }));
        }
        [HttpGet]
        public IActionResult AddExtraAnswersToExistingQuestion(int? id, int idQuestion)
        {
            var answerTemplateToExistingQuestion = new AnswerToAdminVm() { QuestionId = idQuestion, IsAccepted = true };
            return View(answerTemplateToExistingQuestion);
        }
        [HttpPost]
        public IActionResult AddExtraAnswersToExistingQuestion(AnswerToAdminVm model)
        {
            _catAndQueService.AddExtraAnswer(model);
            return new RedirectResult(Url.Action("DetailsOfQuestion", new { Id = model.QuestionId }));
        }
    }
}

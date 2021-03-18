using AutoMapper;
using AutoMapper.QueryableExtensions;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System;
using System.Linq;

namespace QuizMVC.Application.Services
{
    public class CategoryAndQuestionService : ICategoryAndQuestionService
    {
        private readonly ICategoryAndQuestionRepository _categoryAndQuestionRepo;
        private readonly IMapper _mapper;
        public CategoryAndQuestionService(ICategoryAndQuestionRepository categoryRepo, IMapper mapper)
        {
            _categoryAndQuestionRepo = categoryRepo;
            _mapper = mapper;
        }

        public ListOfCategoriesVm GetCategories()
        {
            var categories = _categoryAndQuestionRepo.GetAllAcceptedCategories().ProjectTo<CategoryToCategoryListVm>
                (_mapper.ConfigurationProvider).ToList();
            var categoryList = new ListOfCategoriesVm() { Categories = categories };
            return categoryList;
        }
        public int DrawCategory(string username)
        {
            var categoryIdsWhichUserRespondCorrectlyOnItsQuestions = _categoryAndQuestionRepo
                .GetCategoryIdsWhichUserRespondCorrectlyOnItsQuestions(username);
            var categories = _categoryAndQuestionRepo.GetAllAcceptedCategories().ProjectTo<CategoryToCategoryListVm>
                (_mapper.ConfigurationProvider).ToList();
            for (int i = 0; i < categories.Count; i++)
            {
                if (categoryIdsWhichUserRespondCorrectlyOnItsQuestions.Contains(categories[i].Id))
                {
                    categories.RemoveAt(i);
                    i--;
                }
            }
            int categoryId;
            if (categories.Count != 0)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, categories.Count);
                categoryId = categories[randomNumber].Id;
            }
            else
            {
                categoryId = -1;
            }
            return categoryId;
        }

        public int AddCategory(NewCategoryVm newCategory)
        {
            var cat = _mapper.Map<Category>(newCategory);
            int id = _categoryAndQuestionRepo.AddCategory(cat);
            return id;
        }
        public QuestionVm ShowRandomlySelectedQuestion(int categoryId, string username)
        {
            var questionsIdWithGoodRespondOfthisUser = _categoryAndQuestionRepo.GetQuestionIdsWhichUserRespondCorrectly(username);
            var questions = _categoryAndQuestionRepo.GetQuestionsByCategoryId(categoryId)
                .ProjectTo<QuestionVm>(_mapper.ConfigurationProvider).ToList();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questionsIdWithGoodRespondOfthisUser.Contains(questions[i].Id))
                {
                    questions.RemoveAt(i);
                    i--;
                }
            }
            if (questions.Count == 0)
            {
                if (categoryId != -1)
                {
                    var categoryRespondedCorrectlyByUser = new CategoryWithEveryQuestionsRespondedCorrectlyByUser()
                    {
                        Username = username,
                        CategoryId = categoryId
                    };
                    _categoryAndQuestionRepo.AddCategoryWithAllGoodRespondsByUser(categoryRespondedCorrectlyByUser);
                    int idCategory = DrawCategory(username);
                    var question1 = ShowRandomlySelectedQuestion(idCategory, username);
                    return question1;
                }
                else
                {
                    QuestionVm questionVm1 = new QuestionVm() { Category = "empty" };
                    return questionVm1;
                }
            }
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, questions.Count);
            var question = questions[randomNumber];
            return question;
        }
        public ResultVm CheckAnswer(int idOfAnswer, string username)
        {
            var answer = _categoryAndQuestionRepo.ReturnAnswerById(idOfAnswer);
            ResultVm resultVm = new ResultVm();
            if (answer.IsCorrect == true)
            {
                resultVm.IsGood = true;
                var questionIdWithGoodRespondAndUsername = new QuestionsOnWhichUsersRespondCorrectly()
                {
                    UserName = username,
                    QuestionId = answer.QuestionId
                };
                _categoryAndQuestionRepo.SaveIdOfQuestionWhichUserRespondedCorrectly(questionIdWithGoodRespondAndUsername);
            }
            else
            {
                resultVm.IsGood = false;
            }
            return resultVm;
        }
        public int AddQuestion(NewQuestionVm questionVm)
        {
            var question = _mapper.Map<Question>(questionVm);
            _categoryAndQuestionRepo.DeleteCategoryFromFinishedCategories(question.CategoryId);
            var id = _categoryAndQuestionRepo.AddQuestion(question);
            return id;
        }
        public QuestionVm GetQuestionById(int idQuestion)
        {
            var question = _categoryAndQuestionRepo.GetQuestionById(idQuestion);
            var questionVm = _mapper.Map<QuestionVm>(question);
            questionVm.Category = _categoryAndQuestionRepo.ReturnCategoryById(question.CategoryId).Name;
            questionVm.Answers = _categoryAndQuestionRepo.ReturnAnswersByQuestionId(idQuestion)
                .ProjectTo<AnswerVm>(_mapper.ConfigurationProvider).ToList();
            return questionVm;
        }
        public void SetGoodAnswer(int idAnswer)
        {
            var answer = _categoryAndQuestionRepo.ReturnAnswerById(idAnswer);
            answer.IsCorrect = true;
            _categoryAndQuestionRepo.SetGoodAnswer(answer);
        }
    }
}

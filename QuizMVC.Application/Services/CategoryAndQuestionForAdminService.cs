using AutoMapper;
using AutoMapper.QueryableExtensions;
using QuizMVC.Application.CategoryAndQuestionForAdminVm;
using QuizMVC.Application.Interfaces;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Application.Services
{
    public class CategoryAndQuestionForAdminService : ICategoryAndQuestionForAdminService
    {
        private readonly ICategoryAndQuestionForAdminRepository _categoryAndQuestionForAdminRepo;
        private readonly IMapper _mapper;
        public CategoryAndQuestionForAdminService(ICategoryAndQuestionForAdminRepository categoryAndQueForAdminRepo, IMapper mapper)
        {
            _categoryAndQuestionForAdminRepo = categoryAndQueForAdminRepo;
            _mapper = mapper;
        }
        public ListOfCategoriesAdminVm GetCategoriesForAdmin()
        {
            var categories = _categoryAndQuestionForAdminRepo.GetCategoriesForAdmin()
                .ProjectTo<CategoryToListAdminVm>(_mapper.ConfigurationProvider).ToList();
            var categoriesToAdmin = new ListOfCategoriesAdminVm()
            {
                Categories = categories
            };
            return categoriesToAdmin;
        }
        public int AddCategory(AddAndEditCategoryAdminVm newCategory)
        {
            var cat = _mapper.Map<Category>(newCategory);
            int id = _categoryAndQuestionForAdminRepo.AddCategory(cat);
            return id;
        }
        public void AcceptCategory(int idcategory)
        {
            var categoryToAccept = _categoryAndQuestionForAdminRepo.ReturnCategoryById(idcategory);
            if (categoryToAccept.IsAccepted == false)
            {
                categoryToAccept.IsAccepted = true;
                _categoryAndQuestionForAdminRepo.AcceptCategory(categoryToAccept);
            }
        }
        public void DeleteCategory(int idCategory)
        {
            _categoryAndQuestionForAdminRepo.DeleteCategory(idCategory);
        }
        public AddAndEditCategoryAdminVm GetCategoryToEdit(int idCategory)
        {
            var category = _categoryAndQuestionForAdminRepo.ReturnCategoryById(idCategory);
            var categoryVm = _mapper.Map<AddAndEditCategoryAdminVm>(category);
            return categoryVm;
        }
        public void EditCategory(AddAndEditCategoryAdminVm model)
        {
            var category = _mapper.Map<Category>(model);
            _categoryAndQuestionForAdminRepo.UpdateCategory(category);
        }

        public ListOfQuestionAdminVm ShowQuestionsToAdmin(int pageSize, int pageNo, string searchString, int categoryId)
        {
            var questions = new List<QuestionToListAdminVm>();
            if (categoryId == 0)
            {
                questions = _categoryAndQuestionForAdminRepo.ShowQuestions().Where(p => p.QuestionText.StartsWith(searchString))
                    .ProjectTo<QuestionToListAdminVm>(_mapper.ConfigurationProvider).ToList();
            }
            else
            {
                questions = _categoryAndQuestionForAdminRepo.ShowQuestions().Where(p => p.QuestionText.StartsWith(searchString)
                && p.CategoryId == categoryId).ProjectTo<QuestionToListAdminVm>(_mapper.ConfigurationProvider).ToList();
            }
            var sortedQuestionsByIsAccepted = questions.OrderBy(i => i.IsAccepted).ToList();
            var questionsToShow = sortedQuestionsByIsAccepted.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var categories = _categoryAndQuestionForAdminRepo.GetCategoriesForAdmin().ProjectTo<CategoryToListAdminVm>
                (_mapper.ConfigurationProvider).ToList();
            CategoryToListAdminVm categoryToList = new CategoryToListAdminVm() { Id = 0, Name = "Nie wybieram żadnej kategorii" };
            categories.Add(categoryToList);
            ListOfCategoriesAdminVm listOfCategories = new ListOfCategoriesAdminVm() { Categories = categories };
            var listOfQuestion = new ListOfQuestionAdminVm()
            {
                Questions = questionsToShow,
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString,
                Count = questions.Count,
                Categories = listOfCategories,
                CategoryId = categoryId
            };
            return listOfQuestion;
        }
        public DetailsOfQuestionAdminVm DetailsOfQuestion(int idQuestion)
        {
            var question = _categoryAndQuestionForAdminRepo.ReturnDetailsOfQuestion(idQuestion);
            var questionVm = _mapper.Map<DetailsOfQuestionAdminVm>(question);
            questionVm.CategoryText = _categoryAndQuestionForAdminRepo.ReturnCategoryById(question.CategoryId).Name;
            questionVm.Answers = _categoryAndQuestionForAdminRepo.ReturnAnswersByQuestionId(idQuestion)
                .ProjectTo<AnswerToAdminVm>(_mapper.ConfigurationProvider).ToList();
            return questionVm;
        }
        public void AcceptQuestion(int idQuestion)
        {
            var question = _categoryAndQuestionForAdminRepo.ReturnDetailsOfQuestion(idQuestion);
            if (question.IsAccepted == false)
            {
                question.IsAccepted = true;
                _categoryAndQuestionForAdminRepo.AfterAcceptNewQuestionRemoveItsCategoryFromUsedCategoriesToAllUser(question.CategoryId);
                _categoryAndQuestionForAdminRepo.AcceptQuestion(question);
            }
        }
        public int AcceptAnswer(int idAnswer)
        {
            var answer = _categoryAndQuestionForAdminRepo.ReturnAnswerById(idAnswer);
            if (answer.IsAccepted == false)
            {
                answer.IsAccepted = true;
                _categoryAndQuestionForAdminRepo.AcceptAnswer(answer);
            }
            return answer.QuestionId;
        }
        public void DeleteQuestion(int idQuestion)
        {
            _categoryAndQuestionForAdminRepo.DeleteQuestion(idQuestion);
        }
        public int DeleteAnswer(int idAnswer)
        {
            int idQuestionOfRemovingAnswer = _categoryAndQuestionForAdminRepo.DeleteAnswer(idAnswer);
            return idQuestionOfRemovingAnswer;
        }
        public int AddQuestion(AddAndEditQuestionAndAnswerAdminVm questionVm)
        {
            var question = _mapper.Map<Question>(questionVm);
            var id = _categoryAndQuestionForAdminRepo.AddQuestion(question);
            _categoryAndQuestionForAdminRepo.AfterAcceptNewQuestionRemoveItsCategoryFromUsedCategoriesToAllUser(question.CategoryId);
            return id;
        }
        public List<Answer> AddExtraAnswer(AnswerToAdminVm answer)
        {
            Question question = _categoryAndQuestionForAdminRepo.ReturnDetailsOfQuestion(answer.QuestionId);
            var questionVm = _mapper.Map<DetailsOfQuestionAdminVm>(question);
            questionVm.Answers = _categoryAndQuestionForAdminRepo.ReturnAnswersByQuestionId(questionVm.Id)
            .ProjectTo<AnswerToAdminVm>(_mapper.ConfigurationProvider).ToList();
            questionVm.CategoryText = _categoryAndQuestionForAdminRepo.ReturnCategoryById(question.CategoryId).Name;
            questionVm.Answers.Add(answer);
            var questionToDatabase = _mapper.Map<Question>(questionVm);
            var answers = questionToDatabase.Answers;
            var listOfAnswers = answers.ToList();
            _categoryAndQuestionForAdminRepo.UpdateAnswers(listOfAnswers);
            return listOfAnswers;
        }
        public void ChooseGoodAnswerAndAcceptAnswers(int idAnswer)
        {
            var answer = _categoryAndQuestionForAdminRepo.ReturnAnswerById(idAnswer);
            answer.IsCorrect = true;
            _categoryAndQuestionForAdminRepo.SetGoodAnswer(answer);
            var answersToAccept = _categoryAndQuestionForAdminRepo.ReturnAnswersByQuestionId(answer.QuestionId)
                .ProjectTo<AnswerToAdminVm>(_mapper.ConfigurationProvider).ToList();
            foreach (var item in answersToAccept)
            {
                AcceptAnswer(item.Id);
            }
        }
        public AddAndEditQuestionAndAnswerAdminVm GetQuestionToEdit(int id)
        {
            var question = _categoryAndQuestionForAdminRepo.ReturnDetailsOfQuestion(id);
            var questionVm = _mapper.Map<AddAndEditQuestionAndAnswerAdminVm>(question);
            questionVm.Answers = _categoryAndQuestionForAdminRepo.ReturnAnswersByQuestionId(id)
                .ProjectTo<AnswerToAdminVm>(_mapper.ConfigurationProvider).ToList();
            return questionVm;
        }
        public void EditQuestion(AddAndEditQuestionAndAnswerAdminVm questionVm)
        {
            var question = _mapper.Map<Question>(questionVm);
            var answersToUpdate = question.Answers;
            var listOfAnswers = answersToUpdate.ToList();
            _categoryAndQuestionForAdminRepo.UpdateQuestion(question);
            _categoryAndQuestionForAdminRepo.UpdateAnswers(listOfAnswers);
        }
    }
}

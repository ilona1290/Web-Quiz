using AutoMapper;
using FluentAssertions;
using Moq;
using QuizMVC.Application.CategoryAndQuestionForAdminVm;
using QuizMVC.Application.Mapping;
using QuizMVC.Application.Services;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace QuizMVC.Tests.Services
{
    public class CategoryAndQuestionForAdminServiceTest
    {
        [Fact]
        public void ShouldReturnAllCategories()
        {
            //Arrange
            var categories = new List<Category> { new Category() { Id = 1, Name = "Matematyka", IsAccepted = true},
            new Category() { Id = 2, Name = "Historia", IsAccepted = true} } ;
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var catRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            catRepo.Setup(c => c.GetCategoriesForAdmin()).Returns(categories.AsQueryable());
            var catServ = new CategoryAndQuestionForAdminService(catRepo.Object, mapper);

            //Act 
            var listOfCategories = catServ.GetCategoriesForAdmin();

            //Assert
            Assert.Equal(listOfCategories.Categories.Count, categories.Count);
            listOfCategories.Should().BeOfType(typeof(ListOfCategoriesAdminVm));
            listOfCategories.Categories.Should().AllBeOfType(typeof(CategoryToListAdminVm));
            Assert.Equal(listOfCategories.Categories[0].Name, categories[0].Name);
        }

        [Fact]
        public void TestOfAcceptingCategories()
        {
            //Arrange
            var category = new Category() { Id = 1, Name = "Matematyka", IsAccepted = false };
            var catRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            catRepo.Setup(c => c.ReturnCategoryById(category.Id)).Returns(category);
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var catServ = new CategoryAndQuestionForAdminService(catRepo.Object, mapper);

            //Act
            catServ.AcceptCategory(category.Id);

            //Assert
            Assert.True(category.IsAccepted);
        }

        [Fact]
        public void TestOfGettingCategoryById()
        {
            //Arrange
            var category = new Category() { Id = 1, Name = "Matematyka", IsAccepted = true };
            var catRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            catRepo.Setup(c => c.ReturnCategoryById(category.Id)).Returns(category);
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var catServ = new CategoryAndQuestionForAdminService(catRepo.Object, mapper);

            //Act
            var dowlandedCat = catServ.GetCategoryToEdit(category.Id);

            //Assert
            Assert.NotNull(dowlandedCat);
            Assert.Equal(dowlandedCat.Id, category.Id);
        }

        [Fact]
        public void TestOfShowingQuestions()
        {
            //Arrange
            var questions = new List<Question>() {
                new Question
                {
                    Id = 1,
                    QuestionText = "Ile to jest 25 + 25?",
                    CategoryId = 1,
                    Category = new Category() {Id = 1, Name = "Matematyka", IsAccepted = true },
                    IsAccepted = true
                },
                new Question
                {
                    Id = 2,
                    QuestionText = "Ile wynosi pierwiastek kwadratowty z 64?",
                    CategoryId = 1,
                    Category = new Category(){Id = 1, Name = "Matematyka", IsAccepted = true },
                    IsAccepted = true
                },
                new Question
                {
                    Id = 3,
                    QuestionText = "W którym roku zaczęła się II WŚ?",
                    CategoryId = 2,
                    Category = new Category(){Id = 2, Name = "Historia", IsAccepted = true},
                    IsAccepted = false
                }
            };
            var queRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            queRepo.Setup(c => c.ShowQuestions()).Returns(questions.AsQueryable());
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var queServ = new CategoryAndQuestionForAdminService(queRepo.Object, mapper);
            var nonAcceptedQuestion = questions.Find(q => q.IsAccepted == false);
            var mathsQuestion = questions.Where(q => q.CategoryId == 1).ToList();

            //Act
            var listOfAllQuestions = queServ.ShowQuestionsToAdmin(3, 1, "", 0);
            var listOfMathsQuestions = queServ.ShowQuestionsToAdmin(3, 1, "", 1);

            //Assert
            listOfAllQuestions.Questions.Should().HaveCount(questions.Count);
            listOfMathsQuestions.Questions.Should().HaveCount(mathsQuestion.Count);

            //Checking if non accepted question is at first position on list
            Assert.Equal(listOfAllQuestions.Questions[0].QuestionText, nonAcceptedQuestion.QuestionText);
        }

        [Fact]
        public void TestOfShowOneQuestion()
        {
            var question = new Question()
            {
                Id = 1,
                QuestionText = "Ile to jest 25 + 25?",
                CategoryId = 1,
                Category = new Category() { Id = 1, Name = "Matematyka", IsAccepted = true },
                IsAccepted = true,
                Answers = new List<Answer>()
                {
                    new Answer(){Id = 1, AnswerText = "75", IsAccepted = true, IsCorrect = false, QuestionId = 1},
                    new Answer(){Id = 2, AnswerText = "50", IsAccepted = true, IsCorrect = true, QuestionId = 1}
                }
            };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var queRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            queRepo.Setup(q => q.ReturnDetailsOfQuestion(question.CategoryId)).Returns(question);
            queRepo.Setup(q => q.ReturnCategoryById(question.CategoryId)).Returns(question.Category);
            queRepo.Setup(q => q.ReturnAnswersByQuestionId(question.Id)).Returns(question.Answers.AsQueryable());
            var queServ = new CategoryAndQuestionForAdminService(queRepo.Object, mapper);

            //Act 
            var questionFromMethod = queServ.DetailsOfQuestion(question.Id);

            //Assert
            questionFromMethod.Should().NotBeNull();
            questionFromMethod.Should().BeOfType(typeof(DetailsOfQuestionAdminVm));
            questionFromMethod.IsAccepted.Should().BeTrue();
            Assert.Equal(questionFromMethod.QuestionText, question.QuestionText);
            Assert.Equal(questionFromMethod.CategoryText, question.Category.Name);
            questionFromMethod.Answers.Should().NotBeNull();
            questionFromMethod.Answers.Should().HaveCount(2);
            questionFromMethod.Answers.Should().AllBeOfType(typeof(AnswerToAdminVm));
        }

        [Fact]
        public void TestOfAcceptingQuestion()
        {
            //Arrange
            var question = new Question()
            {
                Id = 1,
                QuestionText = "Ile to jest 25 + 25?",
                IsAccepted = false
            };
            var queRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            queRepo.Setup(q => q.ReturnDetailsOfQuestion(question.Id)).Returns(question);
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var queServ = new CategoryAndQuestionForAdminService(queRepo.Object, mapper);

            //Act 
            queServ.AcceptQuestion(question.Id);

            //Assert
            Assert.True(question.IsAccepted);
        }

        [Fact]
        public void TestOfAcceptingAnswer()
        {
            var answer = new Answer()
            {
                Id = 1,
                AnswerText = "30",
                IsAccepted = false
            };

            var ansRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            ansRepo.Setup(a => a.ReturnAnswerById(answer.Id)).Returns(answer);
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var ansServ = new CategoryAndQuestionForAdminService(ansRepo.Object, mapper);

            //Act
            ansServ.AcceptAnswer(answer.Id);

            //Assert
            Assert.True(answer.IsAccepted);

        }

        [Fact]
        public void TestOfChoosingGoodAnswers()
        {
            var answer = new Answer()
            {
                Id = 1,
                AnswerText = "30",
                IsCorrect = false
            };

            var ansRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            ansRepo.Setup(a => a.ReturnAnswerById(answer.Id)).Returns(answer);
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var ansServ = new CategoryAndQuestionForAdminService(ansRepo.Object, mapper);

            //Act
            ansServ.ChooseGoodAnswerAndAcceptAnswers(answer.Id);

            //Assert
            Assert.True(answer.IsCorrect);
        }

        [Fact]
        public void TestOfAddingExtraAnswer()
        {
            var question = new Question()
            {
                Id = 1,
                QuestionText = "Ile to jest 25 + 25?",
                CategoryId = 1,
                Category = new Category() { Id = 1, Name = "Matematyka", IsAccepted = true },
                IsAccepted = true,
                Answers = new List<Answer>()
                {
                    new Answer(){Id = 1, AnswerText = "75", IsAccepted = true, IsCorrect = false, QuestionId = 1},
                    new Answer(){Id = 2, AnswerText = "50", IsAccepted = true, IsCorrect = true, QuestionId = 1}
                }
            };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });
            var mapper = config.CreateMapper();
            var queRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            queRepo.Setup(q => q.ReturnDetailsOfQuestion(question.CategoryId)).Returns(question);
            queRepo.Setup(q => q.ReturnCategoryById(question.CategoryId)).Returns(question.Category);
            queRepo.Setup(q => q.ReturnAnswersByQuestionId(question.Id)).Returns(question.Answers.AsQueryable());
            var queServ = new CategoryAndQuestionForAdminService(queRepo.Object, mapper);
            var extraAnswer = new AnswerToAdminVm() { Id = 3, AnswerText = "30", IsAccepted = true, IsCorrect = false, QuestionId = 1 };

            //Act
            var answers = queServ.AddExtraAnswer(extraAnswer);

            //Assert
            answers.Should().HaveCount(3);
            answers[2].AnswerText.Should().Equals("30");
        }
    }
}

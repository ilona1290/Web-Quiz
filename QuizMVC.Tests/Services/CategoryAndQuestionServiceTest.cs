using AutoMapper;
using FluentAssertions;
using Moq;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;
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
    public class CategoryAndQuestionServiceTest
    {
        [Fact]
        public void TestOfDrawingCategory()
        {
            var categories = new List<Category>()
            {
                new Category(){Id = 1, Name = "Matematyka", IsAccepted = true},
                new Category(){Id = 2, Name = "Historia", IsAccepted = true},
                new Category(){Id = 3, Name = "Geografia", IsAccepted = true},
                new Category(){Id = 4, Name = "Informatyka", IsAccepted = true}
            };
            var categoriesWhichAreChecked = new List<CategoryWithEveryQuestionsRespondedCorrectlyByUser>
            {
                new CategoryWithEveryQuestionsRespondedCorrectlyByUser()
                {
                    Id = 1,
                    Username = "tutu@.gmail.com",
                    CategoryId = 3
                },
                new CategoryWithEveryQuestionsRespondedCorrectlyByUser()
                {
                    Id = 2,
                    Username = "tutu@.gmail.com",
                    CategoryId = 1
                }
            };
            var idsOfCategoriesWhichAreChecked = new List<int> { 1, 3 };
            var idsOfCategoriesWhichAreNotChecked = new List<int> { 2, 4 };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var catRepo = new Mock<ICategoryAndQuestionRepository>();
            catRepo.Setup(c => c.GetCategoryIdsWhichUserRespondCorrectlyOnItsQuestions(categoriesWhichAreChecked[0].Username))
                .Returns(idsOfCategoriesWhichAreChecked);
            catRepo.Setup(c => c.GetAllAcceptedCategories()).Returns(categories.AsQueryable());
            var catServ = new CategoryAndQuestionService(catRepo.Object, mapper);

            //Act
            var idDrowingCategory = catServ.DrawCategory(categoriesWhichAreChecked[0].Username);

            //Assert
            idDrowingCategory.Should().BeOfType(typeof(int));
            Assert.NotEqual(categories[0].Id, idDrowingCategory);
            Assert.NotEqual(categories[2].Id, idDrowingCategory);
            idsOfCategoriesWhichAreNotChecked.Should().Contain(idDrowingCategory);
        }
        
        [Fact]
        public void TestOfDrawingQuestionWhenUserDoesntAnswerOnEveryQuestion()
        {
            var returnedQuestions = new List<Question>() {
                new Question()
                {
                    Id = 1,
                    QuestionText = "Ile to jest 25 + 25?",
                    CategoryId = 2,
                    IsAccepted = true,
                    Category = new Category(){Id = 1, IsAccepted = true, Name = "Matematyka"},
                    Answers = new List<Answer>()
                    {
                        new Answer(){Id = 1, AnswerText = "50", IsAccepted = true, IsCorrect = true, QuestionId = 1},
                        new Answer(){Id = 2, AnswerText = "150", IsAccepted = true, IsCorrect = false, QuestionId = 1}
                    }
                },
                new Question()
                {
                    Id = 2,
                    QuestionText = "Ile wynosi pierwiastek kwadratowty z 64?",
                    CategoryId = 2,
                    IsAccepted = true,
                    Category = new Category(){Id = 1, IsAccepted = true, Name = "Matematyka"},
                    Answers = new List<Answer>()
                    {
                        new Answer(){Id = 1, AnswerText = "8", IsAccepted = true, IsCorrect = true, QuestionId = 2},
                        new Answer(){Id = 2, AnswerText = "4", IsAccepted = true, IsCorrect = false, QuestionId = 2}
                    }
                }
            };
            var questionWithGoodAnswer = new QuestionsOnWhichUsersRespondCorrectly() { Id = 1, UserName = "lulu@gmail.com", QuestionId = 2 };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var catRepo = new Mock<ICategoryAndQuestionRepository>();
            
            catRepo.Setup(c => c.GetQuestionIdsWhichUserRespondCorrectly(questionWithGoodAnswer.UserName))
                .Returns(new List<int>(){ questionWithGoodAnswer.QuestionId});
            catRepo.Setup(c => c.GetQuestionsByCategoryId(returnedQuestions[0].CategoryId)).Returns(returnedQuestions.AsQueryable());
            var catServ = new CategoryAndQuestionService(catRepo.Object, mapper);

            //Act
            var question = catServ.ShowRandomlySelectedQuestion(returnedQuestions[0].CategoryId, questionWithGoodAnswer.UserName);

            //Assert
            Assert.NotNull(question);
            question.Should().BeOfType(typeof(QuestionVm));

        }

        [Fact]
        public void TestOfDrawingQuestionWhenUserAnswerOnEveryQuestionFromGivenCategory()
        {
            var questions = new List<Question>() {
                new Question()
                {
                    Id = 1,
                    QuestionText = "Ile to jest 25 + 25?",
                    CategoryId = 1,
                    IsAccepted = true,
                    Category = new Category(){Id = 1, IsAccepted = true, Name = "Matematyka"},
                    Answers = new List<Answer>()
                    {
                        new Answer(){Id = 1, AnswerText = "50", IsAccepted = true, IsCorrect = true, QuestionId = 1},
                        new Answer(){Id = 2, AnswerText = "150", IsAccepted = true, IsCorrect = false, QuestionId = 1}
                    }
                },
                new Question()
                {
                    Id = 2,
                    QuestionText = "Ile wynosi pierwiastek kwadratowty z 64?",
                    CategoryId = 1,
                    IsAccepted = true,
                    Category = new Category(){Id = 1, IsAccepted = true, Name = "Matematyka"},
                    Answers = new List<Answer>()
                    {
                        new Answer(){Id = 1, AnswerText = "8", IsAccepted = true, IsCorrect = true, QuestionId = 2},
                        new Answer(){Id = 2, AnswerText = "4", IsAccepted = true, IsCorrect = false, QuestionId = 2}
                    }
                },
                new Question()
                {
                    Id = 3,
                    QuestionText = "Jakiego kraju stolicą jest Rzym?",
                    CategoryId = 2,
                    IsAccepted = true,
                    Category = new Category(){Id = 2, IsAccepted = true, Name = "Geografia"},
                    Answers = new List<Answer>()
                    {
                        new Answer(){Id = 1, AnswerText = "Włochy", IsAccepted = true, IsCorrect = true, QuestionId = 3},
                        new Answer(){Id = 2, AnswerText = "Francja", IsAccepted = true, IsCorrect = false, QuestionId = 3}
                    }
                }
            };

            var questionsWithGoodAnswer = new List<QuestionsOnWhichUsersRespondCorrectly>()
            {
                new QuestionsOnWhichUsersRespondCorrectly(){Id = 1, QuestionId = 1, UserName = "pop@gmail.com"},
                new QuestionsOnWhichUsersRespondCorrectly(){Id = 2, QuestionId = 2, UserName = "pop@gmail.com"}
            };

            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var catRepo = new Mock<ICategoryAndQuestionRepository>();
            var mockOfCatServ = new Mock<ICategoryAndQuestionService>();

            catRepo.Setup(c => c.GetQuestionIdsWhichUserRespondCorrectly(questionsWithGoodAnswer[0].UserName))
                .Returns(new List<int>() { questionsWithGoodAnswer[0].QuestionId, questionsWithGoodAnswer[1].QuestionId });
            catRepo.Setup(c => c.GetQuestionsByCategoryId(questions[0].CategoryId))
                .Returns(questions.Where(q => q.CategoryId == 1).AsQueryable());
            catRepo.Setup(c => c.GetCategoryIdsWhichUserRespondCorrectlyOnItsQuestions(questionsWithGoodAnswer[0].UserName))
                .Returns(new List<int> { questions[0].CategoryId });
            catRepo.Setup(c => c.GetAllAcceptedCategories()).Returns(new List<Category> { questions[1].Category, 
                questions[2].Category }.AsQueryable());
            catRepo.Setup(c => c.GetQuestionsByCategoryId(questions[2].CategoryId))
                .Returns(questions.Where(q => q.CategoryId == 2).AsQueryable());
            
            var catServ = new CategoryAndQuestionService(catRepo.Object, mapper);

            //Act
            var question = catServ.ShowRandomlySelectedQuestion(1, "pop@gmail.com");

            //Assert
            Assert.NotNull(question);
            question.Should().BeOfType(typeof(QuestionVm));
            Assert.Equal(questions[2].Id, question.Id);
            Assert.Equal(questions[2].QuestionText, question.QuestionText);
        }
        [Fact]
        public void TestOfCheckingAnswer()
        {
            var goodAnswer = new Answer() { Id = 2, AnswerText = "50", IsAccepted = true, IsCorrect = true, QuestionId = 1 };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var catRepo = new Mock<ICategoryAndQuestionRepository>();
            catRepo.Setup(c => c.ReturnAnswerById(2)).Returns(goodAnswer);
            var catServ = new CategoryAndQuestionService(catRepo.Object, mapper);

            var result = catServ.CheckAnswer(2, "we");

            Assert.NotNull(result);
            Assert.True(result.IsGood);
        }
    }
}

using AutoMapper;
using Moq;
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
    public class StatsServiceTest
    {
        [Fact]
        public void TestOfGettingCategoryWithTheMostAndTheLessQuestions()
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
            var catRepo = new Mock<ICategoryAndQuestionForAdminRepository>();
            var userRepo = new Mock<IUsersRolesAndScoresRepository>();
            var statsRepo = new Mock<IStatsRepository>();
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            catRepo.Setup(s => s.ShowQuestions()).Returns(questions.AsQueryable());
            var statsServ = new StatsService(catRepo.Object, userRepo.Object, statsRepo.Object, mapper);

            var stats = statsServ.GetStatsAboutCatQueAns();

            Assert.Equal(questions[2].Category.Name, stats.CategoryWithTheFewestQuestions);
            Assert.Equal(questions[0].Category.Name, stats.CategoryWithTheMostQuestions);
        }
    }
}

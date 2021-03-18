using AutoMapper;
using FluentAssertions;
using Moq;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Mapping;
using QuizMVC.Application.Services;
using QuizMVC.Application.UsersRolesAndScoresVm;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace QuizMVC.Tests.Services
{
    public class UsersRolesAndScoresServiceTest
    {
        [Fact]
        public void TestOfGettingAllUsersAndTheirsRoles()
        {
            var users = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    UserName = "wuwuwu@gmail.com",
                    UserRoles = new List<ApplicationUserRole>(){ new ApplicationUserRole() { RoleId = "Admin"} }
                },
                new ApplicationUser()
                {
                    UserName = "tututu@gmail.com",
                    UserRoles = new List<ApplicationUserRole>(){ new ApplicationUserRole() { RoleId = "Admin"} }
                },
                new ApplicationUser()
                {
                    UserName = "rururu@gmail.com",
                    UserRoles = new List<ApplicationUserRole>(){ new ApplicationUserRole() { RoleId = "User"} }
                }
            };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var userRepo = new Mock<IUsersRolesAndScoresRepository>();
            userRepo.Setup(u => u.GetUsers()).Returns(users.AsQueryable());
            var userServ = new UsersRolesAndScoresService(userRepo.Object, mapper);

            //Act
            var allUsers = userServ.GetUsersAndTheirsRoles(3, 1, "", "Nie wybieram żadnej roli");
            var admins = userServ.GetUsersAndTheirsRoles(3, 1, "", "Admin");
            var usualUsers = userServ.GetUsersAndTheirsRoles(3, 1, "", "User");

            //Assert
            Assert.NotNull(allUsers);
            allUsers.UsersAndTheirRoles.Should().NotBeEmpty();
            allUsers.UsersAndTheirRoles.Should().AllBeOfType(typeof(UserAndRoleVm));
            allUsers.UsersAndTheirRoles.Should().HaveCount(3);

            Assert.NotNull(admins);
            admins.UsersAndTheirRoles.Should().NotBeEmpty();
            admins.UsersAndTheirRoles.Should().HaveCount(2);

            Assert.NotNull(usualUsers);
            usualUsers.UsersAndTheirRoles.Should().NotBeEmpty();
            usualUsers.UsersAndTheirRoles.Should().HaveCount(1);
        }

        [Fact]
        public void TestOfGettinfOneUser()
        {
            var user = new ApplicationUser()
            {
                UserName = "wuwuwu@gmail.com",
                UserRoles = new List<ApplicationUserRole>() { new ApplicationUserRole() { RoleId = "Admin" } }
            };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var userRepo = new Mock<IUsersRolesAndScoresRepository>();
            userRepo.Setup(u => u.GetUser(user.UserName)).Returns(user);
            var userServ = new UsersRolesAndScoresService(userRepo.Object, mapper);

            //Act
            var gettedUser = userServ.GetOneUser(user.UserName);

            //Assert
            Assert.NotNull(gettedUser);
            Assert.Equal(gettedUser.UserName, user.UserName);
        }

        [Fact]
        public void TestOfManagingScores()
        {
            var score = new Score() { Id = 1, UserLogin = "rere@gmail.com", BestResult = 16, CurrentResult = 16 };
            var resultAfterGoodAnswer = new ResultVm() { IsGood = true, CurrentResult = 16 };
            var resultAfterBadAnswer = new ResultVm() { IsGood = false, CurrentResult = 12 };
            var zero = 0;
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var scoreRepo = new Mock<IUsersRolesAndScoresRepository>();
            scoreRepo.Setup(s => s.GetScoreByUserLogin(score.UserLogin)).Returns(score);
            var scoreServ = new UsersRolesAndScoresService(scoreRepo.Object, mapper);

            var scoreAfterGoodQuestion = scoreServ.ManageScores(resultAfterGoodAnswer, score.UserLogin);


            Assert.NotNull(scoreAfterGoodQuestion);
            Assert.Equal(scoreAfterGoodQuestion.CurrentResult, score.CurrentResult);
            Assert.Equal(scoreAfterGoodQuestion.CurrentResult, score.BestResult);

            var scoreAfterBadQuestion = scoreServ.ManageScores(resultAfterBadAnswer, score.UserLogin);
            Assert.NotNull(scoreAfterBadQuestion);
            Assert.Equal(scoreAfterBadQuestion.CurrentResult, zero);
        }

        [Fact]
        public void TestOfGettingSortedScoreboard()
        {
            var scores = new List<Score>()
            {
                new Score()
                {
                    Id = 1,
                    UserLogin = "rere@gmail.com",
                    BestResult = 16,
                    CurrentResult = 16
                },
                new Score()
                {
                    Id = 2,
                    UserLogin = "huhu@gmail.com",
                    BestResult = 25,
                    CurrentResult = 17
                },
                new Score()
                {
                    Id = 3,
                    UserLogin = "popo@gmail.com",
                    BestResult = 10,
                    CurrentResult = 6
                },
                new Score()
                {
                    Id = 4,
                    UserLogin = "coco@gmail.com",
                    BestResult = 35,
                    CurrentResult = 28
                },
                new Score()
                {
                    Id = 5,
                    UserLogin = "mumu@gmail.com",
                    BestResult = 25,
                    CurrentResult = 15
                }
            };
            var config = new MapperConfiguration(conf =>
            {
                conf.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            var scoreRepo = new Mock<IUsersRolesAndScoresRepository>();
            scoreRepo.Setup(s => s.GetBestResults()).Returns(scores.AsQueryable());
            var scoreServ = new UsersRolesAndScoresService(scoreRepo.Object, mapper);

            var sortedScores = scoreServ.SortScores();

            //Assert
            sortedScores[0].BestResult.Should().BeGreaterOrEqualTo(sortedScores[1].BestResult);
            sortedScores[1].BestResult.Should().BeGreaterOrEqualTo(sortedScores[2].BestResult);
            sortedScores[2].BestResult.Should().BeGreaterOrEqualTo(sortedScores[3].BestResult);
        }
    }
}

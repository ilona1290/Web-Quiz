using AutoMapper;
using AutoMapper.QueryableExtensions;
using QuizMVC.Application.CategoryAndQuestionForAdminVm;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;
using QuizMVC.Application.StatsVm;
using QuizMVC.Application.UsersRolesAndScoresVm;
using QuizMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizMVC.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly ICategoryAndQuestionForAdminRepository _catQueAnsRepo;
        private readonly IUsersRolesAndScoresRepository _usersRolesAndScoresRepo;
        private readonly IStatsRepository _statsRepo;
        private readonly IMapper _mapper;
        public StatsService(ICategoryAndQuestionForAdminRepository catQueAnsRepo, IUsersRolesAndScoresRepository usersRolesAndScoresRepo, IStatsRepository statsRepo, IMapper mapper)
        {
            _catQueAnsRepo = catQueAnsRepo;
            _usersRolesAndScoresRepo = usersRolesAndScoresRepo;
            _statsRepo = statsRepo;
            _mapper = mapper;
        }

        public StatsOfCatQueAnsVm GetStatsAboutCatQueAns()
        {
            int counter = 1;
            int minCounter = int.MaxValue;
            int maxCounter = int.MinValue;
            string categoryWithTheMostQuestions = "empty";
            string categoryWithTheFewestQuestions = "empty";
            var questions = _catQueAnsRepo.ShowQuestions().ProjectTo<QuestionToListAdminVm>
                (_mapper.ConfigurationProvider).ToList();
            for (int i = 0; i < questions.Count; i++)
            {
                for (int j = i + 1; j < questions.Count; j++)
                {
                    if(questions[i].CategoryText == questions[j].CategoryText)
                    {
                        counter++;
                    }
                }
                if(maxCounter <= counter)
                {
                    maxCounter = counter;
                    categoryWithTheMostQuestions = questions[i].CategoryText;
                }
                if(minCounter >= counter)
                {
                    minCounter = counter;
                    categoryWithTheFewestQuestions = questions[i].CategoryText;
                }
                counter = 1;
            }
            StatsOfCatQueAnsVm statsOfCatQueAnsVm = new StatsOfCatQueAnsVm()
            {
                AmountOfCategories = _statsRepo.GetAmountOfCategories(),
                AmountOfQuestions = _statsRepo.GetAmountOfQuestions(),
                AmountOfAnswers = _statsRepo.GetAmountOfAnswers(),
                AmountOfGoodAnswers = _statsRepo.GetAmountOfGoodAnswers(),
                AmountOfNonAcceptedCategories = _statsRepo.GetAmountOfNonAcceptedCategories(),
                AmountOfNonAcceptedQuestions = _statsRepo.GetAmountOfNonAcceptedQuestions(),
                AmountOfNonAcceptedAnswers = _statsRepo.GetAmountOfNonAcceptedAnswers(),
                CategoryWithTheMostQuestions = categoryWithTheMostQuestions,
                CategoryWithTheFewestQuestions = categoryWithTheFewestQuestions,

            };
            return statsOfCatQueAnsVm;
        }

        public StatsOfUsersVm GetStatsAboutUsers()
        {
            List<string> superAdmins = new List<string>();
            List<string> admins = new List<string>();
            List<string> usualUsers= new List<string>();
            var users = _usersRolesAndScoresRepo.GetUsers().ProjectTo<UserAndRoleVm>
                (_mapper.ConfigurationProvider).ToList();
            foreach (var item in users)
            {
                if (item.UserRoles[0].Role.Id == "SuperAdmin")
                {
                    superAdmins.Add(item.UserName);
                }
                else if(item.UserRoles[0].Role.Id == "Admin")
                {
                    admins.Add(item.UserName);
                }
                else if(item.UserRoles[0].Role.Id == "User")
                {
                    usualUsers.Add(item.UserName);
                }
            }
            var bestScores = _usersRolesAndScoresRepo.GetBestResults().ProjectTo<ScoreVm>
                (_mapper.ConfigurationProvider).ToList();
            var sortedList = bestScores.OrderBy(i => i.BestResult).Reverse().ToList();
            StatsOfUsersVm statsOfUsersVm = new StatsOfUsersVm()
            {
                NumberOfRegisteredUsers = users.Count,
                NumberOfSuperAdmins = superAdmins.Count(),
                EmailsOfSuperAdmins = superAdmins,
                NumberOfAdmins = admins.Count(),
                EmailsOfAdmins = admins,
                NumberOfUsualUser = usualUsers.Count(),
                EmailsOfUsualUser = usualUsers,
                TheBestScore = sortedList[0].BestResult,
                EmailOfTheBestPlayer = sortedList[0].UserLogin,
                TheWorstScore = sortedList[sortedList.Count() - 1].BestResult,
                EmailOfTheWorstPlayer = sortedList[sortedList.Count() - 1].UserLogin
            };
            return statsOfUsersVm;
        }

        public OtherStatsVm GetOtherStats()
        {
            int counter = 1;
            int numberOfUsersWhoAnswerToAllQuestion = 0;
            List<string> usersWhoAnswerToAllQuestion = new List<string>();
            var numberOfCategories = _statsRepo.GetAmountOfCategories();
            var usersAndCategories = _statsRepo.GetUsersWhichAnsweredOnEveryQuestion().
                OrderBy(u => u.Username).ToList();
            for (int i = 1; i < usersAndCategories.Count(); i++)
            {
                if(usersAndCategories[i].Username == usersAndCategories[i - 1].Username)
                {
                    counter++;
                }
                else
                {
                    if(counter == numberOfCategories)
                    {
                        numberOfUsersWhoAnswerToAllQuestion++;
                        usersWhoAnswerToAllQuestion.Add(usersAndCategories[i - 1].Username);
                    }
                    counter = 1;
                }
            }
            if (counter == numberOfCategories)
            {
                numberOfUsersWhoAnswerToAllQuestion++;
                usersWhoAnswerToAllQuestion.Add(usersAndCategories[usersAndCategories.Count() - 1].Username);
            }

            var data = _statsRepo.GetDataFromQuestionsWithCorrectlyRespondsTable().OrderBy(u => u.QuestionId).ToList();
            int counter2 = 1;
            int maxCounter2 = 1;
            int minCounter2 = int.MaxValue;
            int questionIdOnWhichTheMostUsersAnsweredGood = 0;
            string questionOnWhichTheMostUsersAnsweredGood = "";
            int questionIdOnWhichTheLeastUsersAnsweredGood = 0;
            string questionOnWhichTheLeastUsersAnsweredGood = "";
            for (int i = 1; i < data.Count(); i++)
            {
                if(data[i].QuestionId == data[i - 1].QuestionId)
                {
                    counter2++;
                }
                else
                {
                    counter2 = 1;
                }
                if(maxCounter2 < counter2)
                {
                    maxCounter2 = counter2;
                    questionIdOnWhichTheMostUsersAnsweredGood = data[i].QuestionId;
                }
                if(minCounter2 > counter2)
                {
                    minCounter2 = counter;
                    questionIdOnWhichTheLeastUsersAnsweredGood = data[i].QuestionId;
                }
            }
            questionOnWhichTheMostUsersAnsweredGood = _catQueAnsRepo.ReturnDetailsOfQuestion(questionIdOnWhichTheMostUsersAnsweredGood)
                .QuestionText;
            questionOnWhichTheLeastUsersAnsweredGood = _catQueAnsRepo.ReturnDetailsOfQuestion(questionIdOnWhichTheLeastUsersAnsweredGood)
                .QuestionText;
            OtherStatsVm otherStatsVm = new OtherStatsVm()
            {
                NumberOfUsersWhoAnsweredToAllQuestions = numberOfUsersWhoAnswerToAllQuestion,
                UsersWhoAnsweredToAllQuestions = usersWhoAnswerToAllQuestion,
                QuestionOnWhichTheMostUsersAnsweredGood = questionOnWhichTheMostUsersAnsweredGood,
                QuestionOnWhichTheLeastUsersAnsweredGood = questionOnWhichTheLeastUsersAnsweredGood
            };
            return otherStatsVm;
        }
    }
}

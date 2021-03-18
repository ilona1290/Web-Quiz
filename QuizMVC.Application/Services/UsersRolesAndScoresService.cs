using AutoMapper;
using AutoMapper.QueryableExtensions;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;
using QuizMVC.Application.UsersRolesAndScoresVm;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Application.Services
{
    public class UsersRolesAndScoresService : IUsersRolesAndScoresService
    {
        private readonly IUsersRolesAndScoresRepository _usersRolesAndScoresRepo;
        private readonly IMapper _mapper;
        public UsersRolesAndScoresService(IUsersRolesAndScoresRepository usersRolesAndScoresRepo, IMapper mapper)
        {
            _usersRolesAndScoresRepo = usersRolesAndScoresRepo;
            _mapper = mapper;
        }

        public ListOfUsersWithRolesVm GetUsersAndTheirsRoles(int pageSize, int pageNo, string searchString, string roleId)
        {
            var users = new List<UserAndRoleVm>();
            if (roleId == "Nie wybieram żadnej roli")
            {
                users = _usersRolesAndScoresRepo.GetUsers().Where(u => u.UserName.StartsWith(searchString))
                    .ProjectTo<UserAndRoleVm>(_mapper.ConfigurationProvider).ToList();
            }
            else
            {
                users = _usersRolesAndScoresRepo.GetUsers().Where(u => u.UserName.StartsWith(searchString) &&
                    u.UserRoles.Where(r => r.RoleId == roleId).Any())
                    .ProjectTo<UserAndRoleVm>(_mapper.ConfigurationProvider).ToList();
            }
            var usersToShow = users.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            ApplicationRoleVm roleToList = new ApplicationRoleVm() { Name = "Nie wybieram żadnej roli" };
            var roles = _usersRolesAndScoresRepo.GetRoles().ProjectTo<ApplicationRoleVm>
                (_mapper.ConfigurationProvider).ToList();
            roles.Add(roleToList);
            ListOfUsersWithRolesVm listOfUsersWithRolesVm = new ListOfUsersWithRolesVm()
            {
                UsersAndTheirRoles = usersToShow,
                AllRoles = roles,
                Count = users.Count,
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString,
                RoleId = roleId
            };
            return listOfUsersWithRolesVm;
        }
        public DetailsOfUserVm GetOneUser(string name)
        {
            var user = _usersRolesAndScoresRepo.GetUser(name);
            var userVm = _mapper.Map<DetailsOfUserVm>(user);
            userVm.AllRoles = _usersRolesAndScoresRepo.GetRoles()
                .ProjectTo<ApplicationRoleVm>(_mapper.ConfigurationProvider).ToList();
            return userVm;
        }
        public void AddRoleToUser(string roleName, string userName)
        {
            var user = _usersRolesAndScoresRepo.GetUser(userName);
            var role = _usersRolesAndScoresRepo.GetRole(roleName);
            ApplicationUserRole applicationUserRole = new ApplicationUserRole()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
            _usersRolesAndScoresRepo.AddRoleToUser(user, applicationUserRole);
        }
        public void RemoveRole(string userName)
        {
            var user = _usersRolesAndScoresRepo.GetUser(userName);
            _usersRolesAndScoresRepo.RemoveUserRole(user);
        }
        public ResultVm ManageScores(ResultVm result, string currentUser)
        {
            var user = _usersRolesAndScoresRepo.GetScoreByUserLogin(currentUser);
            if (result.IsGood == true)
            {
                user.CurrentResult++;
            }
            else
            {
                user.CurrentResult = 0;
            }
            if (user.BestResult < user.CurrentResult)
            {
                user.BestResult = user.CurrentResult;
            }
            _usersRolesAndScoresRepo.UpdateScore(user);
            result.CurrentResult = user.CurrentResult;
            return result;
        }
        public List<Score> SortScores()
        {
            var scoresVm = _usersRolesAndScoresRepo.GetBestResults().ProjectTo<ScoreVm>
                (_mapper.ConfigurationProvider).ToList();
            var sortedList = scoresVm.OrderBy(i => i.BestResult).Reverse().ToList();
            for (int i = 1; i <= sortedList.Count; i++)
            {
                if (i != 1)
                {
                    if (sortedList[i - 1].BestResult != sortedList[i - 2].BestResult)
                    {
                        sortedList[i - 1].Place = i;
                    }
                    else
                    {
                        sortedList[i - 1].Place = i - 1;
                    }
                }
                else
                {
                    sortedList[0].Place = 1;
                }
            }
            List<Score> Scores = new List<Score>();
            foreach (var item in sortedList)
            {
                var score = _mapper.Map<Score>(item);
                Scores.Add(score);
            }
            _usersRolesAndScoresRepo.SavePlaceOnScoreBoard(Scores);
            return Scores;
        }
        public ScoresVm GetAllScores(int pageSize, int pageNo, string searchString)
        {
            var scores = _usersRolesAndScoresRepo.GetBestResults().Where(s => s.UserLogin.StartsWith(searchString))
                .ProjectTo<ScoreVm>(_mapper.ConfigurationProvider).ToList();
            var sortedScores = scores.OrderBy(i => i.Place).ToList();
            var scoresToShow = sortedScores.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            ScoresVm scoresVm = new ScoresVm()
            {
                BestResults = scoresToShow,
                Count = scores.Count,
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString
            };
            return scoresVm;
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuizMVC.Domain.Interface;
using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Infrastructure.Repositories
{
    public class UsersRolesAndScoresRepository : IUsersRolesAndScoresRepository
    {
        private readonly Context _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UsersRolesAndScoresRepository(Context context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IQueryable<ApplicationUser> GetUsers()
        {
            var users = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).AsQueryable();
            return users;
        }

        public IQueryable<ApplicationRole> GetRoles()
        {
            var roles = _roleManager.Roles?.AsQueryable();
            return roles;
        }

        public ApplicationUser GetUser(string name)
        {
            var user = _userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role)
                .FirstOrDefault(us => us.UserName == name);
            return user;
        }
        public ApplicationRole GetRole(string roleName)
        {
            var role = _roleManager.Roles.FirstOrDefault(r => r.Name == roleName);
            return role;
        }
        public void AddRoleToUser(ApplicationUser user, ApplicationUserRole applicationUserRole)
        {
            user.UserRoles.Add(applicationUserRole);
            _context.SaveChanges();
        }
        public void RemoveUserRole(ApplicationUser user)
        {
            user.UserRoles.Clear();
            _context.SaveChanges();
        }
        public Score GetScoreByUserLogin(string userLogin)
        {
            var user = _context.Scores.FirstOrDefault(u => u.UserLogin == userLogin);
            return user;
        }
        public void UpdateScore(Score user)
        {
            _context.Scores.Attach(user);
            _context.Entry(user).Property("BestResult").IsModified = true;
            _context.Entry(user).Property("CurrentResult").IsModified = true;
            _context.SaveChanges();
        }
        public void SavePlaceOnScoreBoard(List<Score> sortedList)
        {
            foreach (var item in sortedList)
            {
                _context.Scores.Attach(item);
                _context.Entry(item).Property("Place").IsModified = true;
                _context.SaveChanges();
            }

        }
        public IQueryable<Score> GetBestResults()
        {
            var bestResults = _context.Scores;
            return bestResults;
        }

        //public void DeleteResult(string userLogin)
        //{
        //    var user = _context.Scores.FirstOrDefault(u => u.UserLogin == userLogin);
        //    if (user != null)
        //    {
        //        _context.Scores.Remove(user);
        //        _context.SaveChanges();
        //    }
        //}

        //public void UpdateResult(Score updatingScore)
        //{
        //    _context.Scores.Update(updatingScore);
        //    _context.SaveChanges();
        //}
    }
}

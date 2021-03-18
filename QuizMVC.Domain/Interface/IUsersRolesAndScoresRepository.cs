using QuizMVC.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuizMVC.Domain.Interface
{
    public interface IUsersRolesAndScoresRepository
    {
        IQueryable<ApplicationUser> GetUsers();
        IQueryable<ApplicationRole> GetRoles();
        ApplicationUser GetUser(string name);
        ApplicationRole GetRole(string roleName);
        void AddRoleToUser(ApplicationUser user, ApplicationUserRole applicationUserRole);
        void RemoveUserRole(ApplicationUser user);
        Score GetScoreByUserLogin(string userLogin);
        void UpdateScore(Score user);
        void SavePlaceOnScoreBoard(List<Score> sortedList);
        IQueryable<Score> GetBestResults();
        //void DeleteResult(string userLogin);
        //void UpdateResult(Score updatingScore);
    }
}

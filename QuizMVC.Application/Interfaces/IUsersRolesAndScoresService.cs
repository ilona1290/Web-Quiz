using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.UsersRolesAndScoresVm;
using QuizMVC.Domain.Model;
using System.Collections.Generic;

namespace QuizMVC.Application.Interfaces
{
    public interface IUsersRolesAndScoresService
    {
        ListOfUsersWithRolesVm GetUsersAndTheirsRoles(int pageSize, int pageNo, string searchString, string roleId);
        DetailsOfUserVm GetOneUser(string name);
        void AddRoleToUser(string roleName, string userName);
        void RemoveRole(string userName);
        ResultVm ManageScores(ResultVm result, string currentUser);
        List<Score> SortScores();
        ScoresVm GetAllScores(int pageSize, int pageNo, string searchString);
    }
}

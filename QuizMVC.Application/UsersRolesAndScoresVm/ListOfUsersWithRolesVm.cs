using System.Collections.Generic;

namespace QuizMVC.Application.UsersRolesAndScoresVm
{
    public class ListOfUsersWithRolesVm
    {
        public List<UserAndRoleVm> UsersAndTheirRoles { get; set; }
        public List<ApplicationRoleVm> AllRoles { get; set; }
        public int Count { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public string RoleId { get; set; }
    }
}

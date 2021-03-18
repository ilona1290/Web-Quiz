using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizMVC.Application.CategoryAndQuestionVm;
using QuizMVC.Application.Interfaces;
using System;

namespace QuizMVC.Web.Controllers
{
    [Authorize]
    public class UsersRolesAndScoresController : Controller
    {
        private readonly IUsersRolesAndScoresService _usersRolesAndScoresService;

        public UsersRolesAndScoresController(IUsersRolesAndScoresService usersRolesAndScoresService)
        {
            _usersRolesAndScoresService = usersRolesAndScoresService;
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult ManageUsersRoles()
        {
            var usersWithRoles = _usersRolesAndScoresService.GetUsersAndTheirsRoles(4, 1, "", "Nie wybieram żadnej roli");
            return View(usersWithRoles);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public IActionResult ManageUsersRoles(int pageSize, int? pageNo, string searchString, string roleId)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (roleId is null)
            {
                roleId = "Nie wybieram żadnej roli";
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _usersRolesAndScoresService.GetUsersAndTheirsRoles(pageSize, pageNo.Value, searchString, roleId);
            return View(model);
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult AddRole(string userName, string roleName)
        {
            _usersRolesAndScoresService.AddRoleToUser(roleName, userName);
            return RedirectToAction("ManageUsersRoles");
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public IActionResult RemoveRole(string userName)
        {
            _usersRolesAndScoresService.RemoveRole(userName);
            return RedirectToAction("ManageUsersRoles");
        }
        [HttpGet]
        public IActionResult ManageScores(ResultVm result)
        {
            var currentUser = User.Identity.Name;
            var resultWithCurrentPoints = _usersRolesAndScoresService.ManageScores(result, currentUser);
            return View(resultWithCurrentPoints);
        }
        [HttpGet]
        public IActionResult GetAllScores()
        {
            _usersRolesAndScoresService.SortScores();
            var scores = _usersRolesAndScoresService.GetAllScores(4, 1, "");
            return View(scores);
        }
        [HttpPost]
        public IActionResult GetAllScores(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _usersRolesAndScoresService.GetAllScores(pageSize, pageNo.Value, searchString);
            return View(model);
        }
    }
}

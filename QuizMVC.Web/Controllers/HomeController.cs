using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizMVC.Web.Models;
using System.Diagnostics;

namespace QuizMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("User"))
                {
                    return RedirectToAction("ShowMenuForUser");
                }
                else
                {
                    return RedirectToAction("IndexAfterLogin");
                }
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public IActionResult IndexAfterLogin()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult ShowMenuForUser()
        {
            return View();
        }
        [Authorize]
        [Authorize(Roles = "Admin, SuperAdmin")]
        [HttpGet]
        public IActionResult ShowMenuForAdmin()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

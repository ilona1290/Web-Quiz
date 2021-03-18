using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizMVC.Application.Interfaces;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatsService _statsService;
        public StatisticsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet("StatsOfCategoriesQuestionsAndAnswers")]
        public IActionResult GetStatsOfQueCatAndAns()
        {
            var stats = _statsService.GetStatsAboutCatQueAns();
            if(stats == null)
            {
                return NoContent();
            }
            return Ok(stats);
        }

        [HttpGet("StatsOfUsers")]
        public IActionResult GetStatsOfUsers()
        {
            var stats = _statsService.GetStatsAboutUsers();
            if (stats == null)
            {
                return NoContent();
            }
            return Ok(stats);
        }
        [HttpGet("OtherStats")]
        public IActionResult GetOtherStats()
        {
            var stats = _statsService.GetOtherStats();
            if (stats == null)
            {
                return NoContent();
            }
            return Ok(stats);
        }
    }
}

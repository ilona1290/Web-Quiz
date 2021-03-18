using QuizMVC.Application.StatsVm;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMVC.Application.Interfaces
{
    public interface IStatsService
    {
        StatsOfCatQueAnsVm GetStatsAboutCatQueAns();
        StatsOfUsersVm GetStatsAboutUsers();
        OtherStatsVm GetOtherStats();
    }
}

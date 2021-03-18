using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMVC.Application.StatsVm
{
    public class StatsOfUsersVm
    {
        public int NumberOfRegisteredUsers { get; set; }
        public int NumberOfSuperAdmins { get; set; }
        public List<string> EmailsOfSuperAdmins{ get; set; }
        public int NumberOfAdmins { get; set; }
        public List<string> EmailsOfAdmins { get; set; }
        public int NumberOfUsualUser { get; set; }
        public List<string> EmailsOfUsualUser { get; set; }
        public int TheBestScore { get; set; }
        public string EmailOfTheBestPlayer { get; set; }
        public int TheWorstScore { get; set; }
        public string EmailOfTheWorstPlayer { get; set; }

    }
}

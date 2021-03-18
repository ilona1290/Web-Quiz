using Microsoft.Extensions.DependencyInjection;
using QuizMVC.Domain.Interface;
using QuizMVC.Infrastructure.Repositories;

namespace QuizMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICategoryAndQuestionRepository, CategoryAndQuestionRepository>();
            services.AddTransient<ICategoryAndQuestionForAdminRepository, CategoryAndQuestionForAdminRepository>();
            services.AddTransient<IUsersRolesAndScoresRepository, UsersRolesAndScoresRepository>();
            services.AddTransient<IStatsRepository, StatsRepository>();
            return services;
        }
    }
}

using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using QuizMVC.Application.Interfaces;
using QuizMVC.Application.Services;
using System.Reflection;

namespace QuizMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICategoryAndQuestionService, CategoryAndQuestionService>();
            services.AddTransient<ICategoryAndQuestionForAdminService, CategoryAndQuestionForAdminService>();
            services.AddTransient<IUsersRolesAndScoresService, UsersRolesAndScoresService>();
            services.AddTransient<IStatsService, StatsService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}

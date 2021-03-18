using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(QuizMVC.Web.Areas.Identity.IdentityHostingStartup))]
namespace QuizMVC.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}
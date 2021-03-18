using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace QuizMVC.Domain.Model
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}

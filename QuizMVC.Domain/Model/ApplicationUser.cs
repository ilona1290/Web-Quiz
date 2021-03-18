using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace QuizMVC.Domain.Model
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}

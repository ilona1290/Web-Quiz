using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuizMVC.Domain.Model;

namespace QuizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _config;
        
        public LoginController(IConfiguration config, SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _config = config;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] UserModel userModel)
        {
            IActionResult response = Unauthorized();
            var success = AuthenticateUser(userModel);

            if(success)
            {
                var tokenString = GenereteJsonWebToken(userModel);
                response = Ok(new { token = tokenString });
            }
            return response;
        }

        private object GenereteJsonWebToken(UserModel userModel)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"], null, expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private bool AuthenticateUser(UserModel userModel)
        {
            var result = _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, true, lockoutOnFailure: false).Result;
            return result.Succeeded;
        }
    }
}

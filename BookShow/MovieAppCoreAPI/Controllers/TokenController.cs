using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System;
using BookShowDAL;
using BookShowEntity;
using System.Linq;

namespace MovieAppCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly BookShowDbContext _context;

        public TokenController(IConfiguration config, BookShowDbContext context)
        {
            _configuration = config;
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Post(User _userData)
        {

            if (_userData != null && _userData.Email != null && _userData.Password != null)
            {
                var user = await GetUser(_userData.Email, _userData.Password);

                if (user != null)
                {
                    //create claims details based on the user information
                    var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.Id.ToString()),
                    new Claim("FirstName", user.Name),
                    new Claim("LastName", user.Email),
                    new Claim("Email", user.Password),
                   };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<User> GetUser(string email, string password)
        {
            User user = null;
            var result = _context.tbluser.Where(u => u.Email == email && u.Password == password);
            foreach (var item in result)
            {
                user = new User();
                user.Id= item.Id;
                user.Name= item.Name;
                user.Email= item.Email;
                user.Password = item.Password;
              
            }
            return user;

        }
    }
}



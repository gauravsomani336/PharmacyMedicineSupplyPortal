using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthorizationApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace AuthorizationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserModelsController : ControllerBase
    {
        private readonly UserModelContext _context;
        private IConfiguration _config;
        public UserModelsController(UserModelContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/UserModels
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UserModel>>> GetUsers()
        //{
        //    return await _context.Users.ToListAsync();
        //}

        
        // POST: api/UserModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [ActionName("GetAsync")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<string>> PostUserModel(UserModel userModel)
        {
            _context.Users.Add(userModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserModelExists(userModel.Username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return "OK";
            //return CreatedAtAction("GetUserModel", new { id = userModel.Username }, userModel);
        }

        [HttpGet]
        public async Task<IActionResult> LoginAsync(string username,string password)
        {
            IActionResult response = Unauthorized();
            var userModel = await _context.Users.FindAsync(username);

            if (userModel != null && userModel.password==password)
            {
                var tokenString = GenerateJSONWebToken(userModel);
                response = Ok(new { token = tokenString });
            }

            return response;
        }
        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        
        private bool UserModelExists(string id)
        {
            return _context.Users.Any(e => e.Username == id);
        }
    }
}

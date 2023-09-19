using ConsumirAPI.AuthService;
using ConsumirAPI.Data;
using ConsumirAPI.DbService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ConsumirAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordEncrypt _passwordEncrypt;

        public LoginController(IUnitOfWork unitOfWork, IPasswordEncrypt passwordEncrypt)
        {
            _unitOfWork = unitOfWork;
            _passwordEncrypt = passwordEncrypt;
        }

        [HttpGet]
        public async Task<IActionResult> GetLoginUsers()
        {
            var ListOfUsers = await _unitOfWork.loginRepository.getLoginUsers();
            return Ok(ListOfUsers);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            if (loginUser == null)
            {
                return BadRequest("Complete the Json Object");
            }else if (string.IsNullOrEmpty(loginUser.EmailLogin))
            {
                return BadRequest("Complete the Email");
            }else if (string.IsNullOrEmpty(loginUser.PasswordLogin)){
                return BadRequest("Complete the Password");
            }

            var user = await _unitOfWork.loginRepository.getLoginUser(loginUser);
            if (user == null)
            {
                return BadRequest("user not found");
            }

            var check = _passwordEncrypt.VerifyPassword(loginUser.PasswordLogin, user.PasswordLogin);
            if (check)
            {
                // JWT Logic
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddDays(60),
                    signingCredentials: signingCredentials
                    );

                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized("You dont have Access");
            }

        }
    }
}

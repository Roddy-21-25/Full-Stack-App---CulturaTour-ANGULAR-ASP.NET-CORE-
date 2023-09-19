using ConsumirAPI.AuthService;
using ConsumirAPI.Data;
using ConsumirAPI.DbService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsumirAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordEncrypt _passwordEncrypt;

        public SignUpController(IUnitOfWork unitOfWork, IPasswordEncrypt passwordEncrypt)
        {
            _unitOfWork = unitOfWork;
            _passwordEncrypt = passwordEncrypt;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpUser loginUser)
        {

            if (loginUser == null)
            {
                return BadRequest("Complete the Json Object");
            }
            else if (string.IsNullOrEmpty(loginUser.EmailSignUp))
            {
                return BadRequest("Complete the Email");
            }
            else if (string.IsNullOrEmpty(loginUser.PasswordSignUp))
            {
                return BadRequest("Complete the Password");
            }

            loginUser.PasswordSignUp = _passwordEncrypt.HashPassword(loginUser.PasswordSignUp);

            LoginUser loginUser1 = new LoginUser();
            loginUser1.EmailLogin = loginUser.EmailSignUp;
            loginUser1.PasswordLogin = loginUser.PasswordSignUp;

            await _unitOfWork.loginRepository.InsertLoginUser(loginUser1);

            var UserToSign = await _unitOfWork.sgnUpRepository.InsertLoginUser(loginUser);
            return Ok(UserToSign);
        }
    }
}

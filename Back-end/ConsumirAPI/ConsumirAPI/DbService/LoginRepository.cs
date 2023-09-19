using ConsumirAPI.AuthService;
using ConsumirAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsumirAPI.DbService
{
    public class LoginRepository : ILoginRepository
    {
        private readonly SegurityCulturaTourDbContext _dbContext;

        public LoginRepository(SegurityCulturaTourDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LoginUser>> getLoginUsers()
        {
            var LoginUsers = await _dbContext.LoginUsers.ToListAsync();
            return LoginUsers;
        }

        public async Task<LoginUser> getLoginUser(LoginUser loginUser)
        {
            var _loginUser = await _dbContext.LoginUsers.FirstOrDefaultAsync(
                x => x.EmailLogin.ToLower() == loginUser.EmailLogin.ToLower());
            return _loginUser;
        }

        public async Task<bool> InsertLoginUser(LoginUser loginUser)
        {
            var insertLoginUser = _dbContext.LoginUsers.AddAsync(loginUser);
            await _dbContext.SaveChangesAsync();
            return insertLoginUser != null;
        }
    }
}

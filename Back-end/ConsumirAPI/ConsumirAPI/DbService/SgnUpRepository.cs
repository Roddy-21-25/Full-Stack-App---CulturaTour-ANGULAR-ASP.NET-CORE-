using ConsumirAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsumirAPI.DbService
{
    public class SgnUpRepository : ISgnUpRepository
    {
        private readonly SegurityCulturaTourDbContext _dbContext;

        public SgnUpRepository(SegurityCulturaTourDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SignUpUser>> getLoginUsers()
        {
            var SignUpUsers = await _dbContext.SignUpUsers.ToListAsync();
            return SignUpUsers;
        }

        public async Task<bool> InsertLoginUser(SignUpUser loginUser)
        {
            var insertSignUpUser = _dbContext.SignUpUsers.AddAsync(loginUser);
            await _dbContext.SaveChangesAsync();
            return insertSignUpUser != null;
        }
    }
}

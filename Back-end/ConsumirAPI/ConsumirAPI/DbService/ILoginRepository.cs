using ConsumirAPI.Data;

namespace ConsumirAPI.DbService
{
    public interface ILoginRepository
    {
        Task<List<LoginUser>> getLoginUsers();
        Task<bool> InsertLoginUser(LoginUser loginUser);
        Task<LoginUser> getLoginUser(LoginUser loginUser);
    }
}
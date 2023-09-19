using ConsumirAPI.Data;

namespace ConsumirAPI.DbService
{
    public interface ISgnUpRepository
    {
        Task<List<SignUpUser>> getLoginUsers();
        Task<bool> InsertLoginUser(SignUpUser loginUser);
    }
}
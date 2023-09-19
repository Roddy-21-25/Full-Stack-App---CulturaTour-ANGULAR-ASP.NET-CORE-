namespace ConsumirAPI.DbService
{
    public interface IUnitOfWork : IDisposable
    {
        ILoginRepository loginRepository { get; }
        ISgnUpRepository sgnUpRepository { get; }
    }
}

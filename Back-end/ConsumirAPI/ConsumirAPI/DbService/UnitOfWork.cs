using ConsumirAPI.Data;

namespace ConsumirAPI.DbService
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ILoginRepository _loginRepository;
        private readonly ISgnUpRepository _sgnUpRepository;
        private SegurityCulturaTourDbContext _segurityCulturaTourDbContext;

        public UnitOfWork(SegurityCulturaTourDbContext segurityCulturaTourDbContext)
        {
            _segurityCulturaTourDbContext = segurityCulturaTourDbContext;
        }

        public ILoginRepository loginRepository => _loginRepository ?? new LoginRepository(_segurityCulturaTourDbContext);

        public ISgnUpRepository sgnUpRepository => _sgnUpRepository ?? new SgnUpRepository(_segurityCulturaTourDbContext);

        public void Dispose()
        {
            if(_segurityCulturaTourDbContext != null)
            {
                _segurityCulturaTourDbContext.Dispose();
            }
        }
    }
}

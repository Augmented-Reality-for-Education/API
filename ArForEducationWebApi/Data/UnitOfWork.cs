using ArForEducationWebApi.Repositories;
using ArForEducationWebApi.Repositories.Interfaces;

namespace ArForEducationWebApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;
        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IImageRepository ImageRepository => new ImageRepository(_databaseContext);

        public Task<int> SaveAsync()
        {
            return _databaseContext.SaveChangesAsync();
        }
    }
}

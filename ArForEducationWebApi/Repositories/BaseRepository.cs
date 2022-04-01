using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArForEducationWebApi.Repositories
{
    public abstract class BaseRepository<TE> : IBaseRepository<TE> where TE : EntityBase
    {
        private readonly DbSet<TE> _dbSet;

        protected BaseRepository(DbContext databaseContext)
        {
            _dbSet = databaseContext.Set<TE>();
        }

        public async Task DeleteAsync(TE e)
        {
            var entity = await _dbSet.FindAsync(e.Id);
            _dbSet.Remove(entity ?? throw new KeyNotFoundException());
        }

        public void Delete(IEnumerable<TE> tes)
        {
            _dbSet.RemoveRange(tes);
        }

        public IQueryable<TE> GetAll()
        {
            return _dbSet;
        }

        public async Task<TE> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id) ?? throw new KeyNotFoundException();
        }

        public IQueryable<TE> GetById(long id)
        {
            return _dbSet.Where(e => e.Id == id);
        }

        public async Task<TE> InsertAsync(TE e)
        {
            e.Created = DateTime.Now;
            var entry = await _dbSet.AddAsync(e);
            return entry.Entity;
        }

        public async Task InsertAsync(IEnumerable<TE> e)
        {
            foreach (var te in e)
            {
                te.Created = DateTime.Now;
            }
            await _dbSet.AddRangeAsync(e);
        }

        public TE Update(TE e)
        {
            e.LastModified = DateTime.Now;
            _dbSet.Update(e);
            return e;
        }

        public async Task DeleteByIdAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity ?? throw new KeyNotFoundException());
        }

        public IEnumerable<TE> UpdateAsync(IEnumerable<TE> tes)
        {
            var entityBases = tes.ToList();
            foreach (var te in entityBases)
            {
                te.LastModified = DateTime.Now;
            }

            _dbSet.UpdateRange(entityBases);
            return entityBases;
        }
    }
}

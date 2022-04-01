using ArForEducationWebApi.Domain;

namespace ArForEducationWebApi.Repositories.Interfaces
{
    public interface IBaseRepository<TE> where TE : EntityBase
    {
        void Delete(IEnumerable<TE> tes);
        Task DeleteAsync(TE e);
        Task DeleteByIdAsync(long id);
        IQueryable<TE> GetAll();
        Task<TE> GetByIdAsync(long id);
        IQueryable<TE> GetById(long id);
        Task<TE> InsertAsync(TE e);
        Task InsertAsync(IEnumerable<TE> e);
        TE Update(TE e);
        IEnumerable<TE> UpdateAsync(IEnumerable<TE> tes);
    }
}

using ArForEducationWebApi.Repositories.Interfaces;

namespace ArForEducationWebApi.Data
{
    public interface IUnitOfWork
    {
        Task<int> SaveAsync();

        IImageRepository ImageRepository { get;  }
        ISequenceRepository SequenceRepository { get; }
    }
}

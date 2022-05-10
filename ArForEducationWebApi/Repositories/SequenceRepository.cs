using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArForEducationWebApi.Repositories;

public class SequenceRepository : BaseRepository<Sequence>, ISequenceRepository
{
    public SequenceRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}

using ArForEducationWebApi.Domain;
using ArForEducationWebApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArForEducationWebApi.Repositories;

public class ImageRepository : BaseRepository<Image>, IImageRepository
{
    public ImageRepository(DbContext databaseContext) : base(databaseContext)
    {
    }
}
using ArForEducationWebApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArForEducationWebApi.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Image> Images { get; set; }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
}
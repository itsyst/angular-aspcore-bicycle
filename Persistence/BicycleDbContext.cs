using angular_aspcore_bicycle.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_aspcore_bicycle.Persistence;

public class BicycleDbContext : DbContext
{
    public BicycleDbContext(DbContextOptions<BicycleDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<Model> Models { get; set; }
    public DbSet<Make> Makes { get; set; }
}

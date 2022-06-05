using Bicycle.Models;
using Microsoft.EntityFrameworkCore;

namespace Bicycle.Persistence;

public class BicycleDbContext : DbContext
{
    public BicycleDbContext(DbContextOptions<BicycleDbContext> options)
    : base(options)
    {

    }

    public DbSet<Model>? Models { get; set; }
    public DbSet<Make>? Makes { get; set; }
}

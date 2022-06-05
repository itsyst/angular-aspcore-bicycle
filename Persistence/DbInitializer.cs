using Bicycle.Interfaces;
using Bicycle.Models;
using Microsoft.EntityFrameworkCore;

namespace Bicycle.Persistence;

public class DbInitializer : IDbInitializer
{
    private readonly BicycleDbContext _context;
    private readonly ILogger<DbInitializer> _logger;

    public DbInitializer(BicycleDbContext context, ILogger<DbInitializer> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void Initialize()
    {
        //Run if migrations are not applied
        try
        {
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
        }

        // Create Models & Makes
        if (!_context.Models.Any())
        {
            _context.Models.AddRange(new List<Model>()
            {
                new Model(){
                    Name = "Strada",
                    Make = new Make(){
                        Name = "3T"
                    }
                },
                new Model(){
                    Name = "Socorro",
                    Make = new Make(){
                        Name = "Batavus"
                    }
                },
                new Model(){
                    Name = "Morning",
                    Make = new Make(){
                        Name = "Eovolt"
                    }
                },
            });
            _context.SaveChanges();
        }
    }
}

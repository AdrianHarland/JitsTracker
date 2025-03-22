using JitsTrackerBE.Data.Enitities;

namespace JitsTrackerBE.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<TechniqueEntity> Techniques { get; set; }
    public DbSet<MoveEntity> Moves { get; set; }
}

using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Techniques;

namespace JitsTrackerBE.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<TechniqueEntity> Techniques { get; set; }
    public DbSet<MoveEntity> Moves { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
    }
    
}

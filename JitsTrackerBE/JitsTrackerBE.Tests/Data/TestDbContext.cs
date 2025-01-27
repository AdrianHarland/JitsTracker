using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Tests.Data;

public class TestDbContext : DbContext
{
    public DbSet<TEntity> TEntities { get; set; }

    public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
    {
        
    }
}
public class TEntity
{
 public int Id { get; set; }
 public string TName { get; set; }
}
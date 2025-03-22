using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Tests.Data;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Tests.Features.Techniques.Unit;

public interface ITestTechniqueHandler
{
    Task<List<TEntity>> GetAllEntitiesAsync();
}

public class TestTechniqueHandler : ITestTechniqueHandler
{
    private readonly TestDbContext _testDbContext;

    public TestTechniqueHandler(TestDbContext testDbContext)
    {
        _testDbContext = testDbContext;
    }

    public async Task<List<TEntity>> GetAllEntitiesAsync()
    {
        return await _testDbContext.TEntities.ToListAsync();
    }

}


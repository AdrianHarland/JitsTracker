using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Features.Techniques;

public class TechniqueGeneratorHandler : ITechniqueGeneratorHandler //handler that encapsulates the business logic
{
    private readonly AppDbContext _dbContext; //value can only be set during initialization or in the constructor.

    public TechniqueGeneratorHandler(AppDbContext dbContext) //constructor to create db context without a new db instance
    {
        _dbContext = dbContext;
    }

    public async Task<string> HandleAsync()
    {
        var totalCount = await _dbContext.Techniques.CountAsync();
        var randomIndex = new Random().Next(0, totalCount);
        var result = await _dbContext.Techniques
            .Skip(randomIndex)                // Skip rows to the random offset
            .Take(1)                          // Fetch only the row at the random index
            .Select(t => t.TechniqueName)     // Select the column you need
            .FirstOrDefaultAsync();          
        
        if (result == null)
        {
            throw new InvalidOperationException("No techniques try gain");
        }
        return result;
    }
    
}

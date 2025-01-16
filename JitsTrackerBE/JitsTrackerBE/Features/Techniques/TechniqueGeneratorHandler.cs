using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Moves;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Features.Techniques;

public class TechniqueGeneratorHandler : ITechniqueGeneratorHandler //handler that encapsulates the business logic
{
    private readonly AppDbContext _dbContext; //value can only be set during initialization or in the constructor.

    public
        TechniqueGeneratorHandler(AppDbContext dbContext) //constructor to create db context without a new db instance
    {
        _dbContext = dbContext;
    }

    public async Task<TechniqueDto> HandleAsync()
    {
        var totalCount = await _dbContext.Techniques.CountAsync();
        var randomIndex = new Random().Next(0, totalCount);
        var result = await _dbContext.Techniques
            .Include(t => t.Moves)
            .Skip(randomIndex)
            .Take(1)
            .FirstOrDefaultAsync();

        if (result == null)
        {
            throw new InvalidOperationException("No techniques try gain");
        }

        return new TechniqueDto
        {
            Id = result.Id,
            TechniqueName = result.TechniqueName,
            Moves = result.Moves.Select(m => new MoveDto
            {
                Id = m.Id,
                MoveName = m.MoveName
            }).ToList()
        };
    }
}
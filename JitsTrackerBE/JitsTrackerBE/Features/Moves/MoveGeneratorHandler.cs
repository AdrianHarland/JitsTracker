using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Techniques;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Features.Moves;

public class MoveGeneratorHandler : IMoveGeneratorHandler
{
     private readonly AppDbContext _dbContext;

     //Constructor
     public MoveGeneratorHandler(AppDbContext dbContext)
     {
          _dbContext = dbContext;
     }
     
     public async Task<MoveEntity> HandleAsync()
     
     {
          
          var result = await _dbContext.Moves
               .Include(m => m.Technique) 
               .Take(1)
               .FirstOrDefaultAsync();
          return result;
          
          // var totalCount = await _dbContext.Moves.CountAsync();
          // var randomIndex = new Random().Next(0, totalCount);
          // var result = _dbContext.Moves
          //      .ToList();
          // var authorWithBooks = context.Authors
          //      .Include(a => a.Books) // Include related Books
          //      .FirstOrDefault(a => a.Name == "J.K. Rowling");
          //      .Skip(randomIndex)
          //      .Take(1)
          //      .Select(m => m.TechniqueId)
          //      .ToList();
          
          // if (result == null)
          // {
          //      throw new InvalidOperationException("No moves try again");
          // }
          // return result;
     }
}
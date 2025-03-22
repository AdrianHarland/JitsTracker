using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Techniques;
using JitsTrackerBE.Tests.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;

namespace JitsTrackerBE.Tests.Features.Techniques.Unit;

public class TechniqueGeneratorHandlerTests
{
//     [Fact]
//     public async Task HandleAsync_NoResults_ThrowsInvalidOperationException() // Aadam ignore as I wanted to make sure I could get it working first
//     {
//         //Arrange
//         var options = new DbContextOptionsBuilder<TestDbContext>()
//             .UseInMemoryDatabase(databaseName: "TestDb")
//             .Options;
//
//         using (var context = new TestDbContext(options))
//         {
//             context.TEntities.AddRange(new List<TEntity>
//             {
//                 new TEntity { Id = 1, TName = "RNC" },
//                 new TEntity { Id = 2, TName = "Heel Hook" }
//             });
//             context.SaveChanges();
//         }
//
//         using (var context = new TestDbContext(options))
//         {
//             var service = new TestTechniqueHandler(context);
//
//             //Act
//
//             var result = await service.GetAllEntitiesAsync();
//
//             //Assert
//             Assert.Equal(2, result.Count);
//             Assert.Contains(result, e => e.TName == "RNC");
//             Assert.Contains(result, e => e.TName == "Heel Hook");
//         }
//     }

    [Fact]
    public async Task HandleAsync_NoResults_ThrowsInvalidOperationException()
    {
        //Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        using (var context = new AppDbContext(options))
        {
            context.Techniques.AddRange(new List<TechniqueEntity>
            {
                //Mimic no results
            });
            context.SaveChanges();

            var sut = new TechniqueGeneratorHandler(context);
            await sut.HandleAsync();
        }
        //Act

        //Assert
        
    }
}

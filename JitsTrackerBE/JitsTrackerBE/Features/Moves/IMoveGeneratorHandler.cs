using JitsTrackerBE.Data.Enitities;

namespace JitsTrackerBE.Features.Moves;

public interface IMoveGeneratorHandler
{
    Task<List<MoveEntity>> HandleAsync();
}
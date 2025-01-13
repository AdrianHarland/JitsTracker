using JitsTrackerBE.Data.Enitities;

namespace JitsTrackerBE.Features.Techniques;

public interface ITechniqueGeneratorHandler
{
    Task<string> HandleAsync();
}
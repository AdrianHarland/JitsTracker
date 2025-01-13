using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Techniques;
using Microsoft.AspNetCore.Mvc;

namespace JitsTrackerBE.Features.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TechniqueGeneratorController : ControllerBase
{
    private readonly ITechniqueGeneratorHandler _techniqueHandler;

    public TechniqueGeneratorController(ITechniqueGeneratorHandler techniqueHandler)
    {
        _techniqueHandler = techniqueHandler;
    }

    /// <summary>
    /// Get Random Technique 
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(TechniqueGeneratorHandler), StatusCodes.Status200OK)]
    public async Task<ActionResult<TechniqueEntity>> GetRandomTechniqueAsync()
    {
        var randomTechnique = await _techniqueHandler.HandleAsync();
        return Ok(randomTechnique);
    }
}
using JitsTrackerBE.Features.Techniques.Models;
using JitsTrackerBE.Features.Techniques.TechniqueGeneratorHandler;
using Microsoft.AspNetCore.Mvc;

namespace JitsTrackerBE.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TechniqueGeneratorController : ControllerBase
{

    private readonly TechniqueGeneratorHandler _techniqueHandler;
 
    public TechniqueGeneratorController(TechniqueGeneratorHandler techniqueHandler)
    {
        _techniqueHandler = techniqueHandler;
    }
    
    /// <summary>
    /// Get Random Technique 
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(TechniqueGeneratorDto), StatusCodes.Status200OK)]
    public IActionResult GetRandomTechniqueAsync()
    {
        var results= _techniqueHandler.TechniqueGenerator();
        return Ok(results);
    }
    
}

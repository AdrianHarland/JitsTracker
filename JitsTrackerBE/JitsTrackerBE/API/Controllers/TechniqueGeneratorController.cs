using JitsTrackerBE.Features.Techniques.Models;
using JitsTrackerBE.Features.Techniques.TechniqueGeneratorHandler;
using Microsoft.AspNetCore.Mvc;

namespace JitsTrackerBE.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class TechniqueGeneratorController : ControllerBase
{

    private readonly TechniqueGeneratorHandler _handler;

    public TechniqueGeneratorController(TechniqueGeneratorHandler handler)
    {
        _handler = handler;
    }
    
    /// <summary>
    /// Get Random Technique 
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(TechniqueGeneratorDto), StatusCodes.Status200OK)]
    public IActionResult GetRandomTechniqueAsync()
    {
        var results = _handler.TechniqueGenerator();
        return Ok(results);
    }
}

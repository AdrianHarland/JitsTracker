using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Moves;
using Microsoft.AspNetCore.Mvc;

namespace JitsTrackerBE.Features.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MoveGeneratorController : ControllerBase
{
    private readonly IMoveGeneratorHandler _moveHandler;
    
    public MoveGeneratorController(IMoveGeneratorHandler moveHandler)
    {
        _moveHandler = moveHandler;
    }

    /// <summary>
    /// Get Random Move Based of Technique 
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(MoveGeneratorHandler), StatusCodes.Status200OK)]
    public async Task<ActionResult<MoveEntity>> GetRandomMoveAsync()
    {
        var randomMove = await _moveHandler.HandleAsync();
        return Ok(randomMove);
    }
    }
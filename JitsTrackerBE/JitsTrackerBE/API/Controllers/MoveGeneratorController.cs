using JitsTrackerBE.Features.Techniques.Models;
using JitsTrackerBE.Features.Techniques.MoveGeneratorHandler;
using Microsoft.AspNetCore.Mvc;

namespace JitsTrackerBE.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MoveGeneratorController : ControllerBase
{
    private readonly MoveGeneratorHandler _moveHandler;
    
    public MoveGeneratorController(MoveGeneratorHandler moveHandler)
    {
        _moveHandler = moveHandler;
    }
          
        /// <summary>
        /// Get Random Technique 
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(MoveGeneratorDto), StatusCodes.Status200OK)]
        public IActionResult GetRandomMoveAsync()
        {
            var results = _moveHandler.MoveGenerator();
            return Ok(results);
        }

    }
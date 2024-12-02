namespace JitsTrackerBE.Features.Techniques.MoveGeneratorHandler;

public class MoveGeneratorHandler
{
     //Field to assign value
     private readonly TechniqueGeneratorHandler.TechniqueGeneratorHandler _techniqueGeneratorHandler;
     
     //Constructor
     public MoveGeneratorHandler(TechniqueGeneratorHandler.TechniqueGeneratorHandler techniqueGeneratorHandler)
     {
          _techniqueGeneratorHandler = techniqueGeneratorHandler;
     }
          
     public string MoveGenerator()
     {
          var result = _techniqueGeneratorHandler.TechniqueGenerator();
          return result.RandomTechnique;
     }
}
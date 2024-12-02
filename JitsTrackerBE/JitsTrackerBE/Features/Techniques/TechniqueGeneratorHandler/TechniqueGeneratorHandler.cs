using JitsTrackerBE.Features.Techniques.Models;

namespace JitsTrackerBE.Features.Techniques.TechniqueGeneratorHandler;

public class TechniqueGeneratorHandler
{
    public TechniqueGeneratorDto TechniqueGenerator()
    { 
        Random rnd = new();
        string[] randomTechnique = {"Sweep", "Takedown", "Pin", "Submission"};
        int rtIndex = rnd.Next(randomTechnique.Length);
        return new TechniqueGeneratorDto
        {
            RandomTechnique = randomTechnique[rtIndex]
        };
    }
}
namespace JitsTrackerBE.Features.Techniques.TechniqueGenerator;


public class TechniqueGenerator
{
     public TechniqueGenerator(){ 
          Random rnd = new();
          string[] randomTechnique = ["Sweep", "Takedown", "Pin", "Submission"];
          var rtIndex = rnd.Next(randomTechnique.Length);
          Console.WriteLine(randomTechnique[rtIndex]);
     }
};

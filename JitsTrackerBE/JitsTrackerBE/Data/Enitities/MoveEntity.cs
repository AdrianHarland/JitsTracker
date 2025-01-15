namespace JitsTrackerBE.Data.Enitities;

public class MoveEntity
{
    public int Id { get; set; }

    public int TechniqueId { get; set; }

    public TechniqueEntity Technique { get; set; } 
    public string MoveName { get; set; }
}
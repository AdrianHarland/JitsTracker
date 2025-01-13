namespace JitsTrackerBE.Data.Enitities;

public class MoveEntity
{
    public int Id { get; set; }
    public TechniqueEntity TechniqueId { get; set; } 
    public string MoveName { get; set; }
}
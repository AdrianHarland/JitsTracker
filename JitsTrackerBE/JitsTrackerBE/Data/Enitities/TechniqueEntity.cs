namespace JitsTrackerBE.Data.Enitities;

public class TechniqueEntity
{
    public int Id { get; set; }
    public string TechniqueName { get; set; }
    public ICollection<MoveEntity> Moves { get; set; }
}
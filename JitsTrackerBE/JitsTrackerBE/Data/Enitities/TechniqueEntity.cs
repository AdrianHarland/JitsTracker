namespace JitsTrackerBE.Data.Enitities;

public class TechniqueEntity
{
    public int Id { get; set; }
    public string TechniqueName { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    
    public ICollection<MoveEntity> Moves { get; set; }
}
namespace JitsTrackerBE.Features.Techniques.Models;

public class MoveGeneratorDto
{
    public IEnumerable<SubsDto> Subs { get; set; } = Enumerable.Empty<SubsDto>();
    public IEnumerable<TakedownsDto> Takedowns { get; set; } = Enumerable.Empty<TakedownsDto>();
    public IEnumerable<PinsDTO> Pins { get; set; } = Enumerable.Empty<PinsDTO>();
    public IEnumerable<SweepsDto> Sweeps { get; set; } = Enumerable.Empty<SweepsDto>();

}
public class SubsDto
{
    public string RNC { get; set; }
    public string HeelHook { get; set; }
    public string ArmBar { get; set; }
}

public class TakedownsDto
{
 public string DoubleLeg { get; set; }
 public string SingleLeg { get; set; }
 public string AnklePick { get; set; }
}

public class PinsDTO
{
    public string Sidecontrol { get; set; }
    public string Mount { get; set; }
    public string NorthSouth { get; set; }
}

public class SweepsDto
{
    public string Pendulum { get; set; }
    public string Scissor { get; set; }
    public string ButterFly { get; set; }
}


// public class SubsDto
// { 
//     public string Name { get; set; }
// }
//
// var subs = new List<SubsDto>
// {
//     new SubsDto { Name = "RNC" },
//     new SubsDto { Name = "HeelHook" },
//     new SubsDto { Name = "ArmBar" }
// };
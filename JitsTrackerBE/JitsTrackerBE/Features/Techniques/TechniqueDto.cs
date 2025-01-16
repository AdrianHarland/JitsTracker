using JitsTrackerBE.Data;
using JitsTrackerBE.Data.Enitities;
using JitsTrackerBE.Features.Moves;
using Microsoft.EntityFrameworkCore;

namespace JitsTrackerBE.Features.Techniques
{
    public class TechniqueDto
    {
        public int Id { get; set; }
        public string TechniqueName { get; set; }
        public ICollection<MoveDto> Moves { get; set; } = new List<MoveDto>();
    }
}
using LabourMarketSimulation.Interfaces;

namespace LabourMarketSimulation.Models
{
    public class SimpleAdvantage : IAdvantage
    {
        public required string Name { get; set; }
        public required int Priority { get; set; }
    }
}
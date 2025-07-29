using LabourMarketSimulation.Interfaces;

namespace LabourMarketSimulation.Models
{
    public class Employer : ModelParticipant
    {
        public Employer(IPriorityStrategy priorityStrategy,
                        IEnumerable<IAdvantage> advantages,
                        IEnumerable<IAdvantage> requirements) 
            : base(priorityStrategy, advantages, requirements)
        {
            
        }
    }
}

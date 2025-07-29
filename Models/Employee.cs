using LabourMarketSimulation.Interfaces;

namespace LabourMarketSimulation.Models
{
    public class Employee : ModelParticipant
    {
        public Employee(IPriorityStrategy priorityStrategy,
                        IEnumerable<IAdvantage> advantages,
                        IEnumerable<IAdvantage> requirements)
            : base(priorityStrategy, advantages, requirements)
        {

        }
    }
}

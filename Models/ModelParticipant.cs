using LabourMarketSimulation.Interfaces;

namespace LabourMarketSimulation.Models
{
    public abstract class ModelParticipant : IPrioritizable
    {
        public IPriorityStrategy ChooseParticipantStrategy { get; set; }
        public IEnumerable<IAdvantage> AdvantagesList { get; set; }
        public IEnumerable<IAdvantage> RequirementsList { get; set; }

        protected ModelParticipant(IPriorityStrategy priorityStrategy, 
                                IEnumerable<IAdvantage> advantages, 
                                IEnumerable<IAdvantage> requirements) 
        {
            ChooseParticipantStrategy = priorityStrategy;
            AdvantagesList = advantages;
            RequirementsList = requirements;
        }
    }
}
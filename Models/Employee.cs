using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Models
{
    public class Employee : IParticipant, IPrioritizer<Employer>
    {
        public ICollection<IEmployeeSkill>? Skills { get; set; }
        public ICollection<IEmployeeRequirement>? Requirements { get; set; }

        public int? GetPriority(Employer? member) 
        {
            return 1;
        }
    }
}

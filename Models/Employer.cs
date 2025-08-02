using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Models
{
    public class Employer : IParticipant, IPrioritizer<Employee>
    {
        public ICollection<IEmployerRequirement>? Requirements { get; set; }
        public ICollection<IEmployerAdvantage>? Advantages { get; set; }
        public int? GetPriority(Employee? member)
        {
            return 1;
        }
    }
}

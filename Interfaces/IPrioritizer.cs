using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Interfaces
{
    public interface IPrioritizer<T> where T : IParticipant
    {
        public int? GetPriority(T? member);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Registries
{
    public class RegistriesConfig
    {
        public List<string> EmployeeSkills { get; set; } = new();
        public List<string> EmployeeRequirements { get; set; } = new();
        public List<string> EmployerAdvantages { get; set; } = new();
        public List<string> EmployerRequirements { get; set; } = new();
    }
}

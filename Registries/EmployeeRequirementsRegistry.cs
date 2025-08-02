using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Registries
{
    public class EmployeeRequirementsRegistry
    {
        private readonly HashSet<Type> _allowedRequirements = new();
        public IReadOnlyCollection<Type> AllowedRequirements => _allowedRequirements;

        public void RegisterRequirementType<T>() where T : IEmployeeRequirement
        {
            _allowedRequirements.Add(typeof(T));
        }

        public bool IsRequirementAllowed(IEmployeeRequirement skill) =>
            _allowedRequirements.Contains(skill.GetType());
    }
}

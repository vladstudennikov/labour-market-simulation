using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Registries
{
    public class EmployerAdvantagesRegistry
    {
        private readonly HashSet<Type> _allowedAdvantages = new();
        public IReadOnlyCollection<Type> AllowedAdvantages => _allowedAdvantages;

        public void RegisterRequirementType<T>() where T : IEmployerAdvantage
        {
            _allowedAdvantages.Add(typeof(T));
        }

        public bool IsAdvantageAllowed(IEmployerAdvantage skill) =>
            _allowedAdvantages.Contains(skill.GetType());
    }
}

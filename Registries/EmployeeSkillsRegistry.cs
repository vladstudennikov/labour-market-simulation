using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Registries
{
    public class EmployeeSkillsRegistry
    {
        private readonly HashSet<Type> _allowedSkills = new();

        public void RegisterRequirementType<T>() where T : IEmployeeSkill
        {
            _allowedSkills.Add(typeof(T));
        }

        public bool IsSkillAllowed(IEmployeeSkill skill) =>
            _allowedSkills.Contains(skill.GetType());
    }
}

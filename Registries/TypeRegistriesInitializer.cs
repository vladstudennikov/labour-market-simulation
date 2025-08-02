using LabourMarketSimulation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LabourMarketSimulation.Registries
{
    public class TypeRegistriesInitializer
    {
        public static RegistriesConfig Config { get; private set; } = new();

        public static EmployeeSkillsRegistry EmployeeSkills { get; private set; } = new();
        public static EmployeeRequirementsRegistry EmployeeRequirements { get; private set; } = new();
        public static EmployerAdvantagesRegistry EmployerAdvantages { get; private set; } = new();
        public static EmployerRequirementsRegistry EmployerRequirements { get; private set; } = new();

        public static void Init(string configPath = "allowedTypes.json")
        {
            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"Registries initializing: config file not found: {configPath}");
            }

            string json = File.ReadAllText(configPath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Config = JsonSerializer.Deserialize<RegistriesConfig>(json, options)
                     ?? throw new InvalidOperationException("Failed to deserialize type config.");

            EmployeeSkills = new();
            EmployeeRequirements = new();
            EmployerAdvantages = new();
            EmployerRequirements = new();

            LoadTypes<IEmployeeSkill>(Config.EmployeeSkills, EmployeeSkills.AllowedSkills, "EmployeeSkills");
            LoadTypes<IEmployeeRequirement>(Config.EmployeeRequirements, EmployeeRequirements.AllowedRequirements, "EmployeeRequirements");
            LoadTypes<IEmployerAdvantage>(Config.EmployerAdvantages, EmployerAdvantages.AllowedAdvantages, "EmployerAdvantages");
            LoadTypes<IEmployerRequirement>(Config.EmployerRequirements, EmployerRequirements.AllowedRequirements, "EmployerRequirements");
        }

        private static void LoadTypes<TInterface>(
            IEnumerable<string> typeNames,
            IReadOnlyCollection<Type> destination,
            string groupName)
        {
            foreach (var name in typeNames)
            {
                var type = Type.GetType(name, throwOnError: false);

                if (type == null)
                {
                    Console.WriteLine($"Type '{name}' in '{groupName}' could not be found.");
                    continue;
                }

                if (!typeof(TInterface).IsAssignableFrom(type))
                {
                    Console.WriteLine($"Type '{name}' in '{groupName}' does not implement {typeof(TInterface).Name}.");
                    continue;
                }

                destination.Add(type);
            }
        }
    }
}

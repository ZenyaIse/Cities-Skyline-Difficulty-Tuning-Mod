using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class Economy : EconomyExtensionBase
    {
        public override int OnAddResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
        {
            if (resource == EconomyResource.RewardAmount)
            {
                DifficultyManager d = Singleton<DifficultyManager>.instance;

                return amount; // (int)(amount * d.RewardMultiplier.Value);
            }

            return amount;
        }

        public override int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            if (service == Service.Road)
            {
                return (int)(originalConstructionCost * d.ConstructionCostMultiplier_Road.Value);
            }
            else if (service == Service.PublicTransport)
            {
                return (int)(originalConstructionCost * d.ConstructionCostMultiplier_Public.Value);
            }
            else if (service == Service.Education || service == Service.Electricity || service == Service.FireDepartment ||
                service == Service.Garbage || service == Service.HealthCare || service == Service.PoliceDepartment || service == Service.Water)
            {
                return (int)(originalConstructionCost * d.ConstructionCostMultiplier_Service.Value);
            }

            return (int)(originalConstructionCost * d.ConstructionCostMultiplier.Value);
        }

        public override int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (service == Service.Road)
            {
                return (int)(originalMaintenanceCost * d.MaintenanceCostMultiplier_Road.Value);
            }
            else if (service == Service.PublicTransport)
            {
                return (int)(originalMaintenanceCost * d.MaintenanceCostMultiplier_Public.Value);
            }
            else if (service == Service.Education || service == Service.Electricity || service == Service.FireDepartment ||
                service == Service.Garbage || service == Service.HealthCare || service == Service.PoliceDepartment || service == Service.Water)
            {
                return (int)(originalMaintenanceCost * d.MaintenanceCostMultiplier_Service.Value);
            }

            return (int)(originalMaintenanceCost * d.MaintenanceCostMultiplier.Value);
        }

        public override int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            return constructionCost; // (int)(constructionCost * d.RelocationCostMultiplier.Value);
        }

        public override int OnGetRefundAmount(int constructionCost, int refundAmount, Service service, SubService subService, Level level)
        {
            // TODO: make optional
            if (service == Service.Road)
            {
                return constructionCost;
            }

            return refundAmount;
        }
    }
}

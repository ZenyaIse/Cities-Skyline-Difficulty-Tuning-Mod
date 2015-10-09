using ICities;
//using ColossalFramework.Plugins;

namespace DifficultyTuningMod
{
    public class Economy : EconomyExtensionBase
    {
        public override int OnAddResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
        {
            if (resource == EconomyResource.RewardAmount)
            {
                DifficultyOptions d = Singleton<DifficultyOptions>.instance;
            
                return (int)(amount * d.RewardMultiplier.Value);
            }

            return amount;
        }

        public override int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level)
        {
            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
            
            if (service == Service.Road)
            {
                return (int)(originalConstructionCost * d.RoadConstructionCostMultiplier.Value);
            }

            return (int)(originalConstructionCost * d.ConstructionCostMultiplier.Value);
        }

        public override int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level)
        {
            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
            
            if (service == Service.Road)
            {
                return (int)(originalMaintenanceCost * DifficultyOptions.RoadMaintenanceCostMultiplier);
            }

            return (int)(originalMaintenanceCost * DifficultyOptions.MaintenanceCostMultiplier);
        }

        public override int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level)
        {
            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
            
            return (int)(constructionCost * d.RelocationCostMultiplier.Value);
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

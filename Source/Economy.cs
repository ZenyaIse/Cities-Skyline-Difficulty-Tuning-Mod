using System;
using ICities;

namespace DifficultyTuningMod
{
    public class Economy : EconomyExtensionBase
    {
        public override int OnAddResource(EconomyResource resource, int amount, Service service, SubService subService, Level level)
        {
            if (resource == EconomyResource.RewardAmount)
            {
                return (int)(amount * DifficultyOptions.RewardMultiplier);
            }

            return amount;
        }

        public override int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level)
        {
            if (service == Service.Road)
            {
                return (int)(originalConstructionCost * DifficultyOptions.RoadConstructionCostMultiplier);
            }

            return (int)(originalConstructionCost * DifficultyOptions.ConstructionCostMultiplier);
        }

        public override int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level)
        {
            if (service == Service.Road)
            {
                return (int)(originalMaintenanceCost * DifficultyOptions.RoadMaintenanceCostMultiplier);
            }

            return (int)(originalMaintenanceCost * DifficultyOptions.MaintenanceCostMultiplier);
        }

        public override int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level)
        {
            return (int)(constructionCost * DifficultyOptions.RelocationCostMultiplier);
        }

        public override int OnGetRefundAmount(int constructionCost, int refundAmount, Service service, SubService subService, Level level)
        {
            if (service == Service.Road)
            {
                return constructionCost;
            }
            return constructionCost / 2;
        }
    }
}

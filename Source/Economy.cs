﻿using ICities;
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

                return (int)(0.01f * amount * d.RewardMultiplier.Value + 0.99f);
            }

            return amount;
        }

        public override int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;
			int multiplier;
            
            if (service == Service.Road)
            {
                multiplier = d.ConstructionCostMultiplier_Road.Value;
            }
            else if (service == Service.PublicTransport)
            {
                multiplier = d.ConstructionCostMultiplier_Public.Value;
            }
            else if (service == Service.Education || service == Service.Electricity || service == Service.FireDepartment ||
                service == Service.Garbage || service == Service.HealthCare || service == Service.PoliceDepartment || service == Service.Water)
            {
                multiplier = d.ConstructionCostMultiplier_Service.Value;
            }
            else
            {
                multiplier = d.ConstructionCostMultiplier.Value;
            }
			
			return (int)(0.01f * originalConstructionCost * multiplier + 0.99f);
        }

        public override int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;
			int multiplier;

            if (service == Service.Road)
            {
                multiplier = d.MaintenanceCostMultiplier_Road.Value;
            }
            else if (service == Service.PublicTransport)
            {
                multiplier = d.MaintenanceCostMultiplier_Public.Value;
            }
            else if (service == Service.Education || service == Service.Electricity || service == Service.FireDepartment ||
                service == Service.Garbage || service == Service.HealthCare || service == Service.PoliceDepartment || service == Service.Water)
            {
                multiplier = d.MaintenanceCostMultiplier_Service.Value;
            }
            else
            {
                multiplier = d.MaintenanceCostMultiplier.Value;
            }
            
			return (int)(0.01f * originalMaintenanceCost * multiplier + 0.99f);
        }

        public override int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            return (int)(0.01f * constructionCost * d.RelocationCostMultiplier.Value + 0.99f);
        }

        public override int OnGetRefundAmount(int constructionCost, int refundAmount, Service service, SubService subService, Level level)
        {
            // Full refund for all recently built roads and facilities.
            // Consider it as an "undo" feature.
            return constructionCost;
        }
    }
}

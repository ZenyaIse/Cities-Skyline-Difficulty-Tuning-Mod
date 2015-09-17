using System;
using ICities;

namespace DifficultyTuningMod
{
    public class Demand : DemandExtensionBase
    {
        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return (int)Math.Round((originalDemand - DifficultyOptions.DemandOffset) * DifficultyOptions.DemandMultiplier);
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return (int)Math.Round((originalDemand - DifficultyOptions.DemandOffset) * DifficultyOptions.DemandMultiplier);
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return (int)Math.Round((originalDemand - DifficultyOptions.DemandOffset) * DifficultyOptions.DemandMultiplier);
        }
    }
}

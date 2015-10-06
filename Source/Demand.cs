using System;
using ICities;

namespace DifficultyTuningMod
{
    public class Demand : DemandExtensionBase
    {
        public override int OnCalculateResidentialDemand(int originalDemand)
        {
            return scaleDemandByDifficulty(originalDemand);
        }

        public override int OnCalculateCommercialDemand(int originalDemand)
        {
            return scaleDemandByDifficulty(originalDemand);
        }

        public override int OnCalculateWorkplaceDemand(int originalDemand)
        {
            return scaleDemandByDifficulty(originalDemand);
        }

        private int scaleDemandByDifficulty(int demandValue)
        {
            float value = (demandValue + DifficultyOptions.DemandOffset) * DifficultyOptions.DemandMultiplier;
            return Math.Min(100, (int)Math.Round(value)); // Limit to 100 to avoid possible uncompatibility with other mods
        }
    }
}

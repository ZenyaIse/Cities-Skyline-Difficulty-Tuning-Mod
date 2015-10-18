using System;
using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

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
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            float value = 0.01f * (demandValue + d.DemandOffset.Value) * d.DemandMultiplier.Value;
            return Math.Min(100, (int)Math.Round(value)); // Limit to 100 to avoid possible uncompatibility with other mods
        }
    }
}

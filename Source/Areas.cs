﻿using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class Areas : IAreasExtension
    {
        public bool OnCanUnlockArea(int x, int z, bool originalResult)
        {
            return originalResult;
        }

        public void OnCreated(IAreas areas)
        {
            areas.maxAreaCount = 25;
        }

        public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            return (int)(0.1f * originalPrice * d.AreaCostMultiplier.Value + 0.49f);
        }

        public void OnReleased()
        {
        }

        public void OnUnlockArea(int x, int z)
        {
        }
    }
}

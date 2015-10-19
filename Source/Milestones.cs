using System;
using ICities;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class Milestones : MilestonesExtensionBase
    {
        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");
        }

        public int OnGetPopulationTarget(int originalTarget, int scaledTarget)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            return (int)Math.Round(0.01f * scaledTarget * d.PopulationTargetMultiplier.Value);
        }
    }
}

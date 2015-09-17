using System;
using ICities;

namespace DifficultyTuningMod
{
    public class Milestones : MilestonesExtensionBase
    {
        public override void OnRefreshMilestones()
        {
            milestonesManager.UnlockMilestone("Basic Road Created");
        }
    }
}

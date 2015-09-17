using ICities;

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
            return (int)(originalPrice * DifficultyOptions.AreaCostMultiplier);
        }

        public void OnReleased()
        {
        }

        public void OnUnlockArea(int x, int z)
        {
        }
    }
}

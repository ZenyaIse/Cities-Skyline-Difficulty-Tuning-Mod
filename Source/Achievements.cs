using ColossalFramework;

namespace DifficultyTuningMod
{
    public static class Achievements
    {
        public static void Update()
        {
            SimulationManager sm = Singleton<SimulationManager>.instance;
            if (sm == null) return;

            if (DifficultyOptions.GameDifficulty == Difficulties.Easy || DifficultyOptions.GameDifficulty == Difficulties.Custom)
            {
                sm.m_metaData.m_disableAchievements = SimulationMetaData.MetaBool.True;
            }
            else
            {
                sm.m_metaData.m_disableAchievements = SimulationMetaData.MetaBool.False;
            }
        }
    }
}

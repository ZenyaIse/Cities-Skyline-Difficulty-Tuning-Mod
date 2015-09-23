using ColossalFramework;

namespace DifficultyTuningMod
{
    public static class Achievements
    {
        public static void Update()
        {
            if (DifficultyOptions.GameDifficulty == Difficulties.Easy || DifficultyOptions.GameDifficulty == Difficulties.Custom)
            {
                Singleton<SimulationManager>.instance.m_metaData.m_disableAchievements = SimulationMetaData.MetaBool.True;
            }
            else
            {
                Singleton<SimulationManager>.instance.m_metaData.m_disableAchievements = SimulationMetaData.MetaBool.False;
            }
        }
    }
}

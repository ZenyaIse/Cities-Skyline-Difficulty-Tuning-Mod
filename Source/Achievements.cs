using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public static class Achievements
    {
        public static void Update()
        {
            SimulationManager sm = Singleton<SimulationManager>.instance;
            DifficultyManager d = Singleton<DifficultyManager>.instance;
            if (sm == null || d == null) return;

            if (d.Difficulty == Difficulties.Easy || d.Difficulty == Difficulties.Free)
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

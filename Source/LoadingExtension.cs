using ICities;
using ColossalFramework;

namespace DifficultyTuningMod
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.NewGame && DifficultyOptions.GameDifficulty == Difficulties.Impossible)
            {
                Singleton<EconomyManager>.instance.AddResource(EconomyManager.Resource.LoanAmount, 3000000, ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            }

            Achievements.Update();
        }
    }
}

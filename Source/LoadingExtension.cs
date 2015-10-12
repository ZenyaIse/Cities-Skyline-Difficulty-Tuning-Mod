using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (mode == LoadMode.NewGame && d.Difficulty == Difficulties.Impossible)
            {
                // TODO: make optional
                Singleton<EconomyManager>.instance.AddResource(EconomyManager.Resource.LoanAmount, 3000000, ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            }

            Achievements.Update();
        }
    }
}

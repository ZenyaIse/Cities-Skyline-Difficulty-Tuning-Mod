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

            if (mode == LoadMode.NewGame)
            {
                long moneyToAdd = (d.InitialMoney.Value - 70) * 100000;
                Singleton<EconomyManager>.instance.AddResource(EconomyManager.Resource.LoanAmount, moneyToAdd, ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            }

            Achievements.Update();
        }
    }
}

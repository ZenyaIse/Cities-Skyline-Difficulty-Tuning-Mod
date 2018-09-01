using ICities;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;
using UnityEngine;

namespace DifficultyTuningMod
{
    public class LoadingExtension : LoadingExtensionBase
    {
        public override void OnLevelLoaded(LoadMode mode)
        {
            EconomyManager em = Singleton<EconomyManager>.instance;
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (mode == LoadMode.NewGame)
            {
                int moneyToAdd = (d.InitialMoney.Value - 70) * 100000;
                em.AddResource(EconomyManager.Resource.LoanAmount, moneyToAdd, ItemClass.Service.None, ItemClass.SubService.None, ItemClass.Level.None);
            }

            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
            {
                Loans.SetLoans();
            }

            Achievements.Update();

            PrefabsManager.UpdatePrefabs(false);
            NetManager.UpdateSlopes(false);

            Debug.Log("DifficultyTuningMod loaded. Version 2018/9/1");
        }

        public override void OnLevelUnloading()
        {
            Loans.ResetLoans();
            NetManager.ResetSlopes();
            PrefabsManager.ResetPrefabs();
        }
    }
}

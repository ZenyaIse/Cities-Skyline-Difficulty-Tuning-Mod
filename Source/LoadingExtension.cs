using System;
using ICities;
using ColossalFramework;
using ColossalFramework.Plugins;
using DifficultyTuningMod.DifficultyOptions;

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
                for (int i = 0; i < 3; i++)
                {
                    EconomyManager.Bank bank = em.m_properties.m_banks[i];
                    EconomyManager.LoanInfo li = bank.m_loanOffers[0];

                    li.m_amount = (int)Math.Round(0.01f * li.m_amount * d.LoanMultiplier.Value);
                    li.m_length = (int)Math.Round(0.01f * li.m_length * d.LoanMultiplier.Value);

                    bank.m_loanOffers[0] = li;
                    em.m_properties.m_banks[i] = bank;
                    //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, bank.m_bankName);
                }
            }

            Achievements.Update();

            //updatePrefabs();
        }

        private void updatePrefabs()
        {
            try
            {
                foreach (BuildingCollection bc in UnityEngine.Object.FindObjectsOfType<BuildingCollection>())
                {
                    foreach (BuildingInfo bi in bc.m_prefabs)
                    {
                        BuildingAI bAI = bi.m_buildingAI;
                        PowerPlantAI ppAI = bAI as PowerPlantAI;
                        if (ppAI != null)
                        {
                            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ppAI.name + ": " + ppAI.m_pollutionRadius.ToString());
                            ppAI.m_pollutionRadius *= 2f;
                        }

                        LandfillSiteAI lfsAI = bAI as LandfillSiteAI;
                        if (lfsAI != null)
                        {
                            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, lfsAI.name + ": " + lfsAI.m_pollutionRadius.ToString());
                            lfsAI.m_pollutionRadius *= 2f;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ex.Message);
            }
        }
    }
}

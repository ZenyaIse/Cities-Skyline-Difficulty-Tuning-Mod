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

            updatePrefabs();
        }

        private void updatePrefabs()
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (d.GroundPollutionRadiusMultiplier.Value == 100 && d.NoisePollutionRadiusMultiplier.Value == 100) return;

            try
            {
                float newPollutionRadius, newNoiseRadius;

                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Difficulty tuning mod: changing prefabs...");

                foreach (BuildingCollection bc in UnityEngine.Object.FindObjectsOfType<BuildingCollection>())
                {
                    foreach (BuildingInfo bi in bc.m_prefabs)
                    {
                        BuildingAI bAI = bi.m_buildingAI;

                        PowerPlantAI ppAI = bAI as PowerPlantAI;
                        if (ppAI != null)
                        {
                            newPollutionRadius = ppAI.m_pollutionRadius * 0.01f * d.GroundPollutionRadiusMultiplier.Value;
                            prefabChangedMessage(ppAI.name, "ground pollution radius", ppAI.m_pollutionRadius, newPollutionRadius);
                            ppAI.m_pollutionRadius = newPollutionRadius;

                            newNoiseRadius = ppAI.m_noiseRadius * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(ppAI.name, "noise pollution radius", ppAI.m_noiseRadius, newNoiseRadius);
                            ppAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }

                        LandfillSiteAI lfsAI = bAI as LandfillSiteAI;
                        if (lfsAI != null)
                        {
                            newPollutionRadius = lfsAI.m_pollutionRadius * 0.01f * d.GroundPollutionRadiusMultiplier.Value;
                            prefabChangedMessage(lfsAI.name, "ground pollution radius", lfsAI.m_pollutionRadius, newPollutionRadius);
                            lfsAI.m_pollutionRadius = newPollutionRadius;

                            newNoiseRadius = lfsAI.m_noiseRadius * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(lfsAI.name, "noise pollution radius", lfsAI.m_noiseRadius, newNoiseRadius);
                            lfsAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }

                        WaterFacilityAI wfAI = bAI as WaterFacilityAI;
                        if (wfAI != null)
                        {
                            newNoiseRadius = wfAI.m_noiseRadius * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(wfAI.name, "noise pollution radius", wfAI.m_noiseRadius, newNoiseRadius);
                            wfAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ex.Message);
            }
        }

        private void prefabChangedMessage(string prefabName, string paramName, float oldValue, float newValue)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, String.Format("{0}: {1} changed from {2} to {3}", prefabName, paramName, oldValue, newValue));
        }
    }
}

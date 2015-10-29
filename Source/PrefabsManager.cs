using System;
using System.Collections.Generic;
using ColossalFramework;
using ColossalFramework.Plugins;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public static class PrefabsManager
    {
        private static int GroundPollutionRadiusMultiplier_old = -1;
        private static int NoiseRadiusMultiplier_old = -1;

        private static Dictionary<string, float> groundPollutionRadiusOriginal = new Dictionary<string, float>();
        private static Dictionary<string, float> noiseRadiusOriginal = new Dictionary<string, float>();

        public static void UpdatePrefabs(bool maybeDuringGame)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (maybeDuringGame)
            {
                if (d.GroundPollutionRadiusMultiplier.Value == GroundPollutionRadiusMultiplier_old && d.NoisePollutionRadiusMultiplier.Value == NoiseRadiusMultiplier_old) return;
            }
            else
            {
                if (d.GroundPollutionRadiusMultiplier.Value == 100 && d.NoisePollutionRadiusMultiplier.Value == 100) return;
            }

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
                            if (!groundPollutionRadiusOriginal.ContainsKey(ppAI.name)) groundPollutionRadiusOriginal.Add(ppAI.name, ppAI.m_pollutionRadius);
                            if (!noiseRadiusOriginal.ContainsKey(ppAI.name)) noiseRadiusOriginal.Add(ppAI.name, ppAI.m_noiseRadius);

                            newPollutionRadius = groundPollutionRadiusOriginal[ppAI.name] * 0.01f * d.GroundPollutionRadiusMultiplier.Value;
                            prefabChangedMessage(ppAI.name, "ground pollution radius", groundPollutionRadiusOriginal[ppAI.name], newPollutionRadius);
                            ppAI.m_pollutionRadius = newPollutionRadius;

                            newNoiseRadius = noiseRadiusOriginal[ppAI.name] * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(ppAI.name, "noise pollution radius", noiseRadiusOriginal[ppAI.name], newNoiseRadius);
                            ppAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }

                        LandfillSiteAI lfsAI = bAI as LandfillSiteAI;
                        if (lfsAI != null)
                        {
                            if (!groundPollutionRadiusOriginal.ContainsKey(lfsAI.name)) groundPollutionRadiusOriginal.Add(lfsAI.name, lfsAI.m_pollutionRadius);
                            if (!noiseRadiusOriginal.ContainsKey(lfsAI.name)) noiseRadiusOriginal.Add(lfsAI.name, lfsAI.m_noiseRadius);

                            newPollutionRadius = groundPollutionRadiusOriginal[lfsAI.name] * 0.01f * d.GroundPollutionRadiusMultiplier.Value;
                            prefabChangedMessage(lfsAI.name, "ground pollution radius", groundPollutionRadiusOriginal[lfsAI.name], newPollutionRadius);
                            lfsAI.m_pollutionRadius = newPollutionRadius;

                            newNoiseRadius = noiseRadiusOriginal[lfsAI.name] * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(lfsAI.name, "noise pollution radius", noiseRadiusOriginal[lfsAI.name], newNoiseRadius);
                            lfsAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }

                        WaterFacilityAI wfAI = bAI as WaterFacilityAI;
                        if (wfAI != null)
                        {
                            if (!noiseRadiusOriginal.ContainsKey(wfAI.name)) noiseRadiusOriginal.Add(wfAI.name, wfAI.m_noiseRadius);

                            newNoiseRadius = noiseRadiusOriginal[wfAI.name] * 0.01f * d.NoisePollutionRadiusMultiplier.Value;
                            prefabChangedMessage(wfAI.name, "noise pollution radius", noiseRadiusOriginal[wfAI.name], newNoiseRadius);
                            wfAI.m_noiseRadius = newNoiseRadius;

                            continue;
                        }
                    }
                }

                GroundPollutionRadiusMultiplier_old = d.GroundPollutionRadiusMultiplier.Value;
                NoiseRadiusMultiplier_old = d.NoisePollutionRadiusMultiplier.Value;
            }
            catch (Exception ex)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ex.Message);
            }
        }

        private static void prefabChangedMessage(string prefabName, string paramName, float oldValue, float newValue)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, String.Format("{0}: {1} changed from {2} to {3}", prefabName, paramName, oldValue, newValue));
        }
    }
}

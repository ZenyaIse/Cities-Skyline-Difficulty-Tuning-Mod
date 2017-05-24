using System;
using System.Collections.Generic;
using ColossalFramework;
using DifficultyTuningMod.DifficultyOptions;
using ColossalFramework.Plugins;

namespace DifficultyTuningMod
{
    public static class NetManager
    {
        private static int MaxSlope_old = -1;
        private static Dictionary<string, float> maxSlopeOriginal = new Dictionary<string, float>();

        public static void UpdateSlopes(bool maybeDuringGame)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            if (maybeDuringGame)
            {
                if (d.MaxSlope.Value == MaxSlope_old) return;
            }
            else
            {
                if (d.MaxSlope.Value == 25) return;
            }

            try
            {
                float newMaxSlope;
                float multiplier = d.MaxSlope.Value / 25f;

                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Difficulty tuning mod: changing road slopes...");

                foreach (NetCollection nc in UnityEngine.Object.FindObjectsOfType<NetCollection>())
                {
                    foreach (NetInfo ni in nc.m_prefabs)
                    {
                        string className = ni.m_class.name;

                        if (className.IndexOf("Road", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            className.IndexOf("Highway", StringComparison.OrdinalIgnoreCase) >= 0 ||
                            className.IndexOf("Track", StringComparison.OrdinalIgnoreCase) >= 0
                            )
                        {
                            if (!maxSlopeOriginal.ContainsKey(ni.name)) maxSlopeOriginal.Add(ni.name, ni.m_maxSlope);

                            newMaxSlope = maxSlopeOriginal[ni.name] * multiplier;
                            Helper.ValueChangedMessage(ni.name + " (" + className + ")", "maximum slope", maxSlopeOriginal[ni.name], newMaxSlope);
                            ni.m_maxSlope = newMaxSlope;
                        }
                    }
                }

                MaxSlope_old = d.MaxSlope.Value;
            }
            catch (Exception ex)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ex.Message);
            }
        }

        public static void ResetSlopes()
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;

            foreach (NetCollection nc in UnityEngine.Object.FindObjectsOfType<NetCollection>())
            {
                foreach (NetInfo ni in nc.m_prefabs)
                {
                    if (maxSlopeOriginal.ContainsKey(ni.name))
                    {
                        ni.m_maxSlope = maxSlopeOriginal[ni.name];
                    }
                }
            }
        }
    }
}

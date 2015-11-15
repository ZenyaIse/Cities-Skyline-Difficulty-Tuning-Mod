using System;
using ColossalFramework.Plugins;

namespace DifficultyTuningMod
{
    public static class Helper
    {
        public static bool ShowMessages = false;

        public static void ValueChangedMessage(string objectName, string paramName, float oldValue, float newValue)
        {
            if (ShowMessages)
            {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, String.Format("{0}: {1} changed from {2} to {3}", objectName, paramName, oldValue, newValue));
            }
        }
    }
}

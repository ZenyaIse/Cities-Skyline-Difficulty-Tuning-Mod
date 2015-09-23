using UnityEngine;
using ColossalFramework;
using ColossalFramework.UI;
using ICities;
using System;

namespace DifficultyTuningMod
{
    public static class ExtendedInfoPanelsObject
    {
        private static float buildingInfoPanelSizeAdd = 200;
        private static long counter = 0;

        private static UILabel testLabel;

        public static void OnLevelLoaded()
        {
            UIPanel buildingInfoPanel = UIView.Find<UIPanel>("(Library) ZonedBuildingWorldInfoPanel");
            buildingInfoPanel.size = new Vector3(buildingInfoPanel.size.x, buildingInfoPanel.size.y + buildingInfoPanelSizeAdd);

            testLabel = buildingInfoPanel.AddUIComponent<UILabel>();
            testLabel.text = "Test";
        }

        public static void OnLevelUnloading()
        {
        }

        public static void Update()
        {
            if (testLabel != null)
            {
                testLabel.text = counter.ToString();
                counter++;
            }
        }
    }
}

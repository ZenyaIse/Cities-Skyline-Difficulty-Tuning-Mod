using ICities;
using ColossalFramework;
using ColossalFramework.UI;
using ColossalFramework.Globalization;
using UnityEngine;
using DifficultyTuningMod.DifficultyOptions;

namespace DifficultyTuningMod
{
    public class Mod : IUserMod
    {
        public string Name
        {
            get { return DTMLang.Text("MOD_NAME"); }
        }

        public string Description
        {
            get { return DTMLang.Text("MOD_DESCRIPTION"); }
        }


        #region Options UI

        private bool freeze = true;
        private UIDropDown ddDifficulty;
        //private UIDropDown ddConstructionCost;
        //private UIDropDown ddConstructionCost_Road;
        //private UIDropDown ddConstructionCost_Public;
        //private UIDropDown ddConstructionCost_Service;
        //private UIDropDown ddMaintenanceCost;
        //private UIDropDown ddMaintenanceCost_Road;
        //private UIDropDown ddMaintenanceCost_Public;
        //private UIDropDown ddMaintenanceCost_Service;
        //private UIDropDown ddAreaCostMultiplier;
        //private UIDropDown ddDemandOffset;
        //private UIDropDown ddDemandMultiplier;
        //private UIDropDown ddRewardMultiplier;
        //private UIDropDown ddRelocationCostMultiplier;
        //private UIDropDown ddResidentialTargetLandValue;
        //private UIDropDown ddCommercialTargetLandValue;
        //private UIDropDown ddIndustrialTargetService;
        //private UIDropDown ddOfficeTargetService;

        private float textScaleBig = 1.2f;
        private float textScaleSmall = 0.8f;


        //private void adjustSizes(UIDropDown dd)
        //{
        //    dd.width = 160;
        //    dd.height = 24;
        //    dd.itemHeight = 14;
        //    dd.textScale = 0.8f;
        //    dd.parent.height = 50;
        //    dd.parent.Find<UILabel>("Label").textScale = 0.8f;
        //}

        private void addLabel(UIScrollablePanel panel, string text, Vector3 position, float scale)
        {
            UILabel label = panel.AddUIComponent<UILabel>();
            label.text = text;
            label.textScale = scale;
            label.relativePosition = position;
        }

        private void addSlider(UIScrollablePanel panel, Vector3 position, OnValueChanged eventCallback, IDifficultyParameter param)
        {
            UISlider slider = panel.AddUIComponent<UISlider>();
            slider.size = new Vector2(150, 8);
            slider.relativePosition = position;
            slider.minValue = 0;
            slider.maxValue = param.MaxIndex;
            slider.stepSize = 1;
            slider.value = param.SelectedIndex;
            slider.backgroundSprite = "TextFieldPanel"; // TextFieldPanel, GenericProgressBar

            UISprite thumb = slider.AddUIComponent<UISprite>();
            thumb.size = new Vector2(16, 16);
            thumb.spriteName = "InfoIconBaseFocused"; // SliderBudget, InfoIconBaseFocused
            slider.thumbObject = thumb;

            UILabel label = panel.AddUIComponent<UILabel>();
            label.textScale = textScaleSmall;
            label.text = param.GetValueStr(param.SelectedIndex);
            label.relativePosition = new Vector3(position.x + 160, position.y);

            slider.eventValueChanged += delegate (UIComponent c, float val)
            {
                label.text = param.GetValueStr((int)val);
                eventCallback(val);
            };
        }

        private string truncateStr(string str, int countToTruncate)
        {
            return str.Substring(0, str.Length - countToTruncate);
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            ddDifficulty = (UIDropDown)helper.AddDropdown(
                DTMLang.Text("DIFFICULTY_LEVEL"),
                d.DifficultiesStr,
                (int)d.Difficulty,
                DifficultyLevelOnSelected
                );
            ddDifficulty.width = 250;
            ddDifficulty.height -= 2;

            //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, ddDifficulty.parent.parent.ToString());

            UIScrollablePanel scrollablePanel = (UIScrollablePanel)ddDifficulty.parent.parent;
            scrollablePanel.autoLayout = false;

            float x = 5;
            float y = 0;

            ddDifficulty.parent.relativePosition = new Vector3(x, y);
            y += ddDifficulty.parent.height + 10;


            //
            // Custom options
            //

            addLabel(scrollablePanel, DTMLang.Text("CUSTOM_OPTIONS"), new Vector3(x, y), textScaleBig);
            y += 30;

            // Construction cost
            addLabel(scrollablePanel, truncateStr(Locale.Get("TOOL_CONSTRUCTION_COST"), 5), new Vector3(x, y), textScaleSmall);
            y += 25;
            addSlider(scrollablePanel, new Vector3(x, y), OnCustomValueChanged, d.ConstructionCostMultiplier_Service);


            //// Construction cost multiplier for service buildings
            //ddConstructionCost_Service = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.ConstructionCostMultiplier_Service.Description,
            //    d.ConstructionCostMultiplier_Service.CustomValuesStr,
            //    d.ConstructionCostMultiplier_Service.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddConstructionCost_Service);

            //// Construction cost multiplier for public transport
            //ddConstructionCost_Public = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.ConstructionCostMultiplier_Public.Description,
            //    d.ConstructionCostMultiplier_Public.CustomValuesStr,
            //    d.ConstructionCostMultiplier_Public.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddConstructionCost_Public);

            //// Construction cost multiplier for roads
            //ddConstructionCost_Road = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.ConstructionCostMultiplier_Road.Description,
            //    d.ConstructionCostMultiplier_Road.CustomValuesStr,
            //    d.ConstructionCostMultiplier_Road.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddConstructionCost_Road);

            //// Construction cost multiplier for others
            //ddConstructionCost = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.ConstructionCostMultiplier.Description,
            //    d.ConstructionCostMultiplier.CustomValuesStr,
            //    d.ConstructionCostMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddConstructionCost);


            //// Maintenance cost multiplier for service buildings
            //ddMaintenanceCost_Service = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.MaintenanceCostMultiplier_Service.Description,
            //    d.MaintenanceCostMultiplier_Service.CustomValuesStr,
            //    d.MaintenanceCostMultiplier_Service.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddMaintenanceCost_Service);

            //// Maintenance cost multiplier for public transport
            //ddMaintenanceCost_Public = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.MaintenanceCostMultiplier_Public.Description,
            //    d.MaintenanceCostMultiplier_Public.CustomValuesStr,
            //    d.MaintenanceCostMultiplier_Public.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddMaintenanceCost_Public);

            //// Maintenance cost multiplier for roads
            //ddMaintenanceCost_Road = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.MaintenanceCostMultiplier_Road.Description,
            //    d.MaintenanceCostMultiplier_Road.CustomValuesStr,
            //    d.MaintenanceCostMultiplier_Road.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddMaintenanceCost_Road);

            //// Maintenance cost multiplier for others
            //ddMaintenanceCost = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.MaintenanceCostMultiplier.Description,
            //    d.MaintenanceCostMultiplier.CustomValuesStr,
            //    d.MaintenanceCostMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddMaintenanceCost);


            //// Area cost multiplier
            //ddAreaCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.AreaCostMultiplier.Description,
            //    d.AreaCostMultiplier.CustomValuesStr,
            //    d.AreaCostMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddAreaCostMultiplier);

            //// Demand offset
            //ddDemandOffset = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.DemandOffset.Description,
            //    d.DemandOffset.CustomValuesStr,
            //    d.DemandOffset.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddDemandOffset);

            //// Demand multiplier
            //ddDemandMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.DemandMultiplier.Description,
            //    d.DemandMultiplier.CustomValuesStr,
            //    d.DemandMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddDemandMultiplier);

            //// Reward multiplier
            //ddRewardMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.RewardMultiplier.Description,
            //    d.RewardMultiplier.CustomValuesStr,
            //    d.RewardMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddRewardMultiplier);

            //// Relocation cost multiplier
            //ddRelocationCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.RelocationCostMultiplier.Description,
            //    d.RelocationCostMultiplier.CustomValuesStr,
            //    d.RelocationCostMultiplier.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddRelocationCostMultiplier);

            //// Residential target land value
            //ddResidentialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.ResidentialTargetLandValue.Description,
            //    d.ResidentialTargetLandValue.CustomValuesStr,
            //    d.ResidentialTargetLandValue.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddResidentialTargetLandValue);

            //// Commercial target land value
            //ddCommercialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.CommercialTargetLandValue.Description,
            //    d.CommercialTargetLandValue.CustomValuesStr,
            //    d.CommercialTargetLandValue.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddCommercialTargetLandValue);

            //// Industrial target service
            //ddIndustrialTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.IndustrialTargetService.Description,
            //    d.IndustrialTargetService.CustomValuesStr,
            //    d.IndustrialTargetService.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddIndustrialTargetService);

            //// Office target service
            //ddOfficeTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
            //    d.OfficeTargetService.Description,
            //    d.OfficeTargetService.CustomValuesStr,
            //    d.OfficeTargetService.SelectedOptionIndex,
            //    CustomValueOnSelected
            //    );
            //adjustSizes(ddOfficeTargetService);

            freeze = false;


            //
            // Custom layout
            //

            //UIPanel groupPanel = ddConstructionCost.parent.parent as UIPanel;
            //if (groupPanel != null)
            //{
                //groupPanel.autoLayout = false;

                //float x = 5;
                //float y = 0;
                //float dx = 190;
                //float dy = 60;

                //ddConstructionCost_Service.parent.relativePosition = new Vector3(x, y);
                //ddConstructionCost_Public.parent.relativePosition = new Vector3(x + dx, y);
                //ddConstructionCost_Road.parent.relativePosition = new Vector3(x + dx * 2, y);
                //ddConstructionCost.parent.relativePosition = new Vector3(x + dx * 3, y);
                //y += dy;
                //ddMaintenanceCost_Service.parent.relativePosition = new Vector3(x, y);
                //ddMaintenanceCost_Public.parent.relativePosition = new Vector3(x + dx, y);
                //ddMaintenanceCost_Road.parent.relativePosition = new Vector3(x + dx * 2, y);
                //ddMaintenanceCost.parent.relativePosition = new Vector3(x + dx * 3, y);
                //y += dy;
                //ddAreaCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddDemandOffset.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //ddDemandMultiplier.parent.relativePosition = new UnityEngine.Vector3(x + dx, y);
                //y += dy;
                //ddRewardMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddRelocationCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddResidentialTargetLandValue.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddCommercialTargetLandValue.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddIndustrialTargetService.parent.relativePosition = new UnityEngine.Vector3(x, y);
                //y += dy;
                //ddOfficeTargetService.parent.relativePosition = new UnityEngine.Vector3(x, y);


                //y += dy;
                //groupPanel.height = y;
            //}
        }

        private void DifficultyLevelOnSelected(int sel)
        {
            if (freeze) return;

            //if (ddConstructionCost == null) return;

            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            d.Difficulty = (Difficulties)sel;
            
            // Update controls
            freeze = true;
            //ddConstructionCost.selectedIndex = d.ConstructionCostMultiplier.SelectedOptionIndex;
            //ddConstructionCost_Road.selectedIndex = d.ConstructionCostMultiplier_Road.SelectedOptionIndex;
            //ddConstructionCost_Service.selectedIndex = d.ConstructionCostMultiplier_Service.SelectedOptionIndex;
            //ddConstructionCost_Public.selectedIndex = d.ConstructionCostMultiplier_Public.SelectedOptionIndex;
            //ddMaintenanceCost.selectedIndex = d.MaintenanceCostMultiplier.SelectedOptionIndex;
            //ddMaintenanceCost_Road.selectedIndex = d.MaintenanceCostMultiplier_Road.SelectedOptionIndex;
            //ddMaintenanceCost_Service.selectedIndex = d.MaintenanceCostMultiplier_Service.SelectedOptionIndex;
            //ddMaintenanceCost_Public.selectedIndex = d.MaintenanceCostMultiplier_Public.SelectedOptionIndex;
            //if (ddAreaCostMultiplier != null) ddAreaCostMultiplier.selectedIndex = d.AreaCostMultiplier.SelectedOptionIndex;
            //if (ddDemandOffset != null) ddDemandOffset.selectedIndex = d.DemandOffset.SelectedOptionIndex;
            //if (ddDemandMultiplier != null) ddDemandMultiplier.selectedIndex = d.DemandMultiplier.SelectedOptionIndex;
            //if (ddRewardMultiplier != null) ddRewardMultiplier.selectedIndex = d.RewardMultiplier.SelectedOptionIndex;
            //if (ddRelocationCostMultiplier != null) ddRelocationCostMultiplier.selectedIndex = d.RelocationCostMultiplier.SelectedOptionIndex;
            //if (ddResidentialTargetLandValue != null) ddResidentialTargetLandValue.selectedIndex = d.ResidentialTargetLandValue.SelectedOptionIndex;
            //if (ddCommercialTargetLandValue != null) ddCommercialTargetLandValue.selectedIndex = d.CommercialTargetLandValue.SelectedOptionIndex;
            //if (ddIndustrialTargetService != null) ddIndustrialTargetService.selectedIndex = d.IndustrialTargetService.SelectedOptionIndex;
            //if (ddOfficeTargetService != null) ddOfficeTargetService.selectedIndex = d.OfficeTargetService.SelectedOptionIndex;
            freeze = false;

            //DifficultyOptions.Save();

            Achievements.Update();
        }

        private void OnCustomValueChanged(float val)
        {
            if (freeze) return;

            //if (ddConstructionCost == null) return;

            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            d.Difficulty = Difficulties.Custom;
            
            freeze = true;
            ddDifficulty.selectedIndex = (int)Difficulties.Custom;
            freeze = false;

            //d.ConstructionCostMultiplier.SelectedOptionIndex = ddConstructionCost.selectedIndex;
            //d.ConstructionCostMultiplier_Road.SelectedOptionIndex = ddConstructionCost_Road.selectedIndex;
            //d.ConstructionCostMultiplier_Service.SelectedOptionIndex = ddConstructionCost_Service.selectedIndex;
            //d.ConstructionCostMultiplier_Public.SelectedOptionIndex = ddConstructionCost_Public.selectedIndex;
            //d.MaintenanceCostMultiplier.SelectedOptionIndex = ddMaintenanceCost.selectedIndex;
            //d.MaintenanceCostMultiplier_Road.SelectedOptionIndex = ddMaintenanceCost_Road.selectedIndex;
            //d.MaintenanceCostMultiplier_Service.SelectedOptionIndex = ddMaintenanceCost_Service.selectedIndex;
            //d.MaintenanceCostMultiplier_Public.SelectedOptionIndex = ddMaintenanceCost_Public.selectedIndex;
            //if (ddAreaCostMultiplier != null) d.AreaCostMultiplier.SelectedOptionIndex = ddAreaCostMultiplier.selectedIndex;
            //if (ddDemandOffset != null) d.DemandOffset.SelectedOptionIndex = ddDemandOffset.selectedIndex;
            //if (ddDemandMultiplier != null) d.DemandMultiplier.SelectedOptionIndex = ddDemandMultiplier.selectedIndex;
            //if (ddRewardMultiplier != null) d.RewardMultiplier.SelectedOptionIndex = ddRewardMultiplier.selectedIndex;
            //if (ddRelocationCostMultiplier != null) d.RelocationCostMultiplier.SelectedOptionIndex = ddRelocationCostMultiplier.selectedIndex;
            //if (ddResidentialTargetLandValue != null) d.ResidentialTargetLandValue.SelectedOptionIndex = ddResidentialTargetLandValue.selectedIndex;
            //if (ddResidentialTargetLandValue != null) d.ResidentialTooLowLandValue.SelectedOptionIndex = ddResidentialTargetLandValue.selectedIndex;
            //if (ddCommercialTargetLandValue != null) d.CommercialTargetLandValue.SelectedOptionIndex = ddCommercialTargetLandValue.selectedIndex;
            //if (ddCommercialTargetLandValue != null) d.CommercialTooLowLandValue.SelectedOptionIndex = ddCommercialTargetLandValue.selectedIndex;
            //if (ddIndustrialTargetService != null) d.IndustrialTargetService.SelectedOptionIndex = ddIndustrialTargetService.selectedIndex;
            //if (ddIndustrialTargetService != null) d.IndustrialTooFewService.SelectedOptionIndex = ddIndustrialTargetService.selectedIndex;
            //if (ddOfficeTargetService != null) d.OfficeTargetService.SelectedOptionIndex = ddOfficeTargetService.selectedIndex;
            //if (ddOfficeTargetService != null) d.OfficeTooFewService.SelectedOptionIndex = ddOfficeTargetService.selectedIndex;

            //DifficultyOptions.Save();

            Achievements.Update();
        }

        #endregion
    }
}

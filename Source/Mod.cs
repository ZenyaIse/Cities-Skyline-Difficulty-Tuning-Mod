using System.Collections.Generic;
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

        private float textScaleBig = 1.2f;
        private float textScaleMedium = 1.0f;
        private float textScaleSmall = 0.8f;

        private Dictionary<UISlider, IDifficultyParameter> sliders = new Dictionary<UISlider, IDifficultyParameter>();


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
            label.text = param.GetValueStr((int)slider.value);
            label.relativePosition = new Vector3(position.x + 160, position.y);

            slider.eventValueChanged += delegate (UIComponent c, float val)
            {
                label.text = param.GetValueStr((int)val);
                if (!freeze)
                {
                    param.SelectedIndex = (int)slider.value;
                    eventCallback(val);
                }
            };

            sliders.Add(slider, param);
        }

        private string truncateSemicolon(string str)
        {
            return str.Split(':')[0];
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
			float dx1 = 140;
			float dx2 = 375;
			float dy1 = 24;
            float dy2 = 36;

            ddDifficulty.parent.relativePosition = new Vector3(x, y);
            y += ddDifficulty.parent.height + 10;


            //
            // Custom options
            //
            sliders.Clear();

            addLabel(scrollablePanel, DTMLang.Text("CUSTOM_OPTIONS"), new Vector3(x, y), textScaleBig);
            y += dy2;
            x += 10;

            // Construction cost
            addLabel(scrollablePanel, truncateSemicolon(Locale.Get("TOOL_CONSTRUCTION_COST")), new Vector3(x, y), textScaleMedium);
            addLabel(scrollablePanel, DTMLang.Text("SERVICE_BUILDINGS"), new Vector3(x, y + dy1), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1), OnCustomValueChanged, d.ConstructionCostMultiplier_Service);
            addLabel(scrollablePanel, DTMLang.Text("PUBLIC_TRANSPORT"), new Vector3(x, y + dy1 * 2), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 2), OnCustomValueChanged, d.ConstructionCostMultiplier_Public);
            addLabel(scrollablePanel, DTMLang.Text("ROADS"), new Vector3(x, y + dy1 * 3), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 3), OnCustomValueChanged, d.ConstructionCostMultiplier_Road);
            addLabel(scrollablePanel, DTMLang.Text("OTHERS"), new Vector3(x, y + dy1 * 4), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 4), OnCustomValueChanged, d.ConstructionCostMultiplier);

            // Maintenance cost
			x += dx2;
            addLabel(scrollablePanel, truncateSemicolon(Locale.Get("AIINFO_UPKEEP")), new Vector3(x, y), textScaleMedium);
            addLabel(scrollablePanel, DTMLang.Text("SERVICE_BUILDINGS"), new Vector3(x, y + dy1), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1), OnCustomValueChanged, d.MaintenanceCostMultiplier_Service);
            addLabel(scrollablePanel, DTMLang.Text("PUBLIC_TRANSPORT"), new Vector3(x, y + dy1 * 2), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 2), OnCustomValueChanged, d.MaintenanceCostMultiplier_Public);
            addLabel(scrollablePanel, DTMLang.Text("ROADS"), new Vector3(x, y + dy1 * 3), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 3), OnCustomValueChanged, d.MaintenanceCostMultiplier_Road);
            addLabel(scrollablePanel, DTMLang.Text("OTHERS"), new Vector3(x, y + dy1 * 4), textScaleSmall);
            addSlider(scrollablePanel, new Vector3(x + dx1, y + dy1 * 4), OnCustomValueChanged, d.MaintenanceCostMultiplier);
			x -= dx2;
            y += dy1 * 4;
            y += dy2;

            addLabel(scrollablePanel, truncateSemicolon(Locale.Get("TOOL_RELOCATE_COST")), new Vector3(x, y), textScaleMedium);
            y += dy1;
            addSlider(scrollablePanel, new Vector3(x, y), OnCustomValueChanged, d.RelocationCostMultiplier);
            y += dy2;

            addLabel(scrollablePanel, DTMLang.Text("AREA_COST_MULTIPLIER"), new Vector3(x, y), textScaleMedium);
            y += dy1;
            addSlider(scrollablePanel, new Vector3(x, y), OnCustomValueChanged, d.AreaCostMultiplier);
            y += dy2;



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
        }

        private void DifficultyLevelOnSelected(int sel)
        {
            if (freeze) return;

            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            d.Difficulty = (Difficulties)sel;
            
            // Update controls
            freeze = true;
            foreach (KeyValuePair<UISlider, IDifficultyParameter> item in sliders)
            {
                item.Key.value = item.Value.SelectedIndex;
            }
            freeze = false;

            Achievements.Update();
        }

        private void OnCustomValueChanged(float val)
        {
            if (freeze) return;

            DifficultyManager d = Singleton<DifficultyManager>.instance;
            
            d.Difficulty = Difficulties.Custom;
            
            freeze = true;
            ddDifficulty.selectedIndex = (int)Difficulties.Custom;
            freeze = false;

            Achievements.Update();
        }

        #endregion
    }
}

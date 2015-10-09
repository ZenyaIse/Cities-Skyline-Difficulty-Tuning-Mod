using ICities;
using ColossalFramework.UI;
using ColossalFramework.Plugins;

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
        private UIDropDown ddConstructionCost;
        private UIDropDown ddRoadConstructionCost;
        private UIDropDown ddMaintenanceCostMultiplier;
        private UIDropDown ddRoadMaintenanceCostMultiplier;
        private UIDropDown ddAreaCostMultiplier;
        private UIDropDown ddDemandOffset;
        private UIDropDown ddDemandMultiplier;
        private UIDropDown ddRewardMultiplier;
        private UIDropDown ddRelocationCostMultiplier;
        private UIDropDown ddResidentialTargetLandValue;
        private UIDropDown ddCommercialTargetLandValue;
        private UIDropDown ddIndustrialTargetService;
        private UIDropDown ddOfficeTargetService;

        private void adjustSizes(UIDropDown dd)
        {
            dd.width = 200;
            dd.height = 24;
            dd.itemHeight = 14;
            dd.textScale = 0.8f;
            dd.parent.height = 50;
            dd.parent.Find<UILabel>("Label").textScale = 0.8f;
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
            
            ddDifficulty = (UIDropDown)helper.AddDropdown(
                DTMLang.Text("DIFFICULTY_LEVEL"),
                d.DifficultiesStr,
                (int)d.Difficulty,
                DifficultyLevelOnSelected
                );
            ddDifficulty.width = 250;
            ddDifficulty.height -= 2;

			
			//
			// Custom options
			//
			
            UIHelperBase customOptionsGroup = helper.AddGroup(DTMLang.Text("CUSTOM_OPTIONS"));

            // Construction cost multiplier
            ddConstructionCost = (UIDropDown)customOptionsGroup.AddDropdown(
                d.ConstructionCostMultiplier.Description,
                d.ConstructionCostMultiplier.CustomValuesStr,
                d.ConstructionCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddConstructionCost);

            // Road construction cost multiplier
            ddRoadConstructionCost = (UIDropDown)customOptionsGroup.AddDropdown(
                d.RoadConstructionCostMultiplier.Description,
                d.RoadConstructionCostMultiplier.CustomValuesStr,
                d.RoadConstructionCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRoadConstructionCost);
            placeToTheRight(ddRoadConstructionCost, ddConstructionCost);

            // Maintenance cost multiplier
            ddMaintenanceCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.MaintenanceCostMultiplier.Description,
                d.MaintenanceCostMultiplier.CustomValuesStr,
                d.MaintenanceCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddMaintenanceCostMultiplier);

            // Road maintenance cost multiplier
            ddRoadMaintenanceCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.RoadMaintenanceCostMultiplier.Description,
                d.RoadMaintenanceCostMultiplier.CustomValuesStr,
                d.RoadMaintenanceCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRoadMaintenanceCostMultiplier);
            placeToTheRight(ddRoadMaintenanceCostMultiplier, ddMaintenanceCostMultiplier);

            // Area cost multiplier
            ddAreaCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.AreaCostMultiplier.Description,
                d.AreaCostMultiplier.CustomValuesStr,
                d.AreaCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddAreaCostMultiplier);

            // Demand offset
            ddDemandOffset = (UIDropDown)customOptionsGroup.AddDropdown(
                d.DemandOffset.Description,
                d.DemandOffset.CustomValuesStr,
                d.DemandOffset.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddDemandOffset);

            // Demand multiplier
            ddDemandMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.DemandMultiplier.Description,
                d.DemandMultiplier.CustomValuesStr,
                d.DemandMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddDemandMultiplier);
            placeToTheRight(ddDemandMultiplier, ddDemandOffset);

            // Reward multiplier
            ddRewardMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.RewardMultiplier.Description,
                d.RewardMultiplier.CustomValuesStr,
                d.RewardMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRewardMultiplier);

            // Relocation cost multiplier
            ddRelocationCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                d.RelocationCostMultiplier.Description,
                d.RelocationCostMultiplier.CustomValuesStr,
                d.RelocationCostMultiplier.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRelocationCostMultiplier);

            // Residential target land value
            ddResidentialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
                d.ResidentialTargetLandValue.Description,
                d.ResidentialTargetLandValue.CustomValuesStr,
                d.ResidentialTargetLandValue.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddResidentialTargetLandValue);

            // Commercial target land value
            ddCommercialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
                d.CommercialTargetLandValue.Description,
                d.CommercialTargetLandValue.CustomValuesStr,
                d.CommercialTargetLandValue.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddCommercialTargetLandValue);

            // Industrial target service
            ddIndustrialTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
                d.IndustrialTargetService.Description,
                d.IndustrialTargetService.CustomValuesStr,
                d.IndustrialTargetService.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddIndustrialTargetService);

            // Office target service
            ddOfficeTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
                d.OfficeTargetService.Description,
                d.OfficeTargetService.CustomValuesStr,
                d.OfficeTargetService.SelectedOptionIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddOfficeTargetService);

            freeze = false;


            //
            // Custom layout
            //

            UIPanel groupPanel = ddConstructionCost.parent.parent as UIPanel;
            if (groupPanel != null)
            {
                groupPanel.autoLayout = false;

                float x = 5;
                float y = 0;
                float dx = 250;
                float dy = 60;

                ddConstructionCost.parent.relativePosition = new UnityEngine.Vector3(x, y);
                ddRoadConstructionCost.parent.relativePosition = new UnityEngine.Vector3(x + dx, y);
                y += dy;
                ddMaintenanceCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                ddRoadMaintenanceCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x + dx, y);
                y += dy;
                ddAreaCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddDemandOffset.parent.relativePosition = new UnityEngine.Vector3(x, y);
                ddDemandMultiplier.parent.relativePosition = new UnityEngine.Vector3(x + dx, y);
                y += dy;
                ddRewardMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddRelocationCostMultiplier.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddResidentialTargetLandValue.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddCommercialTargetLandValue.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddIndustrialTargetService.parent.relativePosition = new UnityEngine.Vector3(x, y);
                y += dy;
                ddOfficeTargetService.parent.relativePosition = new UnityEngine.Vector3(x, y);

                y += dy;
                groupPanel.height = y;
            }
        }

        private void DifficultyLevelOnSelected(int sel)
        {
            if (freeze) return;

            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
			
            d.Difficulty = (Difficulties)sel;
            
			// Update controls
            freeze = true;
			if (ddConstructionCost != null) ddConstructionCost.selectedIndex = d.ConstructionCostMultiplier.SelectedOptionIndex;
			if (ddRoadConstructionCost != null) ddRoadConstructionCost.selectedIndex = d.RoadConstructionCostMultiplier.SelectedOptionIndex;
			if (ddMaintenanceCostMultiplier != null) ddMaintenanceCostMultiplier.selectedIndex = d.MaintenanceCostMultiplier.SelectedOptionIndex;
			if (ddRoadMaintenanceCostMultiplier != null) ddRoadMaintenanceCostMultiplier.selectedIndex = d.RoadMaintenanceCostMultiplier.SelectedOptionIndex;
			if (ddAreaCostMultiplier != null) ddAreaCostMultiplier.selectedIndex = d.AreaCostMultiplier.SelectedOptionIndex;
			if (ddDemandOffset != null) ddDemandOffset.selectedIndex = d.DemandOffset.SelectedOptionIndex;
			if (ddDemandMultiplier != null) ddDemandMultiplier.selectedIndex = d.DemandMultiplier.SelectedOptionIndex;
			if (ddRewardMultiplier != null) ddRewardMultiplier.selectedIndex = d.RewardMultiplier.SelectedOptionIndex;
			if (ddRelocationCostMultiplier != null) ddRelocationCostMultiplier.selectedIndex = d.RelocationCostMultiplier.SelectedOptionIndex;
			if (ddResidentialTargetLandValue != null) ddResidentialTargetLandValue.selectedIndex = d.ResidentialTargetLandValue.SelectedOptionIndex;
			if (ddCommercialTargetLandValue != null) ddCommercialTargetLandValue.selectedIndex = d.CommercialTargetLandValue.SelectedOptionIndex;
			if (ddIndustrialTargetService != null) ddIndustrialTargetService.selectedIndex = d.IndustrialTargetService.SelectedOptionIndex;
			if (ddOfficeTargetService != null) ddOfficeTargetService.selectedIndex = d.OfficeTargetService.SelectedOptionIndex;
            freeze = false;

            //DifficultyOptions.Save();

            Achievements.Update();
        }

        private void CustomValueOnSelected(int sel)
        {
            if (freeze) return;

            DifficultyOptions d = Singleton<DifficultyOptions>.instance;
			
            d.Difficulty = Difficulties.Custom;
			
            freeze = true;
            ddDifficulty.selectedIndex = (int)Difficulties.Custom;
            freeze = false;

            if (ddConstructionCost != null) d.ConstructionCostMultiplier.SelectedOptionIndex = ddConstructionCost.selectedIndex;
            if (ddRoadConstructionCost != null) d.RoadConstructionCostMultiplier.SelectedOptionIndex = ddRoadConstructionCost.selectedIndex;
            if (ddMaintenanceCostMultiplier != null) d.MaintenanceCostMultiplier.SelectedOptionIndex = ddMaintenanceCostMultiplier.selectedIndex;
            if (ddRoadMaintenanceCostMultiplier != null) d.RoadMaintenanceCostMultiplier.SelectedOptionIndex = ddRoadMaintenanceCostMultiplier.selectedIndex;
            if (ddAreaCostMultiplier != null) d.AreaCostMultiplier.SelectedOptionIndex = ddAreaCostMultiplier.selectedIndex;
            if (ddDemandOffset != null) d.DemandOffset.SelectedOptionIndex = ddDemandOffset.selectedIndex;
            if (ddDemandMultiplier != null) d.DemandMultiplier.SelectedOptionIndex = ddDemandMultiplier.selectedIndex;
            if (ddRewardMultiplier != null) d.RewardMultiplier.SelectedOptionIndex = ddRewardMultiplier.selectedIndex;
            if (ddRelocationCostMultiplier != null) d.RelocationCostMultiplier.SelectedOptionIndex = ddRelocationCostMultiplier.selectedIndex;
            if (ddResidentialTargetLandValue != null) d.ResidentialTargetLandValue.SelectedOptionIndex = ddResidentialTargetLandValue.selectedIndex;
            if (ddResidentialTargetLandValue != null) d.ResidentialTooLowLandValue.SelectedOptionIndex = ddResidentialTargetLandValue.selectedIndex;
            if (ddCommercialTargetLandValue != null) d.CommercialTargetLandValue.SelectedOptionIndex = ddCommercialTargetLandValue.selectedIndex;
            if (ddCommercialTargetLandValue != null) d.CommercialTooLowLandValue.SelectedOptionIndex = ddCommercialTargetLandValue.selectedIndex;
            if (ddIndustrialTargetService != null) d.IndustrialTargetService.SelectedOptionIndex = ddIndustrialTargetService.selectedIndex;
            if (ddIndustrialTargetService != null) d.IndustrialTooFewService.SelectedOptionIndex = ddIndustrialTargetService.selectedIndex;
            if (ddOfficeTargetService != null) d.OfficeTargetService.SelectedOptionIndex = ddOfficeTargetService.selectedIndex;
            if (ddOfficeTargetService != null) d.OfficeTooFewService.SelectedOptionIndex = ddOfficeTargetService.selectedIndex;

            DifficultyOptions.Save();

            Achievements.Update();
        }

        #endregion
    }
}

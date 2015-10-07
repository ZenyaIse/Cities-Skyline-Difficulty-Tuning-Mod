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

        private void placeToTheRight(UIDropDown targetDD, UIDropDown refDD)
        {
            targetDD.parent.absolutePosition = new UnityEngine.Vector3(refDD.parent.absolutePosition.x + 250, refDD.parent.absolutePosition.y);
        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            int dIndex = (int)DifficultyOptions.Instance.Difficulty;
            bool isCustom = (DifficultyOptions.Instance.Difficulty == Difficulties.Custom);

            ddDifficulty = (UIDropDown)helper.AddDropdown(
                DTMLang.Text("DIFFICULTY_LEVEL"),
                DifficultyOptions.DifficultyList,
                dIndex,
                DifficultyLevelOnSelected
                );
            ddDifficulty.width = 250;
            ddDifficulty.height -= 2;

            UIHelperBase customOptionsGroup = helper.AddGroup(DTMLang.Text("CUSTOM_OPTIONS"));

            // Construction cost multiplier
            ddConstructionCost = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("CONSTRUCTION_COST"),
                DifficultyOptions.ConstructionCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.ConstructionCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddConstructionCost);

            // Road construction cost multiplier
            ddRoadConstructionCost = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("ROAD_CONSTRUCTION_COST"),
                DifficultyOptions.RoadConstructionCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRoadConstructionCost);
            placeToTheRight(ddRoadConstructionCost, ddConstructionCost);

            // Maintenance cost multiplier
            ddMaintenanceCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("MAINTENANCE_COST"),
                DifficultyOptions.MaintenanceCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.MaintenanceCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddMaintenanceCostMultiplier);

            // Road maintenance cost multiplier
            ddRoadMaintenanceCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("ROAD_MAINTENANCE_COST"),
                DifficultyOptions.RoadMaintenanceCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRoadMaintenanceCostMultiplier);
            placeToTheRight(ddRoadMaintenanceCostMultiplier, ddMaintenanceCostMultiplier);

            // Area cost multiplier
            ddAreaCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("AREA_COST_MULTIPLIER"),
                DifficultyOptions.AreaCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.AreaCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddAreaCostMultiplier);

            // Demand offset
            ddDemandOffset = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("DEMAND_OFFSET"),
                DifficultyOptions.DemandOffsetList,
                isCustom ? DifficultyOptions.Instance.DemandOffsetIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddDemandOffset);

            // Demand multiplier
            ddDemandMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("DEMAND_MULTIPLIER"),
                DifficultyOptions.DemandMultiplierList,
                isCustom ? DifficultyOptions.Instance.DemandMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddDemandMultiplier);
            placeToTheRight(ddDemandMultiplier, ddDemandOffset);

            // Reward multiplier
            ddRewardMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("REWARD"),
                DifficultyOptions.RewardMultiplierList,
                isCustom ? DifficultyOptions.Instance.RewardMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRewardMultiplier);

            // Relocation cost multiplier
            ddRelocationCostMultiplier = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("RELOCATION_COST"),
                DifficultyOptions.RelocationCostMultiplierList,
                isCustom ? DifficultyOptions.Instance.RelocationCostMultiplierIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddRelocationCostMultiplier);

            // Residential target land value
            ddResidentialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("TARGET_RESIDENTIAL"),
                DifficultyOptions.ResidentialTargetLandValueList,
                isCustom ? DifficultyOptions.Instance.ResidentialTargetLandValueIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddResidentialTargetLandValue);

            // Commercial target land value
            ddCommercialTargetLandValue = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("TARGET_COMMERCIAL"),
                DifficultyOptions.CommercialTargetLandValueList,
                isCustom ? DifficultyOptions.Instance.CommercialTargetLandValueIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddCommercialTargetLandValue);

            // Industrial target service
            ddIndustrialTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("TARGET_INDUSTRIAL"),
                DifficultyOptions.IndustrialTargetServiceList,
                isCustom ? DifficultyOptions.Instance.IndustrialTargetServiceIndex : dIndex,
                CustomValueOnSelected
                );
            adjustSizes(ddIndustrialTargetService);

            // Office target service
            ddOfficeTargetService = (UIDropDown)customOptionsGroup.AddDropdown(
                DTMLang.Text("TARGET_OFFICE"),
                DifficultyOptions.OfficeTargetServiceList,
                isCustom ? DifficultyOptions.Instance.OfficeTargetServiceIndex : dIndex,
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

            freeze = true;
            if ((Difficulties)sel == Difficulties.Custom)
            {
                if (ddConstructionCost != null) ddConstructionCost.selectedIndex = DifficultyOptions.Instance.ConstructionCostMultiplierIndex;
                if (ddRoadConstructionCost != null) ddRoadConstructionCost.selectedIndex = DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex;
                if (ddMaintenanceCostMultiplier != null) ddMaintenanceCostMultiplier.selectedIndex = DifficultyOptions.Instance.MaintenanceCostMultiplierIndex;
                if (ddRoadMaintenanceCostMultiplier != null) ddRoadMaintenanceCostMultiplier.selectedIndex = DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex;
                if (ddAreaCostMultiplier != null) ddAreaCostMultiplier.selectedIndex = DifficultyOptions.Instance.AreaCostMultiplierIndex;
                if (ddDemandOffset != null) ddDemandOffset.selectedIndex = DifficultyOptions.Instance.DemandOffsetIndex;
                if (ddDemandMultiplier != null) ddDemandMultiplier.selectedIndex = DifficultyOptions.Instance.DemandMultiplierIndex;
                if (ddRewardMultiplier != null) ddRewardMultiplier.selectedIndex = DifficultyOptions.Instance.RewardMultiplierIndex;
                if (ddRelocationCostMultiplier != null) ddRelocationCostMultiplier.selectedIndex = DifficultyOptions.Instance.RelocationCostMultiplierIndex;
                if (ddResidentialTargetLandValue != null) ddResidentialTargetLandValue.selectedIndex = DifficultyOptions.Instance.ResidentialTargetLandValueIndex;
                if (ddCommercialTargetLandValue != null) ddCommercialTargetLandValue.selectedIndex = DifficultyOptions.Instance.CommercialTargetLandValueIndex;
                if (ddIndustrialTargetService != null) ddIndustrialTargetService.selectedIndex = DifficultyOptions.Instance.IndustrialTargetServiceIndex;
                if (ddOfficeTargetService != null) ddOfficeTargetService.selectedIndex = DifficultyOptions.Instance.OfficeTargetServiceIndex;
            }
            else
            {
                if (ddConstructionCost != null) ddConstructionCost.selectedIndex = sel;
                if (ddRoadConstructionCost != null) ddRoadConstructionCost.selectedIndex = sel;
                if (ddMaintenanceCostMultiplier != null) ddMaintenanceCostMultiplier.selectedIndex = sel;
                if (ddRoadMaintenanceCostMultiplier != null) ddRoadMaintenanceCostMultiplier.selectedIndex = sel;
                if (ddAreaCostMultiplier != null) ddAreaCostMultiplier.selectedIndex = sel;
                if (ddDemandOffset != null) ddDemandOffset.selectedIndex = sel;
                if (ddDemandMultiplier != null) ddDemandMultiplier.selectedIndex = sel;
                if (ddRewardMultiplier != null) ddRewardMultiplier.selectedIndex = sel;
                if (ddRelocationCostMultiplier != null) ddRelocationCostMultiplier.selectedIndex = sel;
                if (ddResidentialTargetLandValue != null) ddResidentialTargetLandValue.selectedIndex = sel;
                if (ddCommercialTargetLandValue != null) ddCommercialTargetLandValue.selectedIndex = sel;
                if (ddIndustrialTargetService != null) ddIndustrialTargetService.selectedIndex = sel;
                if (ddOfficeTargetService != null) ddOfficeTargetService.selectedIndex = sel;
            }
            freeze = false;

            DifficultyOptions.Instance.Difficulty = (Difficulties)sel;
            DifficultyOptions.Save();

            Achievements.Update();
        }

        private void CustomValueOnSelected(int sel)
        {
            if (freeze) return;

            DifficultyOptions.Instance.Difficulty = Difficulties.Custom;
            freeze = true;
            ddDifficulty.selectedIndex = (int)Difficulties.Custom;
            freeze = false;

            if (ddConstructionCost != null) DifficultyOptions.Instance.ConstructionCostMultiplierIndex = ddConstructionCost.selectedIndex;
            if (ddRoadConstructionCost != null) DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex = ddRoadConstructionCost.selectedIndex;
            if (ddMaintenanceCostMultiplier != null) DifficultyOptions.Instance.MaintenanceCostMultiplierIndex = ddMaintenanceCostMultiplier.selectedIndex;
            if (ddRoadMaintenanceCostMultiplier != null) DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex = ddRoadMaintenanceCostMultiplier.selectedIndex;
            if (ddAreaCostMultiplier != null) DifficultyOptions.Instance.AreaCostMultiplierIndex = ddAreaCostMultiplier.selectedIndex;
            if (ddDemandOffset != null) DifficultyOptions.Instance.DemandOffsetIndex = ddDemandOffset.selectedIndex;
            if (ddDemandMultiplier != null) DifficultyOptions.Instance.DemandMultiplierIndex = ddDemandMultiplier.selectedIndex;
            if (ddRewardMultiplier != null) DifficultyOptions.Instance.RewardMultiplierIndex = ddRewardMultiplier.selectedIndex;
            if (ddRelocationCostMultiplier != null) DifficultyOptions.Instance.RelocationCostMultiplierIndex = ddRelocationCostMultiplier.selectedIndex;
            if (ddResidentialTargetLandValue != null) DifficultyOptions.Instance.ResidentialTargetLandValueIndex = ddResidentialTargetLandValue.selectedIndex;
            if (ddResidentialTargetLandValue != null) DifficultyOptions.Instance.ResidentialTooLowLandValueIndex = ddResidentialTargetLandValue.selectedIndex;
            if (ddCommercialTargetLandValue != null) DifficultyOptions.Instance.CommercialTargetLandValueIndex = ddCommercialTargetLandValue.selectedIndex;
            if (ddCommercialTargetLandValue != null) DifficultyOptions.Instance.CommercialTooLowLandValueIndex = ddCommercialTargetLandValue.selectedIndex;
            if (ddIndustrialTargetService != null) DifficultyOptions.Instance.IndustrialTargetServiceIndex = ddIndustrialTargetService.selectedIndex;
            if (ddIndustrialTargetService != null) DifficultyOptions.Instance.IndustrialTooFewServiceIndex = ddIndustrialTargetService.selectedIndex;
            if (ddOfficeTargetService != null) DifficultyOptions.Instance.OfficeTargetServiceIndex = ddOfficeTargetService.selectedIndex;
            if (ddOfficeTargetService != null) DifficultyOptions.Instance.OfficeTooFewServiceIndex = ddOfficeTargetService.selectedIndex;

            DifficultyOptions.Save();

            Achievements.Update();
        }

        #endregion
    }
}

using ICities;
using ColossalFramework.UI;

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

        public void OnSettingsUI(UIHelperBase helper)
        {
            UIHelperBase difficultyLevelGroup = helper.AddGroup(DTMLang.Text("DTM_OPTIONS"));
            UIComponent ddDifficulty = (UIDropDown)difficultyLevelGroup.AddDropdown(DTMLang.Text("DIFFICULTY_LEVEL"), DifficultyOptions.DifficultyList, (int)DifficultyOptions.Instance.Difficulty, DifficultyLevelOnSelected);
            ddDifficulty.width = 300;

            UIHelperBase customOptionsGroup = helper.AddGroup(DTMLang.Text("CUSTOM_OPTIONS"));
            customOptionsGroup.AddDropdown(DTMLang.Text("CONSTRUCTION_COST"), DifficultyOptions.ConstructionCostMultiplierList,
                DifficultyOptions.Instance.ConstructionCostMultiplierIndex, ConstructionCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("ROAD_CONSTRUCTION_COST"), DifficultyOptions.RoadConstructionCostMultiplierList,
                DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex, RoadConstructionCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("MAINTENANCE_COST"), DifficultyOptions.MaintenanceCostMultiplierList,
                DifficultyOptions.Instance.MaintenanceCostMultiplierIndex, MaintenanceCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("ROAD_MAINTENANCE_COST"), DifficultyOptions.RoadMaintenanceCostMultiplierList,
                DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex, RoadMaintenanceCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("AREA_COST_MULTIPLIER"), DifficultyOptions.AreaCostMultiplierList,
                DifficultyOptions.Instance.AreaCostMultiplierIndex, AreaCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("DEMAND_OFFSET"), DifficultyOptions.DemandOffsetList,
                DifficultyOptions.Instance.DemandOffsetIndex, DemandOffsetOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("DEMAND_MULTIPLIER"), DifficultyOptions.DemandMultiplierList,
                DifficultyOptions.Instance.DemandMultiplierIndex, DemandMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("REWARD"), DifficultyOptions.RewardMultiplierList,
                DifficultyOptions.Instance.RewardMultiplierIndex, RewardMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("RELOCATION_COST"), DifficultyOptions.RelocationCostMultiplierList,
                DifficultyOptions.Instance.RelocationCostMultiplierIndex, RelocationCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("TARGET_RESIDENTIAL"), DifficultyOptions.ResidentialTargetLandValueList,
                DifficultyOptions.Instance.ResidentialTargetLandValueIndex, ResidentialTargetLandValueOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("TARGET_COMMERCIAL"), DifficultyOptions.CommercialTargetLandValueList,
                DifficultyOptions.Instance.CommercialTargetLandValueIndex, CommercialTargetLandValueOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("TARGET_INDUSTRIAL"), DifficultyOptions.IndustrialTargetServiceList,
                DifficultyOptions.Instance.IndustrialTargetServiceIndex, IndustrialTargetServiceOnSelected);
            customOptionsGroup.AddDropdown(DTMLang.Text("TARGET_OFFICE"), DifficultyOptions.OfficeTargetServiceList,
                DifficultyOptions.Instance.OfficeTargetServiceIndex, OfficeTargetServiceOnSelected);

            customOptionsGroup.AddSpace(50);
        }

        private void DifficultyLevelOnSelected(int sel)
        {
            DifficultyOptions.Instance.Difficulty = (Difficulties)sel;
            DifficultyOptions.Save();
            Achievements.Update();
        }
        private void ConstructionCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.ConstructionCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void RoadConstructionCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void MaintenanceCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.MaintenanceCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void RoadMaintenanceCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void AreaCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.AreaCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void DemandOffsetOnSelected(int sel)
        {
            DifficultyOptions.Instance.DemandOffsetIndex = sel;
            DifficultyOptions.Save();
        }
        private void DemandMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.DemandMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void RewardMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.RewardMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void RelocationCostMultiplierOnSelected(int sel)
        {
            DifficultyOptions.Instance.RelocationCostMultiplierIndex = sel;
            DifficultyOptions.Save();
        }
        private void ResidentialTargetLandValueOnSelected(int sel)
        {
            DifficultyOptions.Instance.ResidentialTargetLandValueIndex = sel;
            DifficultyOptions.Instance.ResidentialTooLowLandValueIndex = sel;
            DifficultyOptions.Save();
        }
        private void CommercialTargetLandValueOnSelected(int sel)
        {
            DifficultyOptions.Instance.CommercialTargetLandValueIndex = sel;
            DifficultyOptions.Instance.CommercialTooLowLandValueIndex = sel;
            DifficultyOptions.Save();
        }
        private void IndustrialTargetServiceOnSelected(int sel)
        {
            DifficultyOptions.Instance.IndustrialTargetServiceIndex = sel;
            DifficultyOptions.Instance.IndustrialTooFewServiceIndex = sel;
            DifficultyOptions.Save();
        }
        private void OfficeTargetServiceOnSelected(int sel)
        {
            DifficultyOptions.Instance.OfficeTargetServiceIndex = sel;
            DifficultyOptions.Instance.OfficeTooFewServiceIndex = sel;
            DifficultyOptions.Save();
        }

        #endregion
    }
}

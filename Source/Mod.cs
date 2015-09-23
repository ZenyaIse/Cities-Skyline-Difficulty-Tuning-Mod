using ICities;

namespace DifficultyTuningMod
{
	public class Mod : IUserMod
	{
        public string Name
		{
			get { return "Difficulty Tuning Mod"; }
		}

		public string Description
		{
			get { return "Variety of difficulty levels. No changes in the gameplay."; }
		}


        #region Options UI

        public void OnSettingsUI(UIHelperBase helper)
        {
            UIHelperBase difficultyLevelGroup = helper.AddGroup("Difficulty Tuning Mod Options");
            difficultyLevelGroup.AddDropdown("Difficulty level", DifficultyOptions.DifficultyList, (int)DifficultyOptions.Instance.Difficulty, DifficultyLevelOnSelected);
            //difficultyLevelGroup.AddButton("Save Options", SaveBtnClick);

            UIHelperBase customOptionsGroup = helper.AddGroup("Custom options (effective if Custom difficulty level was selected)");
            customOptionsGroup.AddDropdown("Construction cost (all except roads):", DifficultyOptions.ConstructionCostMultiplierList,
                DifficultyOptions.Instance.ConstructionCostMultiplierIndex, ConstructionCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Road construction cost:", DifficultyOptions.RoadConstructionCostMultiplierList,
                DifficultyOptions.Instance.RoadConstructionCostMultiplierIndex, RoadConstructionCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Maintenance cost (all except roads):", DifficultyOptions.MaintenanceCostMultiplierList,
                DifficultyOptions.Instance.MaintenanceCostMultiplierIndex, MaintenanceCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Road maintenance cost:", DifficultyOptions.RoadMaintenanceCostMultiplierList,
                DifficultyOptions.Instance.RoadMaintenanceCostMultiplierIndex, RoadMaintenanceCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Area cost multiplier:", DifficultyOptions.AreaCostMultiplierList,
                DifficultyOptions.Instance.AreaCostMultiplierIndex, AreaCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Demand offset:  -->  formula for demand: (Demand - Offset) * multiplier", DifficultyOptions.DemandOffsetList,
                DifficultyOptions.Instance.DemandOffsetIndex, DemandOffsetOnSelected);
            customOptionsGroup.AddDropdown("Demand multiplier", DifficultyOptions.DemandMultiplierList,
                DifficultyOptions.Instance.DemandMultiplierIndex, DemandMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Reward (amount of money you get when a milestone is reached):", DifficultyOptions.RewardMultiplierList,
                DifficultyOptions.Instance.RewardMultiplierIndex, RewardMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Service building relocation cost:", DifficultyOptions.RelocationCostMultiplierList,
                DifficultyOptions.Instance.RelocationCostMultiplierIndex, RelocationCostMultiplierOnSelected);
            customOptionsGroup.AddDropdown("Target land values for residential buildings to level up (Level2, 3, 4, 5):", DifficultyOptions.ResidentialTargetLandValueList,
                DifficultyOptions.Instance.ResidentialTargetLandValueIndex, ResidentialTargetLandValueOnSelected);
            customOptionsGroup.AddDropdown("Target land values for commercial buildings to level up (Level2, 3):", DifficultyOptions.CommercialTargetLandValueList,
                DifficultyOptions.Instance.CommercialTargetLandValueIndex, CommercialTargetLandValueOnSelected);
            customOptionsGroup.AddDropdown("Target service for industrial buildings to level up (Level2, 3):", DifficultyOptions.IndustrialTargetServiceList,
                DifficultyOptions.Instance.IndustrialTargetServiceIndex, IndustrialTargetServiceOnSelected);
            customOptionsGroup.AddDropdown("Target service for office buildings to level up (Level2, 3):", DifficultyOptions.OfficeTargetServiceList,
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

        //private void SaveBtnClick()
        //{
        //    DifficultyOptions.Save();
        //}

        #endregion
    }
}

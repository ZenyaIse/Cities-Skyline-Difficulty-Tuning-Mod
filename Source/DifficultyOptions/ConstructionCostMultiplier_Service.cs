namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Service : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Service() : base() { }

        public override string Description
        {
            get
            {
                return DTMLang.Text("CONSTRUCTION_COST_SERVICE");
            }
        }
    }
}

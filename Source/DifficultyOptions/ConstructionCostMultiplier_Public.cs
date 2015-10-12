namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Public : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Public() : base() { }

        public override string Description
        {
            get
            {
                return DTMLang.Text("CONSTRUCTION_COST_PUBLIC");
            }
        }
    }
}

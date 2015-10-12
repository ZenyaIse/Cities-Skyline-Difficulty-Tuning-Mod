namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier_Service : MaintenanceCostMultiplier
    {
        public MaintenanceCostMultiplier_Service() : base() { }

        public override string Description
        {
            get
            {
                return DTMLang.Text("MAINTENANCE_COST_SERVICE");
            }
        }
   }
}
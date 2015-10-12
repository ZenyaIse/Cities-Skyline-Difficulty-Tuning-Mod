namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier_Road : MaintenanceCostMultiplier
    {
        public MaintenanceCostMultiplier_Road() : base() { }

        public override string Description
        {
            get
            {
                return DTMLang.Text("MAINTENANCE_COST_ROADS");
            }
        }
        
        public override float GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0.5f;
                case Difficulties.Easy:
                    return 0.75f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Advanced:
                    return 1.4f;
                case Difficulties.Hard:
                    return 1.8f;
                case Difficulties.Expert:
                    return 2.2f;
                case Difficulties.Challenge:
                    return 2.6f;
                case Difficulties.Impossible:
                    return 3f;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
        }
   }
}
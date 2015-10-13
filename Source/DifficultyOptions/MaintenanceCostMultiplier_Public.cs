namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier_Public : MaintenanceCostMultiplier
    {
        public MaintenanceCostMultiplier_Public() : base() { }
        
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
                    return 1.1f;
                case Difficulties.Hard:
                    return 1.2f;
                case Difficulties.Expert:
                    return 1.3f;
                case Difficulties.Challenge:
                    return 1.4f;
                case Difficulties.Impossible:
                    return 1.5f;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
        }
   }
}
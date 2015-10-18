namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier_Public : MaintenanceCostMultiplier
    {
        public MaintenanceCostMultiplier_Public() : base() { }
        
        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 75;
                case Difficulties.Normal:
                    return 100;
                case Difficulties.Advanced:
                    return 110;
                case Difficulties.Hard:
                    return 120;
                case Difficulties.Expert:
                    return 130;
                case Difficulties.Challenge:
                    return 140;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 150;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 50;
                case Difficulties.PublicTransport:
                    return 0;
            }

            return 100;
        }
   }
}
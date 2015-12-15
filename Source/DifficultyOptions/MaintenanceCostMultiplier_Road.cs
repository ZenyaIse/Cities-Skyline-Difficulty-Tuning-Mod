namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier_Road : MaintenanceCostMultiplier
    {
        public MaintenanceCostMultiplier_Road() : base() { }
        
        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 75;
                case Difficulties.Normal:
                    return 100;
                case Difficulties.Advanced:
                    return 140;
                case Difficulties.Hard:
                    return 180;
                case Difficulties.Expert:
                    return 240;
                case Difficulties.Challenge:
                    return 300;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 400;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 50;
            }

            return 100;
        }
   }
}
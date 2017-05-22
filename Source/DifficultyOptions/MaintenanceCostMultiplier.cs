namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier : DifficultyParameterBase
    {
        public MaintenanceCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[49];

            int i;
            for (i = 0; i <= 30; i++) customValues[i] = 5 * i;                // 0, 5, .. 150
            for (i = 31; i <= 41; i++) customValues[i] = 150 + 10 * (i - 30);  // 160, 170, .. 260
            for (i = 42; i <= 48; i++) customValues[i] = 260 + 20 * (i - 41);  // 280, 300, .. 400
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 75;
                case Difficulties.Normal:
                    return 100;
                case Difficulties.Advanced:
                    return 125;
                case Difficulties.Hard:
                    return 150;
                case Difficulties.Expert:
                    return 180;
                case Difficulties.Challenge:
                    return 210;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 240;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 50;
            }

            return 100;
        }
        
        protected override string valueToStr(int value)
        {
            return value.ToString() + "%";
        }
    }
}
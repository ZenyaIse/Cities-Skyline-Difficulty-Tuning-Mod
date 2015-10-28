namespace DifficultyTuningMod.DifficultyOptions
{
    public class PollutionRadiusMultiplier : DifficultyParameterBase
    {
        public PollutionRadiusMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[15];
            
            int i;
            for (i = 0; i <= 7; i++) customValues[i] = 25 * i; // 0, 25, 50, 75, 100, 125, 175
            for (i = 8; i <= 14; i++) customValues[i] = 200 + 50 * (i - 8); // 200, 250, .. 500
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
                    return 100;
                case Difficulties.Hard:
                    return 125;
                case Difficulties.Expert:
                    return 150;
                case Difficulties.Challenge:
                    return 200;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 300;
                case Difficulties.Free:
                    return 50;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 100;
        }
        
        protected override string valueToStr(int value)
        {
            return "x" + (value / 100f).ToString();
        }
    }
}
namespace DifficultyTuningMod.DifficultyOptions
{
    public class PopulationTargetMultiplier : DifficultyParameterBase
    {
        public PopulationTargetMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[36];
            
            int i;
            for (i =  0; i <= 30; i++) customValues[i] = 5 * i;                // 0, 5, .. 150
            for (i = 31; i <= 35; i++) customValues[i] = 150 + 10 * (i - 30);  // 160, 170, .. 200
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
            }

            return 100;
        }
        
        protected override string valueToStr(int value)
        {
            return "x" + (value / 100f).ToString("0.00");
        }
    }
}
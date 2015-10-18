namespace DifficultyTuningMod.DifficultyOptions
{
    public class DemandMultiplier : DifficultyParameterBase
    {
        public DemandMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[21];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 50 + 5 * i; // 50, 55, .. 150
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 100;
                case Difficulties.Normal:
                    return 100;
                case Difficulties.Advanced:
                    return 95;
                case Difficulties.Hard:
                    return 90;
                case Difficulties.Expert:
                    return 85;
                case Difficulties.Challenge:
                    return 80;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 75;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 100;
            }

            return 100;
        }
        
        protected override string valueToStr(int value)
        {
            return "x" + (value / 100f).ToString("0.00");
        }
    }
}
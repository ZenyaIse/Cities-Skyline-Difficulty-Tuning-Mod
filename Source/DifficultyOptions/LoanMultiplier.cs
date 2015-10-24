namespace DifficultyTuningMod.DifficultyOptions
{
    public class LoanMultiplier : DifficultyParameterBase
    {
        public LoanMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[15];
            
            int i;
            for (i = 0; i <= 5; i++) customValues[i] = 25 * (i + 1); // 25, 50, 75, 100, 125, 150
            for (i = 6; i <= 14; i++) customValues[i] = 200 + 100 * (i - 6); // 200, 300, .. 1000
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
                    return 100;
                case Difficulties.Hard:
                    return 100;
                case Difficulties.Expert:
                    return 150;
                case Difficulties.Challenge:
                    return 200;
                case Difficulties.Impossible:
                //case Difficulties.HardAndFast: <- not required here
                    return 300;
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
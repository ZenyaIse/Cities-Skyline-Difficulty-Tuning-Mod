namespace DifficultyTuningMod.DifficultyOptions
{
    public class AreaCostMultiplier : DifficultyParameterBase
    {
        public AreaCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 10;
            customValues = new int[21];
            
            int i;
            for (i = 0; i <= 4; i++) customValues[i] = 5 * i; // 0, 5, 10, 15, 20
            for (i = 5; i <= 12; i++) customValues[i] = 20 + 10 * (i - 4); // 30, 40, .. 100
            for (i = 13; i <= 20; i++) customValues[i] = 100 + 50 * (i - 12); // 150, 200, .. 500
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0;
                case Difficulties.Easy:
                    return 5;
                case Difficulties.Normal:
                    return 10;
                case Difficulties.Advanced:
                    return 20;
                case Difficulties.Hard:
                    return 30;
                case Difficulties.Expert:
                    return 50;
                case Difficulties.Challenge:
                    return 100;
                case Difficulties.Impossible:
                    return 200;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 10;
        }
        
        protected override string valueToStr(int value)
        {
            return "x" + (value / 10f).ToString();
        }
    }
}
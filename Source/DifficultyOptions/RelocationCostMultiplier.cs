namespace DifficultyTuningMod.DifficultyOptions
{
    public class RelocationCostMultiplier : DifficultyParameterBase
    {
        public RelocationCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 20;
            customValues = new int[21];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 5 * i; // 0, 5, .. 100
        }
        
        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 10;
                case Difficulties.Normal:
                    return 20;
                case Difficulties.Advanced:
                    return 30;
                case Difficulties.Hard:
                    return 40;
                case Difficulties.Expert:
                    return 50;
                case Difficulties.Challenge:
                    return 60;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 70;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 0;
            }

            return 20;
        }
        
        protected override string valueToStr(int value)
        {
            return value.ToString() + "%";
        }
    }
}
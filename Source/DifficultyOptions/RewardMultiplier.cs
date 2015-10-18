namespace DifficultyTuningMod.DifficultyOptions
{
    public class RewardMultiplier : DifficultyParameterBase
    {
        public RewardMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 100;
            customValues = new int[21];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 10 * i; // 0, 10, .. 200
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
                    return 50;
                case Difficulties.Hard:
                    return 20;
                case Difficulties.Expert:
                    return 0;
                case Difficulties.Challenge:
                    return 0;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 0;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 100;
            }

            return 100;
        }
        
        protected override string valueToStr(int value)
        {
            return value.ToString() + "%";
        }
    }
}
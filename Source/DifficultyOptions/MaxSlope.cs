namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaxSlope : DifficultyParameterContinuous
    {
        public MaxSlope() : base() { }

        protected override void InitValues()
        {
            minValue = 5;
            maxValue = 100;
            step = 1;
            CustomValue = 25;
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Easy:
                    return 30;
                case Difficulties.Normal:
                    return 25;
                case Difficulties.Advanced:
                    return 23;
                case Difficulties.Hard:
                    return 21;
                case Difficulties.Expert:
                    return 19;
                case Difficulties.Challenge:
                    return 17;
                case Difficulties.Impossible:
                case Difficulties.HardAndFast:
                    return 15;
                case Difficulties.Custom:
                    return CustomValue;
                case Difficulties.Free:
                    return 40;
            }

            return 25;
        }

        protected override string valueToStr(int value)
        {
            return value.ToString() + "%";
        }
    }
}
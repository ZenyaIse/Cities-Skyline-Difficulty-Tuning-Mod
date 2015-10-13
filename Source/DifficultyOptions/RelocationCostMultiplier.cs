namespace DifficultyTuningMod.DifficultyOptions
{
    public class RelocationCostMultiplier : DifficultyParameterFloat
    {
        public RelocationCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 1f;
            customValues = new float[21];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 0.05f * i; // 0, 0.05, .. 1.0
        }
        
        public override float GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0f;
                case Difficulties.Easy:
                    return 0.1f;
                case Difficulties.Normal:
                    return 0.2f;
                case Difficulties.Advanced:
                    return 0.35f;
                case Difficulties.Hard:
                    return 0.5f;
                case Difficulties.Expert:
                    return 0.6f;
                case Difficulties.Challenge:
                    return 0.7f;
                case Difficulties.Impossible:
                    return 0.8f;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
        }
        
        protected override string valueToStr(float value)
        {
            return (value * 100).ToString() + "%";
        }
    }
}
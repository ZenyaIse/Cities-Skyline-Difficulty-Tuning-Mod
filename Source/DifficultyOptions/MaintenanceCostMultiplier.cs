namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier : DifficultyParameterFloat
    {
        public MaintenanceCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 1f;
            customValues = new float[50];
            
            int i;
            for (i =  0; i <= 30; i++) customValues[i] = 0.05f * i;              // 0, 0.05, .. 1.5
            for (i = 31; i <= 35; i++) customValues[i] = 1.5f + 0.1f * (i - 30); // 1.6, 1.7, .. 2.0
            for (i = 36; i <= 40; i++) customValues[i] = 2.0f + 0.2f * (i - 35); // 2.2, 2.4, .. 3.0
            for (i = 41; i <= 44; i++) customValues[i] = 3.0f + 0.5f * (i - 40); // 3.5, 4.0, 4.5, 5.0
            for (i = 45; i <= 49; i++) customValues[i] = 5.0f + 1f * (i - 44);   // 6, 7, .. 10
        }
        
        public override float GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0.5f;
                case Difficulties.Easy:
                    return 0.75f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Advanced:
                    return 1.2f;
                case Difficulties.Hard:
                    return 1.4f;
                case Difficulties.Expert:
                    return 1.6f;
                case Difficulties.Challenge:
                    return 1.8f;
                case Difficulties.Impossible:
                    return 2f;
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
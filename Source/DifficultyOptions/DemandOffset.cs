namespace DifficultyTuningMod.DifficultyOptions
{
    public class DemandOffset : DifficultyParameterBase
    {
        public DemandOffset() : base() { }

        protected override void InitValues()
        {
            CustomValue = 0;
            customValues = new int[51];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 200 - 10 * i; // 200, 190, .. 0
            for (i = 21; i <= 50; i++) customValues[i] = 20 - i; // -1, -2, .. -30
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 200;
                case Difficulties.Easy:
                    return 20;
                case Difficulties.Normal:
                    return 0;
                case Difficulties.Advanced:
                    return -10;
                case Difficulties.Hard:
                    return -15;
                case Difficulties.Expert:
                    return -20;
                case Difficulties.Challenge:
                    return -21;
                case Difficulties.Impossible:
                    return -22;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 0;
        }
        
        protected override string valueToStr(int value)
        {
            return value.ToString();
        }
    }
}
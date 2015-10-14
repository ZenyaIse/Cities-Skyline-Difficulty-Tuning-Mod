namespace DifficultyTuningMod.DifficultyOptions
{
    public class InitialMoney : DifficultyParameterBase
    {
        public InitialMoney() : base() { }

        protected override void InitValues()
        {
            CustomValue = 10;
            customValues = new int[21];
            
            int i;
            for (i = 0; i <= 20; i++) customValues[i] = 10 * i; // 0, 10, .. 200
        }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0;
                case Difficulties.Easy:
                    return 70;
                case Difficulties.Normal:
                    return 70;
                case Difficulties.Advanced:
                    return 70;
                case Difficulties.Hard:
                    return 70;
                case Difficulties.Expert:
                    return 70;
                case Difficulties.Challenge:
                    return 80;
                case Difficulties.Impossible:
                    return 100;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 70;
        }
        
        protected override string valueToStr(int value)
        {
            return value.ToString() + " 000₡";
        }
    }
}
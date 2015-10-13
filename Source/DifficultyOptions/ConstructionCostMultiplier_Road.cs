namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Road : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Road() : base() { }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0;
                case Difficulties.Easy:
                    return 50;
                case Difficulties.Normal:
                    return 100;
                case Difficulties.Advanced:
                    return 150;
                case Difficulties.Hard:
                    return 200;
                case Difficulties.Expert:
                    return 300;
                case Difficulties.Challenge:
                    return 500;
                case Difficulties.Impossible:
                    return 700;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 100;
        }
    }
}

namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Road : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Road() : base() { }

        public override float GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.Free:
                    return 0;
                case Difficulties.Easy:
                    return 0.5f;
                case Difficulties.Normal:
                    return 1f;
                case Difficulties.Advanced:
                    return 1.5f;
                case Difficulties.Hard:
                    return 2f;
                case Difficulties.Expert:
                    return 3f;
                case Difficulties.Challenge:
                    return 5f;
                case Difficulties.Impossible:
                    return 7f;
                case Difficulties.Custom:
                    return CustomValue;
            }

            return 1f;
        }
    }
}

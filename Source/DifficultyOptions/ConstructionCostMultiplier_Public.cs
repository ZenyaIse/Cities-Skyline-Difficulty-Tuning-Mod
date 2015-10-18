namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Public : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Public() : base() { }

        public override int GetValue(Difficulties difficultyLevel)
        {
            switch (difficultyLevel)
            {
                case Difficulties.PublicTransport:
                    return 0;
            }

            return base.GetValue(difficultyLevel);
        }
    }
}

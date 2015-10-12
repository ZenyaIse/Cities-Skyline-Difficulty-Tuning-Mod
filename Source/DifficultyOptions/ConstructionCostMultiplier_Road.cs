namespace DifficultyTuningMod.DifficultyOptions
{
    public class ConstructionCostMultiplier_Road : ConstructionCostMultiplier
    {
        public ConstructionCostMultiplier_Road() : base() { }

        protected override void InitValues()
        {
            CustomValue = 1f;
            customValues = new float[] { 0, 0.25f, 0.5f, 0.75f, 1f, 1.25f, 1.5f, 2f, 3f, 4f, 5f, 7f, 10f };
        }

        public override string Description
        {
            get
            {
                return DTMLang.Text("CONSTRUCTION_COST_ROADS");
            }
        }

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

            return 1;
        }
    }
}

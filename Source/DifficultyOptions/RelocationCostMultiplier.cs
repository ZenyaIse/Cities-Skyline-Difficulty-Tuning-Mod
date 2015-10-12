namespace DifficultyTuningMod.DifficultyOptions
{
    public class RelocationCostMultiplier : DifficultyParameterFloat
    {
        public RelocationCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 1f;
            customValues = new float[] { 0, 0.25f, 0.5f, 0.75f, 1f, 1.2f, 1.4f, 1.6f, 1.8f, 2f, 2.2f, 2.6f, 3f };
        }

        public override string Description
        {
            get
            {
                return DTMLang.Text("RELOCATION_COST");
            }
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
                    return 0.3f;
                case Difficulties.Hard:
                    return 0.4f;
                case Difficulties.Expert:
                    return 1.6f;
                case Difficulties.Challenge:
                    return 0.8f;
                case Difficulties.Impossible:
                    return 0.9f;
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
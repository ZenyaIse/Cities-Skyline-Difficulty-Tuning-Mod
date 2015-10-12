namespace DifficultyTuningMod.DifficultyOptions
{
    public class MaintenanceCostMultiplier : DifficultyParameterFloat
    {
        public MaintenanceCostMultiplier() : base() { }

        protected override void InitValues()
        {
            CustomValue = 1f;
            customValues = new float[] { 0, 0.25f, 0.5f, 0.75f, 1f, 1.2f, 1.4f, 1.6f, 1.8f, 2f, 2.2f, 2.6f, 3f };
        }

        public override string Description
        {
            get
            {
                return DTMLang.Text("MAINTENANCE_COST_OTHERS");
            }
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